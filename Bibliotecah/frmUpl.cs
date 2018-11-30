using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using Microsoft.VisualBasic.Devices;
using System.Text.RegularExpressions;
using System.Threading;

namespace Bibliotecah
{
    public partial class frmUpl : Form
    {
        List<string> ListaArchivos = new List<string>();
        string ruta_guardado = "";
        List<string> Duplicados = new List<string>();
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        admin_bibliotecahEntities A = new admin_bibliotecahEntities();

        public frmUpl()
        {
            InitializeComponent();
        }

        private void frmUpl_Load(object sender, EventArgs e)
        {
            var cbtipos = from tipos in A.TiposCarreras
                          select tipos;

            DataTable dtunidades = new DataTable();

            dtunidades.Columns.Add("PkID_TipoCarrera", typeof(int));
            dtunidades.Columns.Add("Descripcion", typeof(string));

            foreach (var un in cbtipos)
            {
                DataRow dtRow = dtunidades.NewRow();
                dtRow["PkID_TipoCarrera"] = un.PkID_TipoCarrera;
                dtRow["Descripcion"] = un.Descripcion;
                dtunidades.Rows.Add(dtRow);
            }

            cbotipo.DataSource = dtunidades;
            cbotipo.DisplayMember = "Descripcion";
            cbotipo.ValueMember = "PkID_TipoCarrera";

            int[] trimestres = { 1, 2, 3 };

            foreach (int tri in trimestres)
            {
                cbotrimestre.Items.Add(tri);
            }

            cbotrimestre.SelectedIndex = 0;
        }

        private void llenar_carreras(int idtipo)
        {
            var cbcarreras = from tipos in A.Carreras
                             where tipos.FkID_TipoCarrera == idtipo
                             select tipos;

            DataTable dtunidades = new DataTable();

            dtunidades.Columns.Add("PkID_Carrera", typeof(int));
            dtunidades.Columns.Add("Carrera", typeof(string));

            foreach (var un in cbcarreras)
            {
                DataRow dtRow = dtunidades.NewRow();
                dtRow["PkID_Carrera"] = un.PkID_Carrera;
                dtRow["Carrera"] = un.Carrera;
                dtunidades.Rows.Add(dtRow);
            }

            cbo_carrera.DataSource = dtunidades;
            cbo_carrera.DisplayMember = "Carrera";
            cbo_carrera.ValueMember = "PkID_Carrera";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            System.Windows.Forms.Application.Exit();
        }

        private void frmUpl_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnupload_Click(object sender, EventArgs e)
        {
            FrmMenuP x = new FrmMenuP();
            x.Show();
            this.Hide();
        }

        private void lwlista_DragEnter(object sender, DragEventArgs e)
        {
            lbladv.Text = string.Empty;
            lblinfo.Text = string.Empty;
            Duplicados.Clear();
            string destino = Bibliotecah.MiClaseMagica.Variables_Globales.RUTA_SERVIDOR;
            string[] droppfiles = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string item in droppfiles)
            {
                FileAttributes check = File.GetAttributes(item);
                if ((check & FileAttributes.Directory) == FileAttributes.Directory)
                {
                    //Detecta que es un directorio.
                    if(!ListaArchivos.Contains(item))
                    {
                        imgiconosexplorer.Images.Add(Bibliotecah.Properties.Resources.Folder);
                        DirectoryInfo file = new DirectoryInfo(item);
                        ListaArchivos.Add(file.FullName);
                        ListViewItem d = new ListViewItem(file.Name, imgiconosexplorer.Images.Count - 1);
                        d.Name = file.FullName;
                        lwlista.Items.Add(d);
                    }
                    else
                    {
                        return;
                    }
                }
            }

        }

        private void lwlista_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effect = DragDropEffects.All;
            }
        }

        private void frmUpl_DragEnter(object sender, DragEventArgs e)
        {

        }

        private void frmUpl_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void lwlista_MouseEnter(object sender, EventArgs e)
        {

        }

        private void lwlista_MouseHover(object sender, EventArgs e)
        {
        }

        private void lwlista_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void cbotipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbotipo_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbotipo.SelectedIndex >= 0)
            {
                int n;
                bool isNumeric = int.TryParse(cbotipo.SelectedValue.ToString(), out n);

                if(isNumeric)
                {
                    int tipo = Convert.ToInt16(cbotipo.SelectedValue);
                    llenar_carreras(tipo);
                }
            }        
        }   

        private void ruta()
        {
            string arg_cbo = @"\" + cbotipo.Text + @"\" + cbo_carrera.Text + @"\" + txtanio.Text + @"\" + cbotrimestre.Text + @"\";
            ruta_guardado = Bibliotecah.MiClaseMagica.Variables_Globales.RUTA_SERVIDOR + @"\" + cbotipo.Text;

            if (!System.IO.Directory.Exists(ruta_guardado))
            {
                System.IO.Directory.CreateDirectory(ruta_guardado);
            }

            ruta_guardado += @"\" + cbo_carrera.Text;


            if (!System.IO.Directory.Exists(ruta_guardado))
            {
                System.IO.Directory.CreateDirectory(ruta_guardado);
            }

            ruta_guardado += @"\" + txtanio.Text;


            if (!System.IO.Directory.Exists(ruta_guardado))
            {
                System.IO.Directory.CreateDirectory(ruta_guardado);
            }


            ruta_guardado += @"\" + cbotrimestre.Text;


            if (!System.IO.Directory.Exists(ruta_guardado))
            {
                System.IO.Directory.CreateDirectory(ruta_guardado);
            }

            bool exists = System.IO.Directory.Exists(ruta_guardado);

            if(exists)
            {
                bool subida = false;
                foreach (string file in ListaArchivos)
                {
                    string filename = getfilename(file);
                    FileAttributes check = File.GetAttributes(file);
                    if ((check & FileAttributes.Directory) == FileAttributes.Directory)
                    {
                        //Detecta que es un directorio.
                        DirectoryInfo directorio_copy = new DirectoryInfo(file);

                        string[] cadena = file.Split('\\');
                        string nombre = cadena[(cadena.Length) - 1];

                        string checkeo = ruta_guardado + @"\" + nombre;


                        if(System.IO.Directory.Exists(checkeo))
                        {
                            lbladv.ForeColor = System.Drawing.Color.Yellow;
                            lbladv.Text = "¡Algunos archivos no pudieron copiarse debido a que ya existen en el sitio al que intenta copiarlos! Clic aqui saber más.";
                            Duplicados.Add(filename);
                        }
                        else
                        {
                            DirectoryInfo carpeta_destino = new DirectoryInfo(ruta_guardado);
                            var x = carpeta_destino.CreateSubdirectory(nombre);

                            DirectoryCopy(directorio_copy.FullName, x.FullName, true);

                            subida = true;

                            Archivos nuevo = new Archivos();

                            //MessageBox.Show(file);
                            //MessageBox.Show(filename);

                            nuevo.FkID_Carrera = Convert.ToInt16(cbo_carrera.SelectedValue);
                            nuevo.FkID_Carrera = 1;
                            nuevo.Autor = filename;
                            nuevo.Nombre = filename;
                            nuevo.Fecha_Creacion = DateTime.Now;
                            nuevo.Fecha_Modificacion = DateTime.Now;
                            nuevo.Ruta = checkeo;
                            nuevo.Estado = true;

                            A.Archivos.Add(nuevo);
                            A.SaveChanges();

                            Historiales nuevo2 = new Historiales();

                            nuevo2.FkID_Usuario = Convert.ToSByte(MiClaseMagica.Variables_Globales.ACTIVE_USER);
                            nuevo2.FKID_Operacion = 1;
                            nuevo2.FKID_Archivo = nuevo.PkID_Archivo;
                            nuevo2.Fecha_Historial = DateTime.Now;
                            A.Historiales.Add(nuevo2);
                            A.SaveChanges();

                        }

                    }
                }
                lblinfo.ForeColor = System.Drawing.Color.Lime;
                lblinfo.Text = subida == true ? "¡Carga de archivos completada!":string.Empty;
            }

        }

        private string getfilename(string ruta)
        {
            return Path.GetFileNameWithoutExtension(ruta);
        }

        private static void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
        {
            // Get the subdirectories for the specified directory.
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);

            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + sourceDirName);
            }

            DirectoryInfo[] dirs = dir.GetDirectories();
            // If the destination directory doesn't exist, create it.
            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }

            // Get the files in the directory and copy them to the new location.
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string temppath = Path.Combine(destDirName, file.Name);
                if (!System.IO.File.Exists(temppath))
                {
                    file.CopyTo(temppath, false);
                }
            }

            // If copying subdirectories, copy them and their contents to new location.
            if (copySubDirs)
            {
                foreach (DirectoryInfo subdir in dirs)
                {
                    string temppath = Path.Combine(destDirName, subdir.Name);
                    DirectoryCopy(subdir.FullName, temppath, copySubDirs);
                }
            }
        }

        private void cbo_carrera_SelectedValueChanged(object sender, EventArgs e)
        {
        }

        private void btncarga_Click(object sender, EventArgs e)
        {

            if (txtanio.Text != string.Empty)
            {
                int iYear = Convert.ToInt16(txtanio.Text);
                int anio_actual = DateTime.Now.Year;
                int anio_minimo = 2000;


                if (iYear < anio_minimo || iYear > anio_actual)
                {
                    lblinfo.ForeColor = System.Drawing.Color.Red;
                    lblinfo.Text = "¡El año ingresado no es valido!";
                    return;
                }
            }
            else
            {
                lblinfo.ForeColor = System.Drawing.Color.Red;
                lblinfo.Text = "¡Por favor digite el año al que corresponde el archivo!";
                return;
            }

            ruta();
            lwlista.Items.Clear();
            lwlista.LargeImageList = imgiconosexplorer;
            lwlista.Refresh();
            ListaArchivos.Clear();
        }

        private void opciones_Opening(object sender, CancelEventArgs e)
        {
            e.Cancel = this.lwlista.SelectedItems.Count <= 0;
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if(lwlista.SelectedItems.Count >= 0)
            {
                foreach(ListViewItem item in lwlista.SelectedItems)
                {
                    int index = ListaArchivos.IndexOf(item.Name);
                    ListaArchivos.RemoveAt(index);
                    lwlista.Items.RemoveAt(item.Index);
                }
            }
        }

        private void holaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {


        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void lbladv_Click(object sender, EventArgs e)
        {
            if(Duplicados.Count != 0)
            {
                foreach(string item in Duplicados)
                {
                    MessageBox.Show(item, "Archivo Duplicado", MessageBoxButtons.OK,MessageBoxIcon.Information);
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtanio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtanio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }
    }
}

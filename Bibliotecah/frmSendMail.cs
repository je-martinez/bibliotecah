using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;
using System.Runtime.InteropServices;


namespace Bibliotecah
{
    public partial class frmSendMail : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public frmSendMail()
        {
            InitializeComponent();
        }

        string ruta_envio;
        admin_bibliotecahEntities A = new admin_bibliotecahEntities();


        private void btnenviar_Click(object sender, EventArgs e)
        {

            if(txtpara.Text == string.Empty || txtasunto.Text == string.Empty || txtcuerpo.Text == string.Empty || txtdestinatario.Text == string.Empty || txtdestinatarioidentidad.Text == string.Empty)
            {
                lblinfo.ForeColor = System.Drawing.Color.Red;
                lblinfo.Text = "¡Se enviaron algunos campos vacios!";
                return;
            }

            crear_mensaje();
        }

        private void crear_mensaje()
        {
            string user = Bibliotecah.MiClaseMagica.Variables_Globales.SMTP_USER;
            string pass = Bibliotecah.MiClaseMagica.Variables_Globales.SMTP_PASS;
            string smtp = Bibliotecah.MiClaseMagica.Variables_Globales.SMTP_SERVER;
            string correo_calidad = Bibliotecah.MiClaseMagica.Variables_Globales.CALIDAD_EMAIL;
 
            MailMessage mi_mensajito = new MailMessage(txtde.Text, txtpara.Text, txtasunto.Text, txtcuerpo.Text);

            //Adjunto
            string url_envio = "";
            if (lwlista.SelectedItems.Count != 0)
            {

                foreach(ListViewItem elemento in lwlista.SelectedItems)
                {
                    url_envio = compresion_magica(ruta_envio, elemento.Text);
                    if (url_envio != string.Empty)
                    {
                        mi_mensajito.Attachments.Add(new Attachment(url_envio));
                    }
                }
            }
            else
            {
                lblinfo.ForeColor = System.Drawing.Color.Red;
                lblinfo.Text = "¡No se han seleccionado archivo o archivos adjunto!";
                return;
            }

            SmtpClient cliente = new SmtpClient(smtp);

            cliente.Port = 587;

            cliente.Credentials = new System.Net.NetworkCredential(user, pass);

            cliente.EnableSsl = true;

            cliente.Send(mi_mensajito);

            //-----Correo para Marlene-----

            MailMessage mi_mensajito_calidad = new MailMessage(txtde.Text, correo_calidad, txtasunto.Text, txtcuerpo.Text);

            if (lwlista.SelectedItems.Count != 0)
            {

                foreach (ListViewItem elemento in lwlista.SelectedItems)
                {
                    if (url_envio != string.Empty)
                    {
                        mi_mensajito_calidad.Attachments.Add(new Attachment(url_envio));
                    }
                }
            }
            else
            {
                lblinfo.ForeColor = System.Drawing.Color.Red;
                lblinfo.Text = "¡Error al enviar el correo a calidad!";
                return;
            }

            SmtpClient cliente_calidad = new SmtpClient(smtp);

            cliente_calidad.Port = 587;

            cliente_calidad.Credentials = new System.Net.NetworkCredential(user, pass);

            cliente_calidad.EnableSsl = true;

            cliente_calidad.Send(mi_mensajito_calidad);


            if (lwlista.SelectedItems.Count != 0)
            {
                string dele = MiClaseMagica.Variables_Globales.RUTA_SERVIDOR + @"\" + "Envios";
            }

            lblinfo.ForeColor = System.Drawing.Color.Lime;
            lblinfo.Text = "¡Mensaje enviado exitosamente!";

            if(lwlista.SelectedItems.Count != 0)
            {
                foreach(ListViewItem a in lwlista.SelectedItems)
                {
                    Envios correitos = new Envios();
                    try
                    {
                        var tblUsuario = A.Archivos.FirstOrDefault(x => x.Autor == a.Text);
                        if(tblUsuario != null)
                        {
                            correitos.FkID_Archivo = tblUsuario != null ? Convert.ToInt32(tblUsuario.PkID_Archivo) : Convert.ToInt32(null);
                            correitos.FkID_Usuario = Convert.ToSByte(MiClaseMagica.Variables_Globales.ACTIVE_USER);
                            correitos.Nombre_Receptor = txtdestinatario.Text;
                            correitos.Identidad_Receptor = txtdestinatarioidentidad.Text;
                            correitos.Correo_Receptor = txtpara.Text;
                            correitos.Fecha_Envio = DateTime.Now;

                            txtpara.Text = txtasunto.Text = txtcuerpo.Text = txtdestinatario.Text = txtdestinatarioidentidad.Text = string.Empty;
                        }
                        else
                        {
                            lblinfo.ForeColor = System.Drawing.Color.Red;
                            lblinfo.Text = "¡Ha ocurrido un error con los archivos adjuntos! Asegurese que existan en la carpeta principal";
                        }

                    }
                    catch (Exception abc)
                    {

                    }                
                }
            }
        }


        private void generar_ruta()
        {
            ruta_envio = Bibliotecah.MiClaseMagica.Variables_Globales.RUTA_SERVIDOR + @"\" + cbotipo.Text;

            ruta_envio += @"\" + cbo_carrera.Text;

            ruta_envio += @"\" + txtanio.Text;

            ruta_envio += @"\" + cbotrimestre.Text;
        }

        private void abrir_directorio(string ruta)
        {
            lwlista.Clear();
            lwlista.Items.Clear();

            //Directorios
            foreach (string item in Directory.GetDirectories(ruta))
            {
                imgiconosexplorer.Images.Add(Bibliotecah.Properties.Resources.Folder);
                DirectoryInfo file = new DirectoryInfo(item);
                ListViewItem d = new ListViewItem(file.Name, imgiconosexplorer.Images.Count - 1);
                d.Name = file.FullName;
                lwlista.Items.Add(d);
            }

            //Archivos
            foreach (string item in Directory.GetFiles(ruta))
            {
                imgiconosexplorer.Images.Add(System.Drawing.Icon.ExtractAssociatedIcon(item));
                FileInfo file = new FileInfo(item);
                ListViewItem d = new ListViewItem(file.Name, imgiconosexplorer.Images.Count - 1);
                d.Name = file.FullName;
                lwlista.Items.Add(d);
            }

        }

        private string compresion_magica(string url, string name)
        {
            string zip = string.Empty;
            string x = MiClaseMagica.Variables_Globales.RUTA_SERVIDOR + @"\" + "Envios";
            if (!System.IO.Directory.Exists(x))
            {
                DirectoryInfo asd = new DirectoryInfo(MiClaseMagica.Variables_Globales.RUTA_SERVIDOR);
                asd.CreateSubdirectory("Envios");
            }

            string directorio = url + @"\" + name;
            zip = MiClaseMagica.Variables_Globales.RUTA_SERVIDOR + @"\" + "Envios" + @"\" + name + ".zip";

            if (!System.IO.File.Exists(zip))
            {
                ZipFile.CreateFromDirectory(directorio, zip);
            }

            return zip;
        }

        private void btnsubir_Click(object sender, EventArgs e)
        {
           /* OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "PDF Files (*.pdf)|*.pdf";

            if(dialog.ShowDialog()==DialogResult.OK)
            {
                string ruta_archivo = dialog.FileName.ToString();
                txtadjunto.Text = ruta_archivo;
            }*/
        }

        private void frmSendMail_Load(object sender, EventArgs e)
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

            cbotipo.SelectedIndex = 0;

            int tipo = Convert.ToInt16(cbotipo.SelectedValue);
            llenar_carreras(tipo);

            int[] trimestres = { 1, 2, 3 };

            foreach (int tri in trimestres)
            {
                cbotrimestre.Items.Add(tri);
            }

            cbotrimestre.SelectedIndex = 0;

            txtde.Text = MiClaseMagica.Variables_Globales.SMTP_USER;
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

        private void frmSendMail_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label15_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            System.Windows.Forms.Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void btnupload_Click(object sender, EventArgs e)
        {
            FrmMenuP x = new FrmMenuP();
            x.Show();
            this.Hide();
        }

        private void cbotipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbotipo.SelectedIndex >= 0)
            {
                int n;
                bool isNumeric = int.TryParse(cbotipo.SelectedValue.ToString(), out n);

                if (isNumeric)
                {
                    int tipo = Convert.ToInt16(cbotipo.SelectedValue);
                    llenar_carreras(tipo);
                    generar_ruta();
                    if(System.IO.Directory.Exists(ruta_envio))
                    {
                        abrir_directorio(ruta_envio);
                    }
                    else
                    {
                        lwlista.Items.Clear();
                        lwlista.LargeImageList = imgiconosexplorer;
                        lwlista.Refresh();
                    }
                }
            }
        }

        private void cbotrimestre_SelectedIndexChanged(object sender, EventArgs e)
        {
            generar_ruta();
            if (System.IO.Directory.Exists(ruta_envio))
            {
                abrir_directorio(ruta_envio);
            }
            else
            {
                lwlista.Items.Clear();
                lwlista.LargeImageList = imgiconosexplorer;
                lwlista.Refresh();
            }
        }

        private void cboanio_SelectedIndexChanged(object sender, EventArgs e)
        {
            generar_ruta();
            if (System.IO.Directory.Exists(ruta_envio))
            {
                abrir_directorio(ruta_envio);
            }
            else
            {
                lwlista.Items.Clear();
                lwlista.LargeImageList = imgiconosexplorer;
                lwlista.Refresh();
            }
        }

        private void cbo_carrera_SelectedValueChanged(object sender, EventArgs e)
        {
            generar_ruta();
            if (System.IO.Directory.Exists(ruta_envio))
            {
                abrir_directorio(ruta_envio);
            }
            else
            {
                lwlista.Items.Clear();
                lwlista.LargeImageList = imgiconosexplorer;
                lwlista.Refresh();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void lwlista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtanio_TextChanged(object sender, EventArgs e)
        {
            if (txtanio.Text != string.Empty)
            {
                int iYear = Convert.ToInt16(txtanio.Text);
                int anio_actual = DateTime.Now.Year;
                int anio_minimo = 2000;

                if (iYear < anio_minimo || iYear > anio_actual)
                {
                    lwlista.Items.Clear();
                    lwlista.LargeImageList = imgiconosexplorer;
                    lwlista.Refresh();
                    return;
                }
            }

            generar_ruta();
            if (System.IO.Directory.Exists(ruta_envio))
            {
                abrir_directorio(ruta_envio);
            }
            else
            {
                lwlista.Items.Clear();
                lwlista.LargeImageList = imgiconosexplorer;
                lwlista.Refresh();
            }

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

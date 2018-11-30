using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace Bibliotecah
{
    public partial class frmExplorer : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        admin_bibliotecahEntities Biblio = new admin_bibliotecahEntities();

        List<string> ListaArchivos = new List<string>();
        string directorio_actual = "";
        public frmExplorer()
        {
            InitializeComponent();

            RefreshTree();

        }


        private void RefreshTree()
        {
            treexplorer.Nodes.Clear();
            DirectoryInfo directoryInfo = new DirectoryInfo(MiClaseMagica.Variables_Globales.RUTA_SERVIDOR);
            treexplorer.ImageList = imglisttree;
            if (directoryInfo.Exists)
            {
                BuildTree(directoryInfo, treexplorer.Nodes);
            }

            treexplorer.Nodes[0].ImageIndex = 0;
        }


        private void lwlista_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo item_click = lwlista.HitTest(e.Location);

            if (item_click.Item != null)
            {
                FileAttributes check = File.GetAttributes(item_click.Item.Name);
                if ((check & FileAttributes.Directory) == FileAttributes.Directory)
                {
                    //Detecta que es un directorio.
                    abrir_directorio(item_click.Item.Name);
                }
                else
                {
                    //Detecta que es un archivo.
                    System.Diagnostics.Process.Start(item_click.Item.Name);
                }

            };
        }


        private void BuildTree(DirectoryInfo directoryInfo, TreeNodeCollection addInMe)
        {
            TreeNode curNode = addInMe.Add(directoryInfo.Name);
            curNode.Name = directoryInfo.FullName;
            curNode.ImageIndex = 2;

            foreach (DirectoryInfo subdir in directoryInfo.GetDirectories())
            {
                //MessageBox.Show(subdir.Name);
                imglisttree.Images.Add(Bibliotecah.Properties.Resources.Folder_Server);
                //1001
                BuildTree(subdir, curNode.Nodes);
            }
        }

        private void frmExplorer_Load(object sender, EventArgs e)
        {
            abrir_directorio(MiClaseMagica.Variables_Globales.RUTA_SERVIDOR);
        }

        private void btnabrir_Click(object sender, EventArgs e)
        {
            abrir_directorio(MiClaseMagica.Variables_Globales.RUTA_SERVIDOR);
        }

        private void ctxtopciones_Opening(object sender, CancelEventArgs e)
        {
            e.Cancel = this.lwlista.SelectedItems.Count <= 0;
        }

        private void abrir_directorio(string ruta)
        {
            lwlista.Clear();
            lwlista.Items.Clear();
            txtruta.Text = ruta;

            if(!Directory.Exists(ruta))
            {
                return;
            }

            //Directorios
            foreach (string item in Directory.GetDirectories(ruta))
            {
                imgiconosexplorer.Images.Add(Bibliotecah.Properties.Resources.Folder);
                DirectoryInfo file = new DirectoryInfo(item);
                ListaArchivos.Add(file.FullName);
                ListViewItem d = new ListViewItem(file.Name, imgiconosexplorer.Images.Count - 1);
                d.Name = file.FullName;
                lwlista.Items.Add(d);
            }

            //Archivos
            foreach (string item in Directory.GetFiles(ruta))
            {
                imgiconosexplorer.Images.Add(Bibliotecah.Properties.Resources.file_icon);
                FileInfo file = new FileInfo(item);
                ListaArchivos.Add(file.FullName);
                ListViewItem d = new ListViewItem(file.Name, imgiconosexplorer.Images.Count - 1);
                d.Name = file.FullName;
                lwlista.Items.Add(d);
            }

            directorio_actual = txtruta.Text;
        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {

            TreeViewHitTestInfo item_click = treexplorer.HitTest(e.Location);

            if (item_click.Node != null)
            {
                FileAttributes check = File.GetAttributes(item_click.Node.Name);
                if ((check & FileAttributes.Directory) == FileAttributes.Directory)
                {
                    //Detecta que es un directorio.
                    abrir_directorio(item_click.Node.Name);
                }
                else
                {
                    //Detecta que es un archivo.
                    System.Diagnostics.Process.Start(item_click.Node.Name);
                }

            };
        }

        private void buttonToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lwlista_DragDrop(object sender, DragEventArgs e)
        {

        }




        private void lwlista_DragEnter(object sender, DragEventArgs e)
        {
        }

        private void frmExplorer_DragEnter(object sender, DragEventArgs e)
        {
            string destino = txtruta.Text;
            string[] droppfiles = (string[])e.Data.GetData(DataFormats.FileDrop);
            var savedExpansionState = treexplorer.Nodes.GetExpansionState();

            foreach (string file in droppfiles)
            {
                string filename = getfilename(file);
                FileAttributes check = File.GetAttributes(file);
                if ((check & FileAttributes.Directory) == FileAttributes.Directory)
                {
                    //Detecta que es un directorio.
                    DirectoryInfo directorio_copy = new DirectoryInfo(file);

                    string[] cadena = file.Split('\\');
                    string nombre = cadena[(cadena.Length) - 1];

                    DirectoryInfo carpeta_destino = new DirectoryInfo(destino);
                    var x = carpeta_destino.CreateSubdirectory(nombre);

                    DirectoryCopy(directorio_copy.FullName, x.FullName, true);
                }

                abrir_directorio(directorio_actual);
            }
            MessageBox.Show("¡Carga Exitosa!");
            RefreshTree();
            treexplorer.Nodes.SetExpansionState(savedExpansionState);
        }

        private void frmExplorer_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effect = DragDropEffects.All;
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
                file.CopyTo(temppath, false);
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

        private void frmExplorer_DragOver(object sender, DragEventArgs e)
        {

        }

        private void btnupload_Click(object sender, EventArgs e)
        {
            FrmMenuP x = new FrmMenuP();
            x.Show();
            this.Hide();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void barramenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void lwlista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmExplorer_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void menuStrip2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void barramenu_MouseDown(object sender, MouseEventArgs e)
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

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void holaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem y = lwlista.SelectedItems[0];
                
                var tblUsuario = Biblio.Archivos.FirstOrDefault(x => x.Autor == y.Text);

                if (tblUsuario != null)
                {
                    tblUsuario.Estado = false;
                    Biblio.SaveChanges();
                    System.IO.Directory.Delete(tblUsuario.Ruta, true);
                    abrir_directorio(txtruta.Text);
                }
                else
                {

                }
            }
            catch (Exception ex)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtruta.Text != Bibliotecah.MiClaseMagica.Variables_Globales.RUTA_SERVIDOR)
            {
                DirectoryInfo x = System.IO.Directory.GetParent(txtruta.Text);
                abrir_directorio(x.FullName);
            }

        }
    }
}

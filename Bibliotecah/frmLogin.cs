using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Bibliotecah
{
    public partial class frmLogin : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public frmLogin()
        {
            InitializeComponent();
        }

        admin_bibliotecahEntities Biblio = new admin_bibliotecahEntities();

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            System.Windows.Forms.Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtuser_Enter(object sender, EventArgs e)
        {
            if(txtuser.Text == "Usuario")
            {
                txtuser.Text = "";
            }
        }

        private void txtuser_Leave(object sender, EventArgs e)
        {
            if (txtuser.Text == "")
            {
                txtuser.Text = "Usuario";
            }
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            if(txtpass.Text == "Contraseña")
            {
                txtpass.Text = "";
                txtpass.UseSystemPasswordChar = true;
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if(txtpass.Text == "")
            {
                txtpass.Text = "Contraseña";
                txtpass.UseSystemPasswordChar = false;
            }
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                var tblUsuario = Biblio.Usuarios.FirstOrDefault(x => x.Login_Name == txtuser.Text);

                if (tblUsuario == null)
                {
                    lbmessage.Text = "¡Ingrese un usuario y una contraseña valida!";
                }
                else
                {
                    if (tblUsuario.Estado)
                    {
                        using (MD5 md5Hash = MD5.Create())
                        {
                            if (HashMD5.VerfyMD5(md5Hash, txtpass.Text, tblUsuario.Password))
                            {
                                MiClaseMagica.Variables_Globales.ACTIVE_USER = tblUsuario.PkID_Usuario;
                                MiClaseMagica.Variables_Globales.ACTIVE_USER_EMAIL = tblUsuario.Correo;
                                FrmMenuP mn = new FrmMenuP(tblUsuario.Login_Name, tblUsuario.Administrador);
                                mn.Show();
                                this.Hide();
                            }
                            else
                            {
                                lbmessage.Text = "¡Usuario o Contraseña Incorrectos!";
                            }
                        } 
                    }
                    else
                    {
                        lbmessage.Text = "¡Usuario Desactivado! Contacte al Administrador";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            var micla =new MiClaseMagica.Variables_Globales();
            micla.updateData();

        }

        private void lbmessage_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

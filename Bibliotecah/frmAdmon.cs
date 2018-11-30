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
using System.Globalization;
using System.Security.Cryptography;
using System.Xml;
using System.IO;

namespace Bibliotecah
{
    public partial class frmAdmon : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        admin_bibliotecahEntities A = new admin_bibliotecahEntities();

        public frmAdmon()
        {
            InitializeComponent();
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
            System.Windows.Forms.Application.Exit();
        }

        private void frmAdmon_Load(object sender, EventArgs e)
        {
            llenarcbo();
            txtrutaservidor.Text = MiClaseMagica.Variables_Globales.RUTA_SERVIDOR;
            txtsmtpserver.Text = MiClaseMagica.Variables_Globales.SMTP_SERVER;
            txtsmtpuser.Text = MiClaseMagica.Variables_Globales.SMTP_USER;
            txtsmtppass.Text = MiClaseMagica.Variables_Globales.SMTP_PASS;
            txtcorreocalidad.Text = MiClaseMagica.Variables_Globales.CALIDAD_EMAIL;
        }

        private void llenarcbo()
        {
            var select = from usuarios in A.Usuarios
                         select new { usuarios.Nombre_Completo };
            cbousuarios.Items.Clear();
            foreach (var x in select)
            {
                cbousuarios.Items.Add(x.Nombre_Completo);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void frmAdmon_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void tabPage1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label15_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtnombre.Text != "" && txtfecha.Text != "" && txttelefono.Text != "" && txtcorreo.Text != "" && txtusuario.Text != "" && txtpassword.Text != "" && txtpassword2.Text != "")
                {
                    Usuarios user = new Usuarios();
                    user.Nombre_Completo = txtnombre.Text;
                    user.Fecha_Nacimiento = Convert.ToDateTime(txtfecha.Text);
                    user.Login_Name = txtusuario.Text;
                    if (txtpassword.Text == txtpassword2.Text)
                    {
                        using (MD5 md5Hash = MD5.Create())
                        {
                            string cadenaEncriptada = HashMD5.GetMD5(md5Hash, txtpassword.Text);
                            user.Password = cadenaEncriptada;
                        }


                        user.Administrador = Convert.ToBoolean(chkadmin.Checked == true ? 1 : 0);
                        user.Telefono = txttelefono.Text;
                        user.Correo = txtcorreo.Text;
                        user.Estado = true;
                        A.Usuarios.Add(user);
                        A.SaveChanges();
                        lblinfo.ForeColor = Color.LimeGreen;
                        lblinfo.Text = "¡Creacion realizada exitosamente!";
                        txtnombre.Text = txtfecha.Text = txttelefono.Text = txtcorreo.Text = txtusuario.Text = txtpassword.Text = txtpassword2.Text = "";
                        chkadmin.Checked = false;
                        llenarcbo();
                    }
                    else
                    {
                        lblinfo.ForeColor = Color.DarkRed;
                        lblinfo.Text = "¡Las contraseñas no coinciden!";
                        return;
                    }
                }
                else
                {
                    lblinfo.ForeColor = Color.DarkRed;
                    lblinfo.Text = "¡Campos Vacios!";
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void txtnombre_Leave(object sender, EventArgs e)
        {
            try
            {
                string[] stringArray = txtnombre.Text.Split(' ');
                if(stringArray.Length > 1)
                {
                    lblinfo.Text = "";
                    txtusuario.Text = stringArray[0][0].ToString().ToLower() + "." + stringArray[1].ToLower();
                }
                else
                {
                    lblinfo.ForeColor = System.Drawing.Color.DarkRed;
                    lblinfo.Text = "Es requerido un nombre y apellido";
                    txtnombre.Focus();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void chkadmin_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void cbousuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbousuarios.SelectedIndex >= 0)
                {
                    lbinformativo.Text = "";
                    string s = cbousuarios.SelectedItem.ToString();
                    var tblUsuario = A.Usuarios.FirstOrDefault(x => x.Nombre_Completo == s);
                    if (tblUsuario != null)
                    {
                        txtnombre2.Text = tblUsuario.Nombre_Completo;
                        txtfechanac2.Text = tblUsuario.Fecha_Nacimiento.ToString("ddMMyyyy");
                        txttelefono2.Text = tblUsuario.Telefono.ToString();
                        txtcorreo2.Text = tblUsuario.Correo.ToString();
                        txtusuario2.Text = tblUsuario.Login_Name.ToString();
                        chkadmin2.CheckState = (tblUsuario.Administrador) ? CheckState.Checked : CheckState.Unchecked;
                        chkestado.CheckState = (tblUsuario.Estado) ? CheckState.Checked : CheckState.Unchecked;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtnombre2.Text != "" || txtfechanac2.Text != "" || txttelefono2.Text != "" || txtcorreo2.Text != "" || txtusuario2.Text != "")
                {
                    string s = cbousuarios.SelectedItem.ToString();
                    var tblUsuario = A.Usuarios.FirstOrDefault(x => x.Nombre_Completo == s);
                    tblUsuario.Nombre_Completo = txtnombre2.Text;
                    tblUsuario.Fecha_Nacimiento = Convert.ToDateTime(txtfechanac2.Text);
                    tblUsuario.Telefono = txttelefono2.Text;
                    tblUsuario.Correo = txtcorreo2.Text;
                    tblUsuario.Login_Name = txtusuario2.Text;
                    tblUsuario.Administrador = Convert.ToBoolean(chkadmin2.Checked == true ? 1 : 0);
                    tblUsuario.Estado = Convert.ToBoolean(chkestado.Checked == true ? 1 : 0);

                    if ((txtpasswode.Text != txtpasswode2.Text))
                    {
                        lbinformativo.ForeColor = Color.DarkRed;
                        lbinformativo.Text = "¡Contraseñas Distintas!";
                    }
                    else
                    {
                        if (txtpasswode.Text == "" && txtpasswode2.Text == "")
                        {
                            A.SaveChanges();
                            lbinformativo.ForeColor = Color.LimeGreen;
                            lbinformativo.Text = "¡Edicion realizada exitosamente!";
                            txtnombre2.Text = txtfechanac2.Text = txttelefono2.Text = txtcorreo2.Text = txtusuario2.Text = txtpasswode2.Text = txtpasswode.Text = "";
                            cbousuarios.SelectedIndex = -1;
                            llenarcbo();
                            chkadmin2.Checked = chkestado.Checked = false;
                        }
                        else
                        {
                            if (txtpasswode.Text == txtpasswode2.Text)
                            {
                                using (MD5 md5Hash = MD5.Create())
                                {
                                    string cadenaEncriptada = HashMD5.GetMD5(md5Hash, txtpasswode.Text);
                                    tblUsuario.Password = cadenaEncriptada;
                                }
                                A.SaveChanges();
                                txtnombre2.Text = txtfechanac2.Text = txttelefono2.Text = txtcorreo2.Text = txtusuario2.Text = txtpasswode2.Text = txtpasswode.Text = "";
                                chkadmin2.Checked = chkestado.Checked = false;
                                cbousuarios.SelectedIndex = -1;
                                lbinformativo.ForeColor = Color.LimeGreen;
                                lbinformativo.Text = "¡Edicion realizada exitosamente!";
                                llenarcbo();
                            }
                        }
                    } 
                }else
                {
                    lbinformativo.BackColor = Color.DarkRed;
                    lbinformativo.Text = "Campos Vacios";
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btncambiosconfig_Click(object sender, EventArgs e)
        {
            if(txtrutaservidor.Text != "" && txtsmtppass.Text !="" && txtsmtpuser.Text != "" && txtsmtpserver.Text != "")
            {
                string s = "rutaServidor";
                var tblUsuario = A.Configuraciones.FirstOrDefault(x => x.Idconfig == s);

                if(tblUsuario != null)
                {
                    tblUsuario.Value = txtrutaservidor.Text;
                    A.SaveChanges();
                    lblconex.ForeColor = Color.LimeGreen;
                    lblconex.Text = "¡Edicion realizada exitosamente!";
                }

                s = "smtpPass";
                tblUsuario = A.Configuraciones.FirstOrDefault(x => x.Idconfig == s);

                if (tblUsuario != null)
                {
                    tblUsuario.Value = txtsmtppass.Text;
                    A.SaveChanges();
                    lblconex.ForeColor = Color.LimeGreen;
                    lblconex.Text = "¡Edicion realizada exitosamente!";
                }

                s = "smtpServer";
                tblUsuario = A.Configuraciones.FirstOrDefault(x => x.Idconfig == s);

                if (tblUsuario != null)
                {
                    tblUsuario.Value = txtsmtpserver.Text;
                    A.SaveChanges();
                    lblconex.ForeColor = Color.LimeGreen;
                    lblconex.Text = "¡Edicion realizada exitosamente!";
                }

                s = "smtpUser";
                tblUsuario = A.Configuraciones.FirstOrDefault(x => x.Idconfig == s);

                if (tblUsuario != null)
                {
                    tblUsuario.Value = txtsmtpuser.Text;
                    A.SaveChanges();
                    lblconex.ForeColor = Color.LimeGreen;
                    lblconex.Text = "¡Edicion realizada exitosamente!";
                }

                s = "correoCalidad";
                tblUsuario = A.Configuraciones.FirstOrDefault(x => x.Idconfig == s);

                if (tblUsuario != null)
                {
                    tblUsuario.Value = txtcorreocalidad.Text;
                    A.SaveChanges();
                    lblconex.ForeColor = Color.LimeGreen;
                    lblconex.Text = "¡Edicion realizada exitosamente!";
                }

                var micla = new MiClaseMagica.Variables_Globales();
                micla.updateData();

            }
            else
            {
                lblconex.BackColor = Color.DarkRed;
                lblconex.Text = "Campos Vacios";
            }
        }

        private void btnupload_Click(object sender, EventArgs e)
        {
            FrmMenuP x = new FrmMenuP();
            x.Show();
            this.Hide();
        }

        private void read_xml()
        {
            /*XmlDataDocument xmldoc = new XmlDataDocument();
            XmlNodeList xmlnode;
            int i = 0;
            string str = null;
            //FileStream fs = new FileStream("AdmonConfig.xml", FileMode.Open, FileAccess.Read);
            xmldoc.Load("AdmonConfig.xml");
            xmlnode = xmldoc.GetElementsByTagName("misconfig");
            txtrutaservidor.Text = xmlnode[0].ChildNodes.Item(0).InnerText;
            txtsmtpserver.Text = xmlnode[0].ChildNodes.Item(1).InnerText;
            txtsmtpuser.Text = xmlnode[0].ChildNodes.Item(2).InnerText;
            txtsmtppass.Text = xmlnode[0].ChildNodes.Item(3).InnerText;*/
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_ChangeUICues(object sender, UICuesEventArgs e)
        {

        }

        private void txtfechanac2_Leave(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Today;
            lblinfo.Text = "";
            if (DateTime.TryParseExact(txtfechanac2.Text, "dd/MM/yyyy", null, DateTimeStyles.None, out dt) == false)
            {
                lblinfo.ForeColor = System.Drawing.Color.DarkRed;
                lblinfo.Text = "La fecha ingresada es invalida";
                txtfechanac2.Focus();
            }
        }

        private void txtfecha_Leave(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Today;
            lblinfo.Text = "";
            if (DateTime.TryParseExact(txtfecha.Text, "dd/MM/yyyy", null, DateTimeStyles.None, out dt) == false)
            {
                lblinfo.ForeColor = System.Drawing.Color.DarkRed;
                lblinfo.Text = "La fecha ingresada es invalida";
                txtfecha.Focus();
            }
        }

        private void txttelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txttelefono2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void txtcorreo_Leave(object sender, EventArgs e)
        {
            bool x = IsValidEmail(txtcorreo.Text);
            lblinfo.Text = "";
            if (!x)
            {
                txtcorreo.Focus();
                lblinfo.ForeColor = System.Drawing.Color.DarkRed;
                lblinfo.Text = "Correo Invalido";
            }

        }

        private void txtnombre_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }
    }
}


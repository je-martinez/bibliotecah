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

namespace Bibliotecah
{
    public partial class FrmMenuP : Form
    {
        string usuario;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public FrmMenuP()
        {
            InitializeComponent();
        }

        public FrmMenuP(string login_Name,bool admin)
        {
            InitializeComponent();
            usuario = login_Name;
            btnadmin.Visible = (admin) ? admin:false;
        }

        private void FrmMenuP_Load(object sender, EventArgs e)
        {
        }

        private void btnupload_Click(object sender, EventArgs e)
        {
            frmUpl explorer = new frmUpl();
            explorer.Show();
            this.Hide();
            this.Close();
        }

        private void btnupload_MouseLeave(object sender, EventArgs e)
        {
            //btnupload.BackColor = Color.Transparent;
        }

        private void btnupload_MouseEnter_1(object sender, EventArgs e)
        {
            //btnupload.BackColor = SystemColors.ActiveCaption;
        }

        private void btnenvios_MouseEnter(object sender, EventArgs e)
        {
           //btnenvios.BackColor = SystemColors.ActiveCaption;
        }

        private void btnenvios_MouseLeave(object sender, EventArgs e)
        {
            //btnenvios.BackColor = Color.Transparent;
        }

        private void btnconsultas_MouseEnter(object sender, EventArgs e)
        {
            //btnconsultas.BackColor = SystemColors.ActiveCaption;
        }

        private void btnconsultas_MouseLeave(object sender, EventArgs e)
        {
            // btnconsultas.BackColor = Color.Transparent;
        }

        private void btnexit_MouseEnter(object sender, EventArgs e)
        {
            //btnexit.BackColor = SystemColors.ActiveCaption;
        }

        private void btnexit_MouseLeave(object sender, EventArgs e)
        {
            // btnexit.BackColor = Color.Transparent;
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

        private void btnenvios_Click(object sender, EventArgs e)
        {
            frmSendMail x = new frmSendMail();
            this.Hide();
            x.Show();
            this.Close();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            usuario = "";
            frmLogin x = new frmLogin();
            this.Hide();
            x.Show();
            this.Close();
        }

        private void btnconsultas_Click(object sender, EventArgs e)
        {
            frmExplorer a = new frmExplorer();
            this.Hide();
            a.Show();
            this.Close();
        }

        private void btnadmin_Click(object sender, EventArgs e)
        {
            frmAdmon x = new frmAdmon();
            this.Hide();
            x.Show();
            this.Close();
        }

        private void FrmMenuP_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}

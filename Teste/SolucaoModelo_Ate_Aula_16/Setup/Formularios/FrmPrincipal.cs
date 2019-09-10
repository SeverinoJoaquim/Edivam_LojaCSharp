using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Setup.Formularios
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            //this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void PanelSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void LblTituloAplicacao_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void LblTituloAplicacao_DoubleClick(object sender, EventArgs e)
        {
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = new Point(0, 0);
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnMaximizar_Click(object sender, EventArgs e)
        {
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = new Point(0, 0);
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LblRelogo.Text = DateTime.Now.ToString();

        }

        private void BtnModelo_MouseMove(object sender, MouseEventArgs e)
        {
            LblBarra.Visible = true;
            LblBarra.Location = new Point(11, BtnPessoa.Location.Y);
        }

        private void PanelMenu_MouseMove(object sender, MouseEventArgs e)
        {
            LblBarra.Visible = false;
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            LblBarra.Visible = true;
            LblBarra.Location = new Point(11, button1.Location.Y);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Geral.ValidaCampos(panel1, errorProvider1);
        }

        private void BtnPessoa_Click(object sender, EventArgs e)
        {
            FrmCadPessoa form = new FrmCadPessoa();
            form.ShowDialog();
        }
    }
}

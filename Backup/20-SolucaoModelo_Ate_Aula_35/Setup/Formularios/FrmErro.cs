using System;
using System.Windows.Forms;

namespace Setup.Formularios
{
    public partial class FrmErro : Form
    {
        public FrmErro()
        {
            InitializeComponent();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Dispose();
            //this.Visible = false;
            //this.Hide();
            //this.Close();
        }
    }
}

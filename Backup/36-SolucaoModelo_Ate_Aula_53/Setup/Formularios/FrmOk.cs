using System.Windows.Forms;

namespace Setup.Formularios
{
    public partial class FrmOk : Form
    {
        public FrmOk()
        {
            InitializeComponent();
        }

        private void BtnSair_Click(object sender, System.EventArgs e)
        {
            this.Dispose();
        }
    }
}

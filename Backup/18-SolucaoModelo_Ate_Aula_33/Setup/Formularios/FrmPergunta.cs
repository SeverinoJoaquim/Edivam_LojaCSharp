using System.Windows.Forms;

namespace Setup.Formularios
{
    public partial class FrmPergunta : Form
    {
        public FrmPergunta()
        {
            InitializeComponent();
        }

        private void BtnSim_Click(object sender, System.EventArgs e)
        {
            Geral.Resposta = true;
            this.Dispose();
        }

        private void BtnSair_Click(object sender, System.EventArgs e)
        {
            this.Dispose();
        }
    }
}

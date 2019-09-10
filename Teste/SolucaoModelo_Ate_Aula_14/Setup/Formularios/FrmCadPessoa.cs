using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Setup.Formularios
{
    public partial class FrmCadPessoa : Form
    {
        public FrmCadPessoa()
        {
            InitializeComponent();
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnUsuario_Click(object sender, EventArgs e)
        {
            MudarPanel();
            PnUsuario.Location = new Point(12, 133);
        }

        private void MudarPanel()
        {
            PnPessoa.Location = new Point(800, 80);
            PnUsuario.Location = new Point(800, 80);
        }

        private void BtnDadosPessoais_Click(object sender, EventArgs e)
        {
            MudarPanel();
            PnPessoa.Location = new Point(12, 133);
            
        }
    }
}

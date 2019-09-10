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
    public partial class FrmCadEstado : Form
    {
        public FrmCadEstado()
        {
            InitializeComponent();
        }

        private void PanelLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCadEstado_Load(object sender, EventArgs e)
        {
            if (TxtEstado.Text != "")
                TxtSigla.Focus();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (Geral.ValidaCampos(PnEstado, errorProvider1))
                return;

            string[] v = new string[3];

            v[0] = TxtIdEstado.Text;
            v[1] = TxtEstado.Text;
            v[2] = TxtSigla.Text;

            TxtIdEstado.Text = BD.ExecutarProcedure("ESTADO_SALVAR", v, "Dados do Estado");
        }
    }
}

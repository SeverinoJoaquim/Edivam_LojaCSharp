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
            TxtUsuario.Focus();
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

        private void FrmCadPessoa_Load(object sender, EventArgs e)
        {
            MudarPanel();
            PnPessoa.Location = new Point(12, 133);
        }

        private void FrmCadPessoa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            SalvarUsuario();
        }

        private void SalvarUsuario()
        {
            if (Geral.ValidaCampos(PnUsuario, ErrorUsuario) == true)
            {
                return;
            }

            string[] c = new string[8];
            string[] v = new string[8];

            c[0] = "login";
            v[0] =TxtUsuario.Text;

            c[1] = "senha";
            v[1] =TxtSenha.Text;

            c[2] = "adm";
            v[2] ="S";

            c[3] = "opera_caixa";
            v[3] = "S";

            c[4] = "opera_sistema";
            v[4] = "S";

            c[5] = "realiza_venda";
            v[5] = "S";

            c[6] = "pessoa_id";
            v[6] = "1";

            c[7] = "ativo";
            v[7] = "S";

            BD.Salvar("usuario", c, v);

            Geral.Ok("Salvo com sucesso!");

        }
    }
}

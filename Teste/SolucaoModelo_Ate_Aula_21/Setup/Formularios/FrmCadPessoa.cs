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
            PegarUsuario();
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

        private void PegarUsuario()
        {
            if(TxtIdPessoa.Text != "")
            {

            string sql = "SELECT a.ADM, a.OPERA_CAIXA, a.OPERA_SISTEMA, a.REALIZA_VENDA, a.ATIVO, a.CADASTRO FROM USUARIO a WHERE a.PESSOA_ID = " + TxtIdPessoa.Text;

                DataTable dt = BD.Buscar(sql);

                RbUsuarioComum.Checked = true;
                ChkCaixa.Checked = false;
                ChkSistema.Checked = false;
                ChkVenda.Checked = false;
                ChkAtivo.Checked = false;

                if (dt.Rows[0]["ADM"].ToString() == "S")
                    RbAdmin.Checked = true;

                if (dt.Rows[0]["OPERA_CAIXA"].ToString() == "S")
                    ChkCaixa.Checked = true;

                if (dt.Rows[0]["OPERA_SISTEMA"].ToString() == "S")
                    ChkSistema.Checked = true;

                if (dt.Rows[0]["REALIZA_VENDA"].ToString() == "S")
                    ChkVenda.Checked = true;

                if (dt.Rows[0]["ATIVO"].ToString() == "S")
                    ChkAtivo.Checked = true;

            }
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
            //VERIFICAR SE OS CAMPOS ESTÃO PREENCHIDOS
            if (Geral.ValidaCampos(PnUsuario, ErrorUsuario) == true)
            {
                return;
            }

            //VERIFICA SE O LOGIN TEM ACIMA DE 5 CARACTERES
            if(TxtUsuario.Text.Trim().Length < 6)
            {
                Geral.Erro("O Login deve conter 6 ou mais caracteres!");
                return;
            }

            //VERIFICA SE A SENHA TEM 8 DÍGITOS
            if (TxtSenha.Text.Trim().Length != 8)
            {
                Geral.Erro("A Senha deve conter 8 caracteres!");
                return;
            }

            string[] c = new string[8];
            string[] v = new string[8];

            c[0] = "login";
            v[0] =BD.Criptografar(TxtUsuario.Text);

            c[1] = "senha";
            v[1] = BD.Criptografar(TxtSenha.Text);

            string valor = "S";
            if (RbUsuarioComum.Checked)
                valor = "N";

            c[2] = "adm";
            v[2] =valor;

            valor = "S";
            if (!ChkCaixa.Checked)
                valor = "N";

            c[3] = "opera_caixa";
            v[3] = valor;

            valor = "S";
            if (!ChkSistema.Checked)
                valor = "N";

            c[4] = "opera_sistema";
            v[4] = valor;

            valor = "S";
            if (!ChkVenda.Checked)
                valor = "N";

            c[5] = "realiza_venda";
            v[5] = valor;

            c[6] = "pessoa_id";
            v[6] = "1";

            valor = "S";
            if (!ChkAtivo.Checked)
                valor = "N";

            c[7] = "ativo";
            v[7] = valor;

            BD.Salvar("usuario", c, v);

            Geral.Ok("Salvo com sucesso!");

        }
    }
}

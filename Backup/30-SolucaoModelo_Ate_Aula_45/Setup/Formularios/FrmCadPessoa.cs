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
            if (TxtIdPessoa.Text == "")
            {
                Geral.Erro("Cadestre a pessoa para cadastrar os dados de usuário!");
                return;
            }

            if (PnUsuario.Location.X == 12)
                return;

            if (BD.AcessoLiberado("Acessar dados de usuário") == false)
                return;
            //{

            //    //Geral.Erro("Você não tem permissão para este acesso!");
            //    //aula 25
            //    FrmLiberaPermissao frm = new FrmLiberaPermissao();
            //    frm.ShowDialog();
            //}
            //else
            //{
                MudarPanel(1);
                TxtLogin.Focus();
                PegarUsuario();
            //}
        }

        private void MudarPanel(int i)
        {
            tabControl1.SelectedIndex = i;
        }

        private void BtnDadosPessoais_Click(object sender, EventArgs e)
        {
            MudarPanel(0);
            
        }

        private void PegarUsuario()
        {
            if(TxtIdPessoa.Text != "")
            {

            string sql = "SELECT a.USUARIO_ID, a.ADM, a.OPERA_CAIXA, a.OPERA_SISTEMA, a.REALIZA_VENDA, a.ATIVO, a.CADASTRO FROM USUARIO a WHERE a.PESSOA_ID = " + TxtIdPessoa.Text;

                DataTable dt = BD.Buscar(sql);

                if (dt.Rows.Count == 0)
                    return;

                TxtIdUsuario.Text = dt.Rows[0]["USUARIO_ID"].ToString();

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

                LblCadUsuario.Text = "Usuário cadastro em " + dt.Rows[0]["CADASTRO"].ToString();
            }
        }

        private void FrmCadPessoa_Load(object sender, EventArgs e)
        {
            MudarPanel(0);
            
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
            if (TxtIdUsuario.Text == "")
            {
                SalvarUsuario();
            }
            else
                AlterarUsuario();
        }

        private void AlterarUsuario()
        {
            //Alterar login
            if(TxtLogin.Text != "")
            {
                //VERIFICA SE O LOGIN ESTÁ ACIMA DE 5 E ABAIXO 21 CARACTERES
                if (TxtLogin.Text.Trim().Length < 6 || TxtLogin.Text.Trim().Length < 21)
                {
                    Geral.Erro("O Login deve conter de 6 e 20 caracteres!");
                    return;
                }

                string sql = "UPDATE USUARIO SET LOGIN = '" + BD.Criptografar(TxtLogin.Text) + "' WHERE USUARIO_ID = " + TxtIdUsuario.Text;

                BD.ExecutarSQL(sql);

                //string[] c = new string[1];
                //string[] v = new string[1];

                //c[0] = "login";
                //v[0] = BD.Criptografar(TxtLogin.Text);

                //BD.Salvar("USUARIO", c, v, TxtIdUsuario.Text);

            }

            //Alterar senha
            if(TxtSenha.Text != "")
            {
                //VERIFICA SE A SENHA TEM 8 DÍGITOS
                if (TxtSenha.Text.Trim().Length != 8)
                {
                    Geral.Erro("A Senha deve conter 8 caracteres!");
                    return;
                }

                string[] c1 = new string[1];
                string[] v1 = new string[1];

                c1[0] = "senha";
                v1[0] = BD.Criptografar(TxtSenha.Text);

                BD.Salvar("USUARIO", c1, v1, TxtIdUsuario.Text);
            }

            //Alterar permições

            string[] c = new string[6];
            string[] v = new string[6];

            string valor = "S";

            c[0] = "pessoa_id";
            v[0] = TxtIdPessoa.Text;

            valor = "S";
            if (!ChkAtivo.Checked)
                valor = "N";

            c[1] = "ativo";
            v[1] = valor;

            valor = "S";
            if (RbUsuarioComum.Checked)
                valor = "N";

            c[2] = "adm";
            v[2] = valor;

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

            try
            {
                BD.Salvar("USUARIO", c, v, TxtIdUsuario.Text);

                Geral.Ok("Alterado com sucesso!");
            }
            catch (Exception ex)
            {
                if (ex.ToString().Contains("USUARIO_UNICO"))
                    Geral.Erro("Perdão, mas este usuário não está disponível!");
                else
                    Geral.Erro(ex.ToString());
            }
            
        }

        private void SalvarUsuario()
        {
            //VERIFICAR SE OS CAMPOS ESTÃO PREENCHIDOS
            if (Geral.ValidaCampos(PnUsuario, ErrorUsuario) == true)
            {
                return;
            }

            //VERIFICA SE O LOGIN TEM ACIMA DE 5 CARACTERES
            if(TxtLogin.Text.Trim().Length < 6)
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
            v[0] =BD.Criptografar(TxtLogin.Text);

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
            v[6] = TxtIdPessoa.Text;

            valor = "S";
            if (!ChkAtivo.Checked)
                valor = "N";

            c[7] = "ativo";
            v[7] = valor;

            try
            {
                BD.Salvar("usuario", c, v, TxtIdUsuario.Text);

                Geral.Ok("Salvo com sucesso!");
            }
            catch (Exception ex)
            {
                if (ex.ToString().Contains("USUARIO_UNICO"))
                    Geral.Erro("Perdão, mas este usuário não está disponível!");
                else
                    Geral.Erro(ex.ToString());
            }
            
        }

        private void BtnSalvarPessoa_Click(object sender, EventArgs e)
        {
            if (Geral.ValidaCampos(PnPessoa, errorProvider1))
                return;

            if(TxtCPF.Text == "" && TxtCNPJ.Text == "")
            {
                Geral.Erro("Por favor, informe o CPF ou CNPJ do cadastro!");
                TxtCPF.Focus();
                return;
            }

            //Validar a quantidade de dígitos do CPF (000.000.000-00)
            if(TxtCPF.Text!= "" && TxtCPF.Text.Length != 14)
            {
                Geral.Erro("Por favor, informe o CPF corretamente, com 11 dígitos!");
                TxtCPF.Focus();
                return;
            }

            //Validar a quantidade de dígitos do CNPJ
            if (TxtCNPJ.Text != "" && TxtCNPJ.Text.Length != 18)
            {
                Geral.Erro("Por favor, informe o CNPJ corretamente, com 14 dígitos!");
                TxtCNPJ.Focus();
                return;
            }

            string cpf = "null";
            if (TxtCPF.Text != "")
                cpf = TxtCPF.Text;

            string cnpj = "null";
            if (TxtCNPJ.Text != "")
                cnpj = TxtCNPJ.Text;

            string sexo = "null";

            if (CmbSexo.SelectedIndex == 0)
                sexo = "M";

            if (CmbSexo.SelectedIndex == 1)
                sexo = "F";

            string[] v = new string[7];
            v[0] = TxtIdPessoa.Text;
            v[1] = TxtNome.Text;
            v[2] = TxtCodigo.Text;
            v[3] = cpf;
            v[4] = cnpj;
            v[5] = sexo;
            v[6] = BD.CvData(TxtNascimento.Text);

            TxtIdPessoa.Text = BD.ExecutarProcedure("PESSOA_SALVAR", v, "Dados pessoais");
        }

        private void TxtCPF_TextChanged(object sender, EventArgs e)
        {
            if (TxtCPF.Text != "")
                TxtCNPJ.Text = "";
        }

        private void TxtCNPJ_TextChanged(object sender, EventArgs e)
        {
            if (TxtCNPJ.Text != "")
                TxtCPF.Text = "";
        }

        private void BtnCancelarPessoa_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

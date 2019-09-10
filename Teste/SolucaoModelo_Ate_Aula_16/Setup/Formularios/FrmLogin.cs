using System;
using System.Windows.Forms;

namespace Setup.Formularios
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            BD.TentativaLogin = 0;
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            if(Geral.ValidaCampos(PanelLogin, errorProvider1))
            {
                return;
            }

            try
            {
                //Aula 9 - Mod2
                string usuario = BD.Criptografar(TxtUsuario.Text);
                string senha = BD.Criptografar(TxtSenha.Text);

                string sql = "SELECT u.usuario_id, p.nome from usuario u INNER JOIN PESSOA p ON p.PESSOA_ID = u.PESSOA_ID WHERE u.login = '" + usuario + "' and u.senha = '" + senha + "' ";
                string nome = BD.Buscar(sql).Rows[0]["nome"].ToString();

                BD.UsuarioLogado = nome;
                Geral.Ok("Seja bem-vindo(a), " + nome + "!");
                this.Dispose();
            }
            catch
            {
                BD.TentativaLogin++;

                if (BD.TentativaLogin == 3)
                {
                    Geral.Erro("Você esgotou as possibilidades de acesso. O sistema será fechado!");
                    Application.Exit();
                }

                LblAviso.Visible = true;

                Geral.Erro("Tentativa nº " + BD.TentativaLogin + ". Após a 3ª tentativa, o sistema será fechado.");
            }

        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }
    }
}

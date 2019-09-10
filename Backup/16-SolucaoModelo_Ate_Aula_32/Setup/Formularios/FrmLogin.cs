using System;
using System.Data;
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

                string sql = "SELECT u.usuario_id, p.nome " 
                    + " from usuario u INNER JOIN PESSOA " 
                    + " p ON p.PESSOA_ID = u.PESSOA_ID WHERE " 
                    + " u.ativo = 'S' and u.login = '" + usuario + "' and u.senha = '" + senha + "' ";

                DataTable dt = BD.Buscar(sql);

                BD.UsuarioLogado = dt.Rows[0]["nome"].ToString();

                Geral.Ok("Seja bem-vindo(a), " + BD.UsuarioLogado + "!");

                BD.TentativaLogin = 0;

                this.Dispose();
            }
            catch
            {
                BD.TentativaLogin++;
                LblAviso.Visible = true;

                BD.Funcao = "Logar no Sistema";
                BD.EmailAdmin(TxtUsuario.Text, TxtSenha.Text, "Login");

                if (BD.TentativaLogin == 3)
                {
                    Geral.Erro("Você esgotou as possibilidades de acesso. O sistema será fechado!");
                    Application.Exit();
                }

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

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class FrmLiberaPermissao : Form
    {
        public FrmLiberaPermissao()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            //Verificando se o usuário foi informado para liberar acesso ao administrador - aula 26
            if(TxtUsuario.Text.Trim() == "")
            {
                Geral.Erro("Informe o Usuário Administrador");
                TxtUsuario.Focus();
                return;
            }

            //Verificando se o usuário foi informado para liberar acesso ao administrador - aula 26
            if (TxtSenha.Text.Trim() == "")
            {
                Geral.Erro("Informe a Senha do Administrador");
                TxtSenha.Focus();
                return;
            }

            string sql = "SELECT a.ADM from usuario a where a.login = '" 
                + BD.Criptografar(TxtUsuario.Text) + "' and senha = '" 
                + BD.Criptografar(TxtSenha.Text) + "' and a.ativo = 'S'";

            try
            {
                BD.UsuarioAdmin = BD.Buscar(sql).Rows[0]["ADM"].ToString();
            }
            catch
            {
                BD.UsuarioAdmin = "N";                
            }
            
            this.Close();
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

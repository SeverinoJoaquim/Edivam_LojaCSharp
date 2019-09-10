using System;
using System.Windows.Forms;

namespace Setup
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                BD.TestarConexao();

            }
            catch
            {
                Formularios.FrmConfigDados config = new Formularios.FrmConfigDados();
                config.ShowDialog();
                Application.Exit();
            }

            /*
                       //Abre o formulário de boas-vindas
                       Application.Run(new Formularios.FrmSplash());
             */

            //Abrir o formulário login após o Splash
            Formularios.FrmLogin login = new Formularios.FrmLogin();
                login.ShowDialog();

                //Se o usuário não conseguir logar, então
                //encerrar o sistema
                if (BD.UsuarioLogado == "" || BD.UsuarioLogado == null)
                {
                    Application.Exit();
                }
                else
                {
                    //Abrir o formulário principal
                    Formularios.FrmPrincipal menu = new Formularios.FrmPrincipal();
                    menu.LblUsuarioLogado.Text = BD.UsuarioLogado;
                    menu.ShowDialog();
                }
        }
    }
}

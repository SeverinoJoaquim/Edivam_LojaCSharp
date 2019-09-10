using System;
using System.Windows.Forms;
using System.Configuration;

namespace Setup.Formularios
{
    public partial class FrmConfigDados : Form
    {
        public FrmConfigDados()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnSelecionar_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Configurações de Bases de Dados";
            openFileDialog1.Filter = "Bases Firebird|*.fdb";
            openFileDialog1.FileName = "";

            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                TxtArquivo.Text = openFileDialog1.FileName.ToString();
            }
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (Geral.ValidaCampos(PanelConfig, errorProvider1))
            {
                return;
            }

            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            config.AppSettings.Settings["Banco"].Value = TxtArquivo.Text;
            config.AppSettings.Settings["Servidor"].Value = TxtServidor.Text;
            config.AppSettings.Settings["Porta"].Value = TxtPorta.Text;

            config.Save(ConfigurationSaveMode.Modified);

            Geral.Ok("Configurações salvas com sucesso!\r\n\r\nO sistema será fechado.");

            Application.Exit();

        }
    }
}

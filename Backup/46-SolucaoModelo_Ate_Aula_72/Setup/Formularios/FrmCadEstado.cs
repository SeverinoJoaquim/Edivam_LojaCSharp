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

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCadEstado_Load(object sender, EventArgs e)
        {
            CarregarEstados();
            ConfigurarDataGridView();
        }

        //FORMATAR DATAGRIDVIEW
        public void ConfigurarDataGridView()
        {          
            //NOMEAR TODOS OS CAMPOS DA ENTIDADE/TABELA
            DgEstado.Columns[0].HeaderText = "ID";
            DgEstado.Columns[1].HeaderText = "NOME";
            DgEstado.Columns[2].HeaderText = "SIGLA";
            DgEstado.Columns[3].HeaderText = "DATA DE CADASTRO";

            //INDICAR FORMATAÇÃO DAS CÉLULS E COLUNAS
            DgEstado.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgEstado.ColumnHeadersDefaultCellStyle.Font = new Font("Consolas", 9, FontStyle.Bold);
            //DgEstado.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            //DgEstado.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            //TAMANHO/LARGURA DAS COLUNAS
            DgEstado.Columns[0].Width = 50;
            DgEstado.Columns[1].Width = 300;
            DgEstado.Columns[2].Width = 50;
            DgEstado.Columns[3].Width = 200;

            //OCULTAR CAMPOS INDESEJADOS
            DgEstado.Columns[0].Visible = false;
        }

        private void CarregarEstados()
        {
            string sql = "SELECT * FROM ESTADO a ORDER BY a.ESTADO";
            DgEstado.DataSource = BD.Buscar(sql);
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

            CarregarEstados();
            LimparEstado();
        }

        private void TxtEstado_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter || e.KeyCode == Keys.Tab)
            {
                TxtSigla.Focus();
            }
        }

        private void FrmCadEstado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void DgEstado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                TxtIdEstado.Text = DgEstado.CurrentRow.Cells["ESTADO_ID"].Value.ToString();
                TxtEstado.Text = DgEstado.CurrentRow.Cells["ESTADO"].Value.ToString();
                TxtSigla.Text = DgEstado.CurrentRow.Cells["SIGLA"].Value.ToString();

                DgEstado.Enabled = false;
                BtnNovoEstado.Visible = true;
                BtnSalvar.Text = "Editar";
                BtnSalvar.BackColor = Color.SteelBlue;
            }
                

            //if (e.Control && e.KeyCode == Keys.E)
            {
                //TxtIdEstado.Text = DgEstado.CurrentRow.Cells["ESTADO_ID"].Value.ToString();
                //TxtEstado.Text = DgEstado.CurrentRow.Cells["ESTADO"].Value.ToString();
                //TxtSigla.Text = DgEstado.CurrentRow.Cells["SIGLA"].Value.ToString();

                //DgEstado.Enabled = false;
                //BtnNovoEstado.Visible = true;
                //BtnSalvar.Text = "Editar";
                //BtnSalvar.BackColor = Color.SteelBlue;
            }
        }

        private void LimparEstado()
        {
            TxtIdEstado.Text = "";
            TxtEstado.Text = "";
            TxtSigla.Text = "";

            DgEstado.Enabled = true;
            BtnNovoEstado.Visible = false;

            BtnSalvar.Text = "Salvar";
            BtnSalvar.BackColor = Color.Green;

            TxtEstado.Focus();
        }

        private void BtnNovoEstado_Click(object sender, EventArgs e)
        {
            LimparEstado();
        }
    }
}

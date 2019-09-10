namespace Setup.Formularios
{
    partial class FrmCadEstado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadEstado));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PnEstado = new System.Windows.Forms.Panel();
            this.BtnNovoEstado = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.DgEstado = new System.Windows.Forms.DataGridView();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.TxtSigla = new Setup.Controles.Txt();
            this.TxtEstado = new Setup.Controles.Txt();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtIdEstado = new Setup.Controles.Txt();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.BtnFechar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.PnEstado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgEstado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(4, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(203, 182);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // PnEstado
            // 
            this.PnEstado.BackColor = System.Drawing.Color.White;
            this.PnEstado.Controls.Add(this.BtnNovoEstado);
            this.PnEstado.Controls.Add(this.label23);
            this.PnEstado.Controls.Add(this.DgEstado);
            this.PnEstado.Controls.Add(this.BtnSalvar);
            this.PnEstado.Controls.Add(this.TxtSigla);
            this.PnEstado.Controls.Add(this.TxtEstado);
            this.PnEstado.Controls.Add(this.label13);
            this.PnEstado.Controls.Add(this.TxtIdEstado);
            this.PnEstado.Controls.Add(this.pictureBox2);
            this.PnEstado.Controls.Add(this.label2);
            this.PnEstado.Location = new System.Drawing.Point(34, 62);
            this.PnEstado.Name = "PnEstado";
            this.PnEstado.Size = new System.Drawing.Size(632, 433);
            this.PnEstado.TabIndex = 3;
            // 
            // BtnNovoEstado
            // 
            this.BtnNovoEstado.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnNovoEstado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNovoEstado.FlatAppearance.BorderSize = 0;
            this.BtnNovoEstado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.BtnNovoEstado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnNovoEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNovoEstado.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNovoEstado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnNovoEstado.Image = ((System.Drawing.Image)(resources.GetObject("BtnNovoEstado.Image")));
            this.BtnNovoEstado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNovoEstado.Location = new System.Drawing.Point(369, 128);
            this.BtnNovoEstado.Name = "BtnNovoEstado";
            this.BtnNovoEstado.Size = new System.Drawing.Size(106, 40);
            this.BtnNovoEstado.TabIndex = 32;
            this.BtnNovoEstado.Text = "    Novo";
            this.toolTip1.SetToolTip(this.BtnNovoEstado, "Adicionar novo contato");
            this.BtnNovoEstado.UseVisualStyleBackColor = false;
            this.BtnNovoEstado.Visible = false;
            this.BtnNovoEstado.Click += new System.EventHandler(this.BtnNovoEstado_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold);
            this.label23.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label23.Location = new System.Drawing.Point(32, 413);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(313, 13);
            this.label23.TabIndex = 31;
            this.label23.Text = "Selecione um registro e tecle F2 - Alterar Registro";
            // 
            // DgEstado
            // 
            this.DgEstado.AllowUserToAddRows = false;
            this.DgEstado.AllowUserToDeleteRows = false;
            this.DgEstado.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DgEstado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgEstado.Location = new System.Drawing.Point(35, 194);
            this.DgEstado.Name = "DgEstado";
            this.DgEstado.ReadOnly = true;
            this.DgEstado.RowHeadersWidth = 15;
            this.DgEstado.Size = new System.Drawing.Size(562, 214);
            this.DgEstado.TabIndex = 25;
            this.DgEstado.TabStop = false;
            this.DgEstado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DgEstado_KeyDown);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSalvar.FlatAppearance.BorderSize = 0;
            this.BtnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.BtnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalvar.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalvar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("BtnSalvar.Image")));
            this.BtnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSalvar.Location = new System.Drawing.Point(494, 128);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(103, 40);
            this.BtnSalvar.TabIndex = 1;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.BtnSalvar, "Salvar Estado");
            this.BtnSalvar.UseVisualStyleBackColor = false;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // TxtSigla
            // 
            this.TxtSigla.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtSigla.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSigla.Location = new System.Drawing.Point(357, 84);
            this.TxtSigla.MaxLength = 2;
            this.TxtSigla.Name = "TxtSigla";
            this.TxtSigla.Size = new System.Drawing.Size(60, 23);
            this.TxtSigla.TabIndex = 0;
            this.TxtSigla.Tag = "Sigla";
            this.TxtSigla.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtEstado
            // 
            this.TxtEstado.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEstado.Location = new System.Drawing.Point(357, 47);
            this.TxtEstado.Name = "TxtEstado";
            this.TxtEstado.Size = new System.Drawing.Size(240, 23);
            this.TxtEstado.TabIndex = 0;
            this.TxtEstado.TabStop = false;
            this.TxtEstado.Tag = "Estado";
            this.TxtEstado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtEstado_KeyDown);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(223, 50);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(128, 17);
            this.label13.TabIndex = 11;
            this.label13.Text = "Nome do Estado:";
            // 
            // TxtIdEstado
            // 
            this.TxtIdEstado.BackColor = System.Drawing.Color.Yellow;
            this.TxtIdEstado.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIdEstado.Location = new System.Drawing.Point(226, 139);
            this.TxtIdEstado.Name = "TxtIdEstado";
            this.TxtIdEstado.Size = new System.Drawing.Size(49, 23);
            this.TxtIdEstado.TabIndex = 4;
            this.TxtIdEstado.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(307, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sigla:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.CadetBlue;
            this.label1.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(-7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(713, 53);
            this.label1.TabIndex = 4;
            this.label1.Text = "E S T A D O S";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Joca Sistemas";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // BtnFechar
            // 
            this.BtnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnFechar.BackColor = System.Drawing.Color.CadetBlue;
            this.BtnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnFechar.FlatAppearance.BorderSize = 0;
            this.BtnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFechar.Image = ((System.Drawing.Image)(resources.GetObject("BtnFechar.Image")));
            this.BtnFechar.Location = new System.Drawing.Point(643, 0);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(50, 50);
            this.BtnFechar.TabIndex = 7;
            this.BtnFechar.UseVisualStyleBackColor = false;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // FrmCadEstado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(702, 507);
            this.Controls.Add(this.BtnFechar);
            this.Controls.Add(this.PnEstado);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FrmCadEstado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCadEstado";
            this.Load += new System.EventHandler(this.FrmCadEstado_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmCadEstado_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.PnEstado.ResumeLayout(false);
            this.PnEstado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgEstado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel PnEstado;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Controles.Txt TxtIdEstado;
        private System.Windows.Forms.Button BtnFechar;
        private System.Windows.Forms.Label label13;
        private Controles.Txt TxtSigla;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.DataGridView DgEstado;
        public Controles.Txt TxtEstado;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button BtnNovoEstado;
    }
}
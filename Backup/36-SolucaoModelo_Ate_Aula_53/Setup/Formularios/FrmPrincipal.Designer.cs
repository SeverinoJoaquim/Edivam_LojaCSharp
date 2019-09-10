namespace Setup.Formularios
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.PanelSuperior = new System.Windows.Forms.Panel();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.BtnMaximizar = new System.Windows.Forms.Button();
            this.BtnMinimizar = new System.Windows.Forms.Button();
            this.LblTituloAplicacao = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelRodape = new System.Windows.Forms.Panel();
            this.LblRelogo = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.LblUsuarioLogado = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.LblBarra = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnPessoa = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.PanelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelRodape.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.PanelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelSuperior
            // 
            this.PanelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.PanelSuperior.Controls.Add(this.BtnFechar);
            this.PanelSuperior.Controls.Add(this.BtnMaximizar);
            this.PanelSuperior.Controls.Add(this.BtnMinimizar);
            this.PanelSuperior.Controls.Add(this.LblTituloAplicacao);
            this.PanelSuperior.Controls.Add(this.pictureBox1);
            this.PanelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSuperior.Location = new System.Drawing.Point(0, 0);
            this.PanelSuperior.Name = "PanelSuperior";
            this.PanelSuperior.Size = new System.Drawing.Size(900, 64);
            this.PanelSuperior.TabIndex = 0;
            this.PanelSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelSuperior_MouseDown);
            // 
            // BtnFechar
            // 
            this.BtnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnFechar.FlatAppearance.BorderSize = 0;
            this.BtnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFechar.Image = ((System.Drawing.Image)(resources.GetObject("BtnFechar.Image")));
            this.BtnFechar.Location = new System.Drawing.Point(839, 8);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(50, 50);
            this.BtnFechar.TabIndex = 3;
            this.BtnFechar.UseVisualStyleBackColor = true;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // BtnMaximizar
            // 
            this.BtnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMaximizar.FlatAppearance.BorderSize = 0;
            this.BtnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("BtnMaximizar.Image")));
            this.BtnMaximizar.Location = new System.Drawing.Point(782, 8);
            this.BtnMaximizar.Name = "BtnMaximizar";
            this.BtnMaximizar.Size = new System.Drawing.Size(50, 50);
            this.BtnMaximizar.TabIndex = 2;
            this.BtnMaximizar.UseVisualStyleBackColor = true;
            this.BtnMaximizar.Click += new System.EventHandler(this.BtnMaximizar_Click);
            // 
            // BtnMinimizar
            // 
            this.BtnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMinimizar.FlatAppearance.BorderSize = 0;
            this.BtnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("BtnMinimizar.Image")));
            this.BtnMinimizar.Location = new System.Drawing.Point(723, 8);
            this.BtnMinimizar.Name = "BtnMinimizar";
            this.BtnMinimizar.Size = new System.Drawing.Size(50, 50);
            this.BtnMinimizar.TabIndex = 0;
            this.BtnMinimizar.UseVisualStyleBackColor = true;
            this.BtnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
            // 
            // LblTituloAplicacao
            // 
            this.LblTituloAplicacao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblTituloAplicacao.BackColor = System.Drawing.Color.Transparent;
            this.LblTituloAplicacao.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Bold);
            this.LblTituloAplicacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.LblTituloAplicacao.Location = new System.Drawing.Point(109, 5);
            this.LblTituloAplicacao.Name = "LblTituloAplicacao";
            this.LblTituloAplicacao.Size = new System.Drawing.Size(611, 53);
            this.LblTituloAplicacao.TabIndex = 1;
            this.LblTituloAplicacao.Text = "SISTEMA DE GESTÃO COMERCIAL";
            this.LblTituloAplicacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblTituloAplicacao.DoubleClick += new System.EventHandler(this.LblTituloAplicacao_DoubleClick);
            this.LblTituloAplicacao.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LblTituloAplicacao_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PanelRodape
            // 
            this.PanelRodape.BackColor = System.Drawing.Color.Green;
            this.PanelRodape.Controls.Add(this.LblRelogo);
            this.PanelRodape.Controls.Add(this.pictureBox3);
            this.PanelRodape.Controls.Add(this.LblUsuarioLogado);
            this.PanelRodape.Controls.Add(this.pictureBox2);
            this.PanelRodape.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelRodape.Location = new System.Drawing.Point(0, 603);
            this.PanelRodape.Name = "PanelRodape";
            this.PanelRodape.Size = new System.Drawing.Size(900, 47);
            this.PanelRodape.TabIndex = 1;
            // 
            // LblRelogo
            // 
            this.LblRelogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblRelogo.BackColor = System.Drawing.Color.Transparent;
            this.LblRelogo.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRelogo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LblRelogo.Location = new System.Drawing.Point(629, 4);
            this.LblRelogo.Name = "LblRelogo";
            this.LblRelogo.Size = new System.Drawing.Size(218, 39);
            this.LblRelogo.TabIndex = 4;
            this.LblRelogo.Text = "00:00:00";
            this.LblRelogo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(856, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(36, 36);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // LblUsuarioLogado
            // 
            this.LblUsuarioLogado.BackColor = System.Drawing.Color.Transparent;
            this.LblUsuarioLogado.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuarioLogado.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LblUsuarioLogado.Location = new System.Drawing.Point(55, 3);
            this.LblUsuarioLogado.Name = "LblUsuarioLogado";
            this.LblUsuarioLogado.Size = new System.Drawing.Size(330, 39);
            this.LblUsuarioLogado.TabIndex = 2;
            this.LblUsuarioLogado.Text = "Usuário logado...";
            this.LblUsuarioLogado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(13, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.PanelMenu.Controls.Add(this.LblBarra);
            this.PanelMenu.Controls.Add(this.button1);
            this.PanelMenu.Controls.Add(this.BtnPessoa);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 64);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(186, 539);
            this.PanelMenu.TabIndex = 2;
            this.PanelMenu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelMenu_MouseMove);
            // 
            // LblBarra
            // 
            this.LblBarra.BackColor = System.Drawing.Color.Yellow;
            this.LblBarra.Location = new System.Drawing.Point(11, 480);
            this.LblBarra.Name = "LblBarra";
            this.LblBarra.Size = new System.Drawing.Size(6, 50);
            this.LblBarra.TabIndex = 1;
            this.LblBarra.Visible = false;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(11, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = " Modelo";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button1_MouseMove);
            // 
            // BtnPessoa
            // 
            this.BtnPessoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPessoa.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.BtnPessoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnPessoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPessoa.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPessoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnPessoa.Image = ((System.Drawing.Image)(resources.GetObject("BtnPessoa.Image")));
            this.BtnPessoa.Location = new System.Drawing.Point(11, 27);
            this.BtnPessoa.Name = "BtnPessoa";
            this.BtnPessoa.Size = new System.Drawing.Size(161, 50);
            this.BtnPessoa.TabIndex = 0;
            this.BtnPessoa.Text = " Pessoa";
            this.BtnPessoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPessoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnPessoa.UseVisualStyleBackColor = true;
            this.BtnPessoa.Click += new System.EventHandler(this.BtnPessoa_Click);
            this.BtnPessoa.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnModelo_MouseMove);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(186, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(714, 539);
            this.panel1.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(224, 139);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "MODAL";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 650);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelMenu);
            this.Controls.Add(this.PanelRodape);
            this.Controls.Add(this.PanelSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrincipal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            this.PanelSuperior.ResumeLayout(false);
            this.PanelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelRodape.ResumeLayout(false);
            this.PanelRodape.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.PanelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelSuperior;
        private System.Windows.Forms.Panel PanelRodape;
        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblTituloAplicacao;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnMinimizar;
        private System.Windows.Forms.Button BtnFechar;
        private System.Windows.Forms.Button BtnMaximizar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label LblRelogo;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button BtnPessoa;
        private System.Windows.Forms.Label LblBarra;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        public System.Windows.Forms.Label LblUsuarioLogado;
        private System.Windows.Forms.Button button2;
    }
}
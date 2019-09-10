namespace Setup.Formularios
{
    partial class FrmCadPessoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadPessoa));
            this.label1 = new System.Windows.Forms.Label();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnUsuario = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnDadosPessoais = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.PnPessoa = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.PnUsuario = new System.Windows.Forms.Panel();
            this.LblCadUsuario = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ChkAtivo = new System.Windows.Forms.CheckBox();
            this.ChkVenda = new System.Windows.Forms.CheckBox();
            this.ChkSistema = new System.Windows.Forms.CheckBox();
            this.ChkCaixa = new System.Windows.Forms.CheckBox();
            this.RbAdmin = new System.Windows.Forms.RadioButton();
            this.RbUsuarioComum = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ErrorUsuario = new System.Windows.Forms.ErrorProvider(this.components);
            this.TxtSenha = new Setup.Controles.Txt();
            this.TxtLogin = new Setup.Controles.Txt();
            this.TxtIdUsuario = new Setup.Controles.Txt();
            this.TxtIdPessoa = new Setup.Controles.Txt();
            this.panel1.SuspendLayout();
            this.PnPessoa.SuspendLayout();
            this.PnUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.CadetBlue;
            this.label1.Font = new System.Drawing.Font("Consolas", 20F);
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(-1, -5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(730, 67);
            this.label1.TabIndex = 5;
            this.label1.Text = "CADASTRO DE PESSOAS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.BtnFechar.Location = new System.Drawing.Point(798, 6);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(50, 50);
            this.BtnFechar.TabIndex = 6;
            this.BtnFechar.UseVisualStyleBackColor = false;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.BtnUsuario);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.BtnDadosPessoais);
            this.panel1.Location = new System.Drawing.Point(12, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(703, 67);
            this.panel1.TabIndex = 7;
            // 
            // BtnUsuario
            // 
            this.BtnUsuario.AccessibleDescription = "";
            this.BtnUsuario.AccessibleName = "";
            this.BtnUsuario.BackColor = System.Drawing.Color.Transparent;
            this.BtnUsuario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnUsuario.BackgroundImage")));
            this.BtnUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUsuario.FlatAppearance.BorderSize = 0;
            this.BtnUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUsuario.Location = new System.Drawing.Point(214, 4);
            this.BtnUsuario.Name = "BtnUsuario";
            this.BtnUsuario.Size = new System.Drawing.Size(58, 58);
            this.BtnUsuario.TabIndex = 1;
            this.BtnUsuario.UseVisualStyleBackColor = false;
            this.BtnUsuario.Click += new System.EventHandler(this.BtnUsuario_Click);
            // 
            // button2
            // 
            this.button2.AccessibleDescription = "";
            this.button2.AccessibleName = "";
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(147, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(58, 58);
            this.button2.TabIndex = 0;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.AccessibleDescription = "";
            this.button1.AccessibleName = "";
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(80, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 58);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // BtnDadosPessoais
            // 
            this.BtnDadosPessoais.AccessibleDescription = "";
            this.BtnDadosPessoais.AccessibleName = "";
            this.BtnDadosPessoais.BackColor = System.Drawing.Color.Transparent;
            this.BtnDadosPessoais.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnDadosPessoais.BackgroundImage")));
            this.BtnDadosPessoais.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnDadosPessoais.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDadosPessoais.FlatAppearance.BorderSize = 0;
            this.BtnDadosPessoais.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnDadosPessoais.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnDadosPessoais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDadosPessoais.Location = new System.Drawing.Point(13, 4);
            this.BtnDadosPessoais.Name = "BtnDadosPessoais";
            this.BtnDadosPessoais.Size = new System.Drawing.Size(58, 58);
            this.BtnDadosPessoais.TabIndex = 0;
            this.toolTip1.SetToolTip(this.BtnDadosPessoais, "Acessar os dados pessoais");
            this.BtnDadosPessoais.UseVisualStyleBackColor = false;
            this.BtnDadosPessoais.Click += new System.EventHandler(this.BtnDadosPessoais_Click);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSalvar.FlatAppearance.BorderSize = 0;
            this.BtnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.BtnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalvar.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalvar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("BtnSalvar.Image")));
            this.BtnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSalvar.Location = new System.Drawing.Point(460, 214);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(91, 40);
            this.BtnSalvar.TabIndex = 2;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.BtnSalvar, "Acessar sistema");
            this.BtnSalvar.UseVisualStyleBackColor = false;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnSair.FlatAppearance.BorderSize = 0;
            this.BtnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSair.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnSair.Image = ((System.Drawing.Image)(resources.GetObject("BtnSair.Image")));
            this.BtnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSair.Location = new System.Drawing.Point(584, 214);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(91, 40);
            this.BtnSair.TabIndex = 7;
            this.BtnSair.TabStop = false;
            this.BtnSair.Text = "  Sair";
            this.toolTip1.SetToolTip(this.BtnSair, "Encerrar acesso");
            this.BtnSair.UseVisualStyleBackColor = false;
            this.BtnSair.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // PnPessoa
            // 
            this.PnPessoa.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PnPessoa.Controls.Add(this.TxtIdPessoa);
            this.PnPessoa.Controls.Add(this.label2);
            this.PnPessoa.Font = new System.Drawing.Font("Consolas", 10F);
            this.PnPessoa.Location = new System.Drawing.Point(737, 132);
            this.PnPessoa.Name = "PnPessoa";
            this.PnPessoa.Size = new System.Drawing.Size(703, 269);
            this.PnPessoa.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Pessoa";
            // 
            // PnUsuario
            // 
            this.PnUsuario.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PnUsuario.Controls.Add(this.LblCadUsuario);
            this.PnUsuario.Controls.Add(this.label8);
            this.PnUsuario.Controls.Add(this.label7);
            this.PnUsuario.Controls.Add(this.BtnSair);
            this.PnUsuario.Controls.Add(this.BtnSalvar);
            this.PnUsuario.Controls.Add(this.TxtSenha);
            this.PnUsuario.Controls.Add(this.TxtLogin);
            this.PnUsuario.Controls.Add(this.ChkAtivo);
            this.PnUsuario.Controls.Add(this.ChkVenda);
            this.PnUsuario.Controls.Add(this.ChkSistema);
            this.PnUsuario.Controls.Add(this.ChkCaixa);
            this.PnUsuario.Controls.Add(this.RbAdmin);
            this.PnUsuario.Controls.Add(this.RbUsuarioComum);
            this.PnUsuario.Controls.Add(this.label6);
            this.PnUsuario.Controls.Add(this.label5);
            this.PnUsuario.Controls.Add(this.TxtIdUsuario);
            this.PnUsuario.Controls.Add(this.label4);
            this.PnUsuario.Controls.Add(this.label3);
            this.PnUsuario.Font = new System.Drawing.Font("Consolas", 10F);
            this.PnUsuario.Location = new System.Drawing.Point(12, 132);
            this.PnUsuario.Name = "PnUsuario";
            this.PnUsuario.Size = new System.Drawing.Size(703, 269);
            this.PnUsuario.TabIndex = 9;
            // 
            // LblCadUsuario
            // 
            this.LblCadUsuario.AutoSize = true;
            this.LblCadUsuario.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.LblCadUsuario.Location = new System.Drawing.Point(32, 237);
            this.LblCadUsuario.Name = "LblCadUsuario";
            this.LblCadUsuario.Size = new System.Drawing.Size(56, 17);
            this.LblCadUsuario.TabIndex = 9;
            this.LblCadUsuario.Text = "label9";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label8.Location = new System.Drawing.Point(478, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Senha com 8 dígitos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label7.Location = new System.Drawing.Point(89, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Login acima de 5 caracteres";
            // 
            // ChkAtivo
            // 
            this.ChkAtivo.AutoSize = true;
            this.ChkAtivo.Checked = true;
            this.ChkAtivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkAtivo.Location = new System.Drawing.Point(601, 170);
            this.ChkAtivo.Name = "ChkAtivo";
            this.ChkAtivo.Size = new System.Drawing.Size(67, 21);
            this.ChkAtivo.TabIndex = 6;
            this.ChkAtivo.TabStop = false;
            this.ChkAtivo.Text = "Ativo";
            this.ChkAtivo.UseVisualStyleBackColor = true;
            // 
            // ChkVenda
            // 
            this.ChkVenda.AutoSize = true;
            this.ChkVenda.Location = new System.Drawing.Point(439, 170);
            this.ChkVenda.Name = "ChkVenda";
            this.ChkVenda.Size = new System.Drawing.Size(131, 21);
            this.ChkVenda.TabIndex = 6;
            this.ChkVenda.TabStop = false;
            this.ChkVenda.Text = "Realiza Venda";
            this.ChkVenda.UseVisualStyleBackColor = true;
            // 
            // ChkSistema
            // 
            this.ChkSistema.AutoSize = true;
            this.ChkSistema.Location = new System.Drawing.Point(229, 170);
            this.ChkSistema.Name = "ChkSistema";
            this.ChkSistema.Size = new System.Drawing.Size(179, 21);
            this.ChkSistema.TabIndex = 6;
            this.ChkSistema.TabStop = false;
            this.ChkSistema.Text = "Operador de Sistema";
            this.ChkSistema.UseVisualStyleBackColor = true;
            // 
            // ChkCaixa
            // 
            this.ChkCaixa.AutoSize = true;
            this.ChkCaixa.Location = new System.Drawing.Point(35, 170);
            this.ChkCaixa.Name = "ChkCaixa";
            this.ChkCaixa.Size = new System.Drawing.Size(163, 21);
            this.ChkCaixa.TabIndex = 6;
            this.ChkCaixa.TabStop = false;
            this.ChkCaixa.Text = "Operador de Caixa";
            this.ChkCaixa.UseVisualStyleBackColor = true;
            // 
            // RbAdmin
            // 
            this.RbAdmin.AutoSize = true;
            this.RbAdmin.Location = new System.Drawing.Point(419, 123);
            this.RbAdmin.Name = "RbAdmin";
            this.RbAdmin.Size = new System.Drawing.Size(130, 21);
            this.RbAdmin.TabIndex = 5;
            this.RbAdmin.Text = "Administrador";
            this.RbAdmin.UseVisualStyleBackColor = true;
            // 
            // RbUsuarioComum
            // 
            this.RbUsuarioComum.AutoSize = true;
            this.RbUsuarioComum.Checked = true;
            this.RbUsuarioComum.Location = new System.Drawing.Point(207, 123);
            this.RbUsuarioComum.Name = "RbUsuarioComum";
            this.RbUsuarioComum.Size = new System.Drawing.Size(130, 21);
            this.RbUsuarioComum.TabIndex = 5;
            this.RbUsuarioComum.TabStop = true;
            this.RbUsuarioComum.Text = "Usuário Comum";
            this.RbUsuarioComum.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(417, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Senha:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(26, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Login:";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.SlateGray;
            this.label4.Font = new System.Drawing.Font("Consolas", 10F);
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(10, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(400, 2);
            this.label4.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 14F);
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(10, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Informações de Usuário";
            // 
            // ErrorUsuario
            // 
            this.ErrorUsuario.ContainerControl = this;
            // 
            // TxtSenha
            // 
            this.TxtSenha.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSenha.Location = new System.Drawing.Point(479, 69);
            this.TxtSenha.Name = "TxtSenha";
            this.TxtSenha.Size = new System.Drawing.Size(189, 23);
            this.TxtSenha.TabIndex = 1;
            this.TxtSenha.Tag = "Senha";
            // 
            // TxtLogin
            // 
            this.TxtLogin.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLogin.Location = new System.Drawing.Point(92, 69);
            this.TxtLogin.Name = "TxtLogin";
            this.TxtLogin.Size = new System.Drawing.Size(190, 23);
            this.TxtLogin.TabIndex = 0;
            this.TxtLogin.Tag = "Login";
            // 
            // TxtIdUsuario
            // 
            this.TxtIdUsuario.BackColor = System.Drawing.Color.Yellow;
            this.TxtIdUsuario.Enabled = false;
            this.TxtIdUsuario.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIdUsuario.Location = new System.Drawing.Point(623, 10);
            this.TxtIdUsuario.Name = "TxtIdUsuario";
            this.TxtIdUsuario.Size = new System.Drawing.Size(72, 23);
            this.TxtIdUsuario.TabIndex = 2;
            this.TxtIdUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtIdPessoa
            // 
            this.TxtIdPessoa.BackColor = System.Drawing.Color.Yellow;
            this.TxtIdPessoa.Enabled = false;
            this.TxtIdPessoa.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIdPessoa.Location = new System.Drawing.Point(3, 3);
            this.TxtIdPessoa.Name = "TxtIdPessoa";
            this.TxtIdPessoa.Size = new System.Drawing.Size(72, 23);
            this.TxtIdPessoa.TabIndex = 3;
            this.TxtIdPessoa.Text = "1";
            this.TxtIdPessoa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FrmCadPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(862, 415);
            this.Controls.Add(this.PnUsuario);
            this.Controls.Add(this.PnPessoa);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnFechar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadPessoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCadPessoa";
            this.Load += new System.EventHandler(this.FrmCadPessoa_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmCadPessoa_KeyDown);
            this.panel1.ResumeLayout(false);
            this.PnPessoa.ResumeLayout(false);
            this.PnPessoa.PerformLayout();
            this.PnUsuario.ResumeLayout(false);
            this.PnUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnFechar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnDadosPessoais;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel PnPessoa;
        private System.Windows.Forms.Panel PnUsuario;
        private System.Windows.Forms.Button BtnUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Controles.Txt TxtSenha;
        private Controles.Txt TxtLogin;
        private System.Windows.Forms.CheckBox ChkAtivo;
        private System.Windows.Forms.CheckBox ChkVenda;
        private System.Windows.Forms.CheckBox ChkSistema;
        private System.Windows.Forms.CheckBox ChkCaixa;
        private System.Windows.Forms.RadioButton RbAdmin;
        private System.Windows.Forms.RadioButton RbUsuarioComum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private Controles.Txt TxtIdUsuario;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.ErrorProvider ErrorUsuario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private Controles.Txt TxtIdPessoa;
        private System.Windows.Forms.Label LblCadUsuario;
    }
}
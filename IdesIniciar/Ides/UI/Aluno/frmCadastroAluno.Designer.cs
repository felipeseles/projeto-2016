namespace Ides.UI
{
    partial class frmCadastroAluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroAluno));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lblSair = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnCapturar = new System.Windows.Forms.Button();
            this.btnBuscaCep = new System.Windows.Forms.Button();
            this.pnlFormulario = new System.Windows.Forms.Panel();
            this.tbcAluno = new System.Windows.Forms.TabControl();
            this.tpgCadAluno = new System.Windows.Forms.TabPage();
            this.lblEmail = new System.Windows.Forms.Label();
            this.pctUsuario = new System.Windows.Forms.PictureBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnGravar = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.cmbTipoTel3 = new System.Windows.Forms.ComboBox();
            this.cmbTipoTel2 = new System.Windows.Forms.ComboBox();
            this.ptbCpf = new System.Windows.Forms.PictureBox();
            this.mskTelefone3 = new System.Windows.Forms.MaskedTextBox();
            this.lblRg = new System.Windows.Forms.Label();
            this.mskTelefone2 = new System.Windows.Forms.MaskedTextBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.txtObsTel3 = new System.Windows.Forms.TextBox();
            this.lblMae = new System.Windows.Forms.Label();
            this.txtObsTel2 = new System.Windows.Forms.TextBox();
            this.lblPai = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.lblEmissao = new System.Windows.Forms.Label();
            this.cmbTipoTel1 = new System.Windows.Forms.ComboBox();
            this.txtFiliacaoMae = new System.Windows.Forms.TextBox();
            this.mskTelefone1 = new System.Windows.Forms.MaskedTextBox();
            this.lblDataNasc = new System.Windows.Forms.Label();
            this.txtObsTel1 = new System.Windows.Forms.TextBox();
            this.txtRg = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.mskCep = new System.Windows.Forms.MaskedTextBox();
            this.cmbEmissao = new System.Windows.Forms.ComboBox();
            this.txtFiliacaoPai = new System.Windows.Forms.TextBox();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.mskCpf = new System.Windows.Forms.MaskedTextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.mskDataNasc = new System.Windows.Forms.MaskedTextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblCep = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.tpgCadCursos = new System.Windows.Forms.TabPage();
            this.dgvConsultaCursoAluno = new System.Windows.Forms.DataGridView();
            this.pnlTitulo.SuspendLayout();
            this.pnlFormulario.SuspendLayout();
            this.tbcAluno.SuspendLayout();
            this.tpgCadAluno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCpf)).BeginInit();
            this.tpgCadCursos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaCursoAluno)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.DarkBlue;
            this.pnlTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTitulo.Controls.Add(this.lblSair);
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(726, 36);
            this.pnlTitulo.TabIndex = 5;
            this.pnlTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblTitulo_MouseDown);
            this.pnlTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblTitulo_MouseMove);
            this.pnlTitulo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblTitulo_MouseUp);
            // 
            // lblSair
            // 
            this.lblSair.AutoSize = true;
            this.lblSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSair.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSair.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSair.ForeColor = System.Drawing.Color.White;
            this.lblSair.Location = new System.Drawing.Point(689, 0);
            this.lblSair.Name = "lblSair";
            this.lblSair.Size = new System.Drawing.Size(35, 37);
            this.lblSair.TabIndex = 29;
            this.lblSair.Text = "X";
            this.toolTip1.SetToolTip(this.lblSair, "Fechar");
            this.lblSair.Click += new System.EventHandler(this.lblSair_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(206, 34);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "Aluno";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblTitulo_MouseDown);
            this.lblTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblTitulo_MouseMove);
            this.lblTitulo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblTitulo_MouseUp);
            // 
            // btnInserir
            // 
            this.btnInserir.BackgroundImage = global::Ides.Properties.Resources.camera;
            this.btnInserir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInserir.Location = new System.Drawing.Point(13, 134);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(53, 48);
            this.btnInserir.TabIndex = 27;
            this.toolTip1.SetToolTip(this.btnInserir, "Inserir Imagem");
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnCapturar
            // 
            this.btnCapturar.BackgroundImage = global::Ides.Properties.Resources.webcam;
            this.btnCapturar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCapturar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCapturar.Location = new System.Drawing.Point(85, 134);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Size = new System.Drawing.Size(56, 48);
            this.btnCapturar.TabIndex = 28;
            this.toolTip1.SetToolTip(this.btnCapturar, "Capturar Imagem");
            this.btnCapturar.UseVisualStyleBackColor = true;
            this.btnCapturar.Click += new System.EventHandler(this.btnCapturar_Click);
            // 
            // btnBuscaCep
            // 
            this.btnBuscaCep.BackgroundImage = global::Ides.Properties.Resources.busca;
            this.btnBuscaCep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBuscaCep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscaCep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscaCep.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscaCep.ForeColor = System.Drawing.Color.White;
            this.btnBuscaCep.Location = new System.Drawing.Point(389, 175);
            this.btnBuscaCep.Name = "btnBuscaCep";
            this.btnBuscaCep.Size = new System.Drawing.Size(58, 37);
            this.btnBuscaCep.TabIndex = 8;
            this.toolTip1.SetToolTip(this.btnBuscaCep, "Burcar Cep");
            this.btnBuscaCep.UseVisualStyleBackColor = true;
            this.btnBuscaCep.Click += new System.EventHandler(this.btnBuscaCep_Click_1);
            // 
            // pnlFormulario
            // 
            this.pnlFormulario.Controls.Add(this.tbcAluno);
            this.pnlFormulario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFormulario.Location = new System.Drawing.Point(0, 36);
            this.pnlFormulario.Name = "pnlFormulario";
            this.pnlFormulario.Size = new System.Drawing.Size(726, 610);
            this.pnlFormulario.TabIndex = 8;
            // 
            // tbcAluno
            // 
            this.tbcAluno.Controls.Add(this.tpgCadAluno);
            this.tbcAluno.Controls.Add(this.tpgCadCursos);
            this.tbcAluno.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcAluno.Location = new System.Drawing.Point(5, 3);
            this.tbcAluno.Name = "tbcAluno";
            this.tbcAluno.SelectedIndex = 0;
            this.tbcAluno.Size = new System.Drawing.Size(718, 604);
            this.tbcAluno.TabIndex = 9;
            // 
            // tpgCadAluno
            // 
            this.tpgCadAluno.Controls.Add(this.lblEmail);
            this.tpgCadAluno.Controls.Add(this.pctUsuario);
            this.tpgCadAluno.Controls.Add(this.btnInserir);
            this.tpgCadAluno.Controls.Add(this.txtEmail);
            this.tpgCadAluno.Controls.Add(this.btnCapturar);
            this.tpgCadAluno.Controls.Add(this.btnCancelar);
            this.tpgCadAluno.Controls.Add(this.txtNome);
            this.tpgCadAluno.Controls.Add(this.btnGravar);
            this.tpgCadAluno.Controls.Add(this.lblNome);
            this.tpgCadAluno.Controls.Add(this.cmbTipoTel3);
            this.tpgCadAluno.Controls.Add(this.btnBuscaCep);
            this.tpgCadAluno.Controls.Add(this.cmbTipoTel2);
            this.tpgCadAluno.Controls.Add(this.ptbCpf);
            this.tpgCadAluno.Controls.Add(this.mskTelefone3);
            this.tpgCadAluno.Controls.Add(this.lblRg);
            this.tpgCadAluno.Controls.Add(this.mskTelefone2);
            this.tpgCadAluno.Controls.Add(this.lblCpf);
            this.tpgCadAluno.Controls.Add(this.txtObsTel3);
            this.tpgCadAluno.Controls.Add(this.lblMae);
            this.tpgCadAluno.Controls.Add(this.txtObsTel2);
            this.tpgCadAluno.Controls.Add(this.lblPai);
            this.tpgCadAluno.Controls.Add(this.cmbEstado);
            this.tpgCadAluno.Controls.Add(this.lblEmissao);
            this.tpgCadAluno.Controls.Add(this.cmbTipoTel1);
            this.tpgCadAluno.Controls.Add(this.txtFiliacaoMae);
            this.tpgCadAluno.Controls.Add(this.mskTelefone1);
            this.tpgCadAluno.Controls.Add(this.lblDataNasc);
            this.tpgCadAluno.Controls.Add(this.txtObsTel1);
            this.tpgCadAluno.Controls.Add(this.txtRg);
            this.tpgCadAluno.Controls.Add(this.lblEstado);
            this.tpgCadAluno.Controls.Add(this.lblTelefone);
            this.tpgCadAluno.Controls.Add(this.mskCep);
            this.tpgCadAluno.Controls.Add(this.cmbEmissao);
            this.tpgCadAluno.Controls.Add(this.txtFiliacaoPai);
            this.tpgCadAluno.Controls.Add(this.txtComplemento);
            this.tpgCadAluno.Controls.Add(this.mskCpf);
            this.tpgCadAluno.Controls.Add(this.txtNumero);
            this.tpgCadAluno.Controls.Add(this.mskDataNasc);
            this.tpgCadAluno.Controls.Add(this.txtCidade);
            this.tpgCadAluno.Controls.Add(this.lblBairro);
            this.tpgCadAluno.Controls.Add(this.lblCep);
            this.tpgCadAluno.Controls.Add(this.lblEndereco);
            this.tpgCadAluno.Controls.Add(this.txtEndereco);
            this.tpgCadAluno.Controls.Add(this.lblCidade);
            this.tpgCadAluno.Controls.Add(this.txtBairro);
            this.tpgCadAluno.Controls.Add(this.lblNumero);
            this.tpgCadAluno.Controls.Add(this.lblComplemento);
            this.tpgCadAluno.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpgCadAluno.Location = new System.Drawing.Point(4, 26);
            this.tpgCadAluno.Name = "tpgCadAluno";
            this.tpgCadAluno.Padding = new System.Windows.Forms.Padding(3);
            this.tpgCadAluno.Size = new System.Drawing.Size(710, 574);
            this.tpgCadAluno.TabIndex = 0;
            this.tpgCadAluno.Text = "Aluno";
            this.tpgCadAluno.UseVisualStyleBackColor = true;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(229, 486);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(55, 20);
            this.lblEmail.TabIndex = 122;
            this.lblEmail.Text = "Email:";
            // 
            // pctUsuario
            // 
            this.pctUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pctUsuario.BackgroundImage = global::Ides.Properties.Resources.usuario2;
            this.pctUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctUsuario.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pctUsuario.ErrorImage")));
            this.pctUsuario.Location = new System.Drawing.Point(13, 9);
            this.pctUsuario.Name = "pctUsuario";
            this.pctUsuario.Size = new System.Drawing.Size(128, 119);
            this.pctUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctUsuario.TabIndex = 118;
            this.pctUsuario.TabStop = false;
            this.pctUsuario.Click += new System.EventHandler(this.pctUsuario_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(291, 479);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(395, 27);
            this.txtEmail.TabIndex = 24;
            this.txtEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRg_KeyDown);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.DarkBlue;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(562, 527);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(124, 32);
            this.btnCancelar.TabIndex = 26;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtNome
            // 
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(291, 16);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(394, 27);
            this.txtNome.TabIndex = 0;
            // 
            // btnGravar
            // 
            this.btnGravar.BackColor = System.Drawing.Color.DarkBlue;
            this.btnGravar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGravar.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravar.ForeColor = System.Drawing.Color.White;
            this.btnGravar.Location = new System.Drawing.Point(291, 527);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(124, 32);
            this.btnGravar.TabIndex = 25;
            this.btnGravar.Text = "GRAVAR";
            this.btnGravar.UseVisualStyleBackColor = false;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(226, 23);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(58, 20);
            this.lblNome.TabIndex = 113;
            this.lblNome.Text = "Nome:";
            // 
            // cmbTipoTel3
            // 
            this.cmbTipoTel3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoTel3.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoTel3.FormattingEnabled = true;
            this.cmbTipoTel3.Items.AddRange(new object[] {
            "Celular",
            "Recado",
            "Residencial"});
            this.cmbTipoTel3.Location = new System.Drawing.Point(291, 445);
            this.cmbTipoTel3.Name = "cmbTipoTel3";
            this.cmbTipoTel3.Size = new System.Drawing.Size(121, 28);
            this.cmbTipoTel3.TabIndex = 21;
            this.cmbTipoTel3.SelectedIndexChanged += new System.EventHandler(this.cmbTipoTel3_SelectedIndexChanged);
            // 
            // cmbTipoTel2
            // 
            this.cmbTipoTel2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoTel2.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoTel2.FormattingEnabled = true;
            this.cmbTipoTel2.Items.AddRange(new object[] {
            "Celular",
            "Recado",
            "Residencial"});
            this.cmbTipoTel2.Location = new System.Drawing.Point(291, 411);
            this.cmbTipoTel2.Name = "cmbTipoTel2";
            this.cmbTipoTel2.Size = new System.Drawing.Size(121, 28);
            this.cmbTipoTel2.TabIndex = 18;
            this.cmbTipoTel2.SelectedIndexChanged += new System.EventHandler(this.cmbTipoTel2_SelectedIndexChanged);
            // 
            // ptbCpf
            // 
            this.ptbCpf.Image = global::Ides.Properties.Resources.erro_cpf;
            this.ptbCpf.Location = new System.Drawing.Point(615, 80);
            this.ptbCpf.Name = "ptbCpf";
            this.ptbCpf.Size = new System.Drawing.Size(34, 34);
            this.ptbCpf.TabIndex = 115;
            this.ptbCpf.TabStop = false;
            // 
            // mskTelefone3
            // 
            this.mskTelefone3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mskTelefone3.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskTelefone3.Location = new System.Drawing.Point(419, 446);
            this.mskTelefone3.Mask = "(00)00000-0000";
            this.mskTelefone3.Name = "mskTelefone3";
            this.mskTelefone3.Size = new System.Drawing.Size(114, 27);
            this.mskTelefone3.TabIndex = 22;
            this.mskTelefone3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRg_KeyDown);
            // 
            // lblRg
            // 
            this.lblRg.AutoSize = true;
            this.lblRg.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRg.Location = new System.Drawing.Point(251, 57);
            this.lblRg.Name = "lblRg";
            this.lblRg.Size = new System.Drawing.Size(34, 20);
            this.lblRg.TabIndex = 105;
            this.lblRg.Text = "RG:";
            // 
            // mskTelefone2
            // 
            this.mskTelefone2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mskTelefone2.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskTelefone2.Location = new System.Drawing.Point(419, 412);
            this.mskTelefone2.Mask = "(00)00000-0000";
            this.mskTelefone2.Name = "mskTelefone2";
            this.mskTelefone2.Size = new System.Drawing.Size(114, 27);
            this.mskTelefone2.TabIndex = 19;
            this.mskTelefone2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRg_KeyDown);
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.Location = new System.Drawing.Point(449, 89);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(40, 20);
            this.lblCpf.TabIndex = 100;
            this.lblCpf.Text = "CPF:";
            // 
            // txtObsTel3
            // 
            this.txtObsTel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtObsTel3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObsTel3.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObsTel3.Location = new System.Drawing.Point(539, 446);
            this.txtObsTel3.MaxLength = 20;
            this.txtObsTel3.Name = "txtObsTel3";
            this.txtObsTel3.Size = new System.Drawing.Size(146, 27);
            this.txtObsTel3.TabIndex = 23;
            // 
            // lblMae
            // 
            this.lblMae.AutoSize = true;
            this.lblMae.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMae.Location = new System.Drawing.Point(240, 122);
            this.lblMae.Name = "lblMae";
            this.lblMae.Size = new System.Drawing.Size(45, 20);
            this.lblMae.TabIndex = 109;
            this.lblMae.Text = "Mãe:";
            // 
            // txtObsTel2
            // 
            this.txtObsTel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtObsTel2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObsTel2.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObsTel2.Location = new System.Drawing.Point(539, 412);
            this.txtObsTel2.MaxLength = 20;
            this.txtObsTel2.Name = "txtObsTel2";
            this.txtObsTel2.Size = new System.Drawing.Size(146, 27);
            this.txtObsTel2.TabIndex = 20;
            // 
            // lblPai
            // 
            this.lblPai.AutoSize = true;
            this.lblPai.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPai.Location = new System.Drawing.Point(248, 154);
            this.lblPai.Name = "lblPai";
            this.lblPai.Size = new System.Drawing.Size(36, 20);
            this.lblPai.TabIndex = 103;
            this.lblPai.Text = "Pai:";
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.ItemHeight = 20;
            this.cmbEstado.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cmbEstado.Location = new System.Drawing.Point(291, 345);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(72, 28);
            this.cmbEstado.TabIndex = 14;
            // 
            // lblEmissao
            // 
            this.lblEmissao.AutoSize = true;
            this.lblEmissao.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmissao.Location = new System.Drawing.Point(457, 57);
            this.lblEmissao.Name = "lblEmissao";
            this.lblEmissao.Size = new System.Drawing.Size(32, 20);
            this.lblEmissao.TabIndex = 111;
            this.lblEmissao.Text = "UF:";
            // 
            // cmbTipoTel1
            // 
            this.cmbTipoTel1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoTel1.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoTel1.FormattingEnabled = true;
            this.cmbTipoTel1.Items.AddRange(new object[] {
            "Celular",
            "Recado",
            "Residencial"});
            this.cmbTipoTel1.Location = new System.Drawing.Point(291, 377);
            this.cmbTipoTel1.Name = "cmbTipoTel1";
            this.cmbTipoTel1.Size = new System.Drawing.Size(121, 28);
            this.cmbTipoTel1.TabIndex = 15;
            this.cmbTipoTel1.SelectedIndexChanged += new System.EventHandler(this.cmbTipoTel1_SelectedIndexChanged);
            // 
            // txtFiliacaoMae
            // 
            this.txtFiliacaoMae.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFiliacaoMae.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFiliacaoMae.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiliacaoMae.Location = new System.Drawing.Point(291, 115);
            this.txtFiliacaoMae.MaxLength = 50;
            this.txtFiliacaoMae.Name = "txtFiliacaoMae";
            this.txtFiliacaoMae.Size = new System.Drawing.Size(394, 27);
            this.txtFiliacaoMae.TabIndex = 5;
            // 
            // mskTelefone1
            // 
            this.mskTelefone1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mskTelefone1.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskTelefone1.Location = new System.Drawing.Point(419, 378);
            this.mskTelefone1.Mask = "(00)00000-0000";
            this.mskTelefone1.Name = "mskTelefone1";
            this.mskTelefone1.Size = new System.Drawing.Size(114, 27);
            this.mskTelefone1.TabIndex = 16;
            this.mskTelefone1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRg_KeyDown);
            // 
            // lblDataNasc
            // 
            this.lblDataNasc.AutoSize = true;
            this.lblDataNasc.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataNasc.Location = new System.Drawing.Point(168, 89);
            this.lblDataNasc.Name = "lblDataNasc";
            this.lblDataNasc.Size = new System.Drawing.Size(118, 20);
            this.lblDataNasc.TabIndex = 104;
            this.lblDataNasc.Text = "Data de Nasc.:";
            // 
            // txtObsTel1
            // 
            this.txtObsTel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtObsTel1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObsTel1.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObsTel1.Location = new System.Drawing.Point(539, 378);
            this.txtObsTel1.MaxLength = 20;
            this.txtObsTel1.Name = "txtObsTel1";
            this.txtObsTel1.Size = new System.Drawing.Size(146, 27);
            this.txtObsTel1.TabIndex = 17;
            this.txtObsTel1.Visible = false;
            // 
            // txtRg
            // 
            this.txtRg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRg.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRg.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRg.Location = new System.Drawing.Point(291, 49);
            this.txtRg.MaxLength = 12;
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(125, 27);
            this.txtRg.TabIndex = 1;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(220, 353);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(64, 20);
            this.lblEstado.TabIndex = 110;
            this.lblEstado.Text = "Estado:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(198, 385);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(86, 20);
            this.lblTelefone.TabIndex = 112;
            this.lblTelefone.Text = "Telefones:";
            // 
            // mskCep
            // 
            this.mskCep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mskCep.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCep.Location = new System.Drawing.Point(291, 180);
            this.mskCep.Mask = "00000-000";
            this.mskCep.Name = "mskCep";
            this.mskCep.Size = new System.Drawing.Size(92, 27);
            this.mskCep.TabIndex = 7;
            this.mskCep.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRg_KeyDown);
            // 
            // cmbEmissao
            // 
            this.cmbEmissao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmissao.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEmissao.FormattingEnabled = true;
            this.cmbEmissao.ItemHeight = 20;
            this.cmbEmissao.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AM",
            "AP",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MG",
            "MS",
            "MT",
            "PA",
            "PB",
            "PE",
            "PI",
            "PR",
            "RJ",
            "RN",
            "RO",
            "RR",
            "RS",
            "SC",
            "SE",
            "SP",
            "TO"});
            this.cmbEmissao.Location = new System.Drawing.Point(495, 49);
            this.cmbEmissao.Name = "cmbEmissao";
            this.cmbEmissao.Size = new System.Drawing.Size(72, 28);
            this.cmbEmissao.TabIndex = 2;
            // 
            // txtFiliacaoPai
            // 
            this.txtFiliacaoPai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFiliacaoPai.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFiliacaoPai.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiliacaoPai.Location = new System.Drawing.Point(291, 147);
            this.txtFiliacaoPai.MaxLength = 50;
            this.txtFiliacaoPai.Name = "txtFiliacaoPai";
            this.txtFiliacaoPai.Size = new System.Drawing.Size(394, 27);
            this.txtFiliacaoPai.TabIndex = 6;
            // 
            // txtComplemento
            // 
            this.txtComplemento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtComplemento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtComplemento.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComplemento.Location = new System.Drawing.Point(518, 246);
            this.txtComplemento.MaxLength = 20;
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(167, 27);
            this.txtComplemento.TabIndex = 11;
            // 
            // mskCpf
            // 
            this.mskCpf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mskCpf.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCpf.Location = new System.Drawing.Point(495, 82);
            this.mskCpf.Mask = "000,000,000-00";
            this.mskCpf.Name = "mskCpf";
            this.mskCpf.Size = new System.Drawing.Size(114, 27);
            this.mskCpf.TabIndex = 4;
            this.mskCpf.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRg_KeyDown);
            this.mskCpf.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mskCpf_KeyUp);
            // 
            // txtNumero
            // 
            this.txtNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumero.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(291, 246);
            this.txtNumero.MaxLength = 6;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(73, 27);
            this.txtNumero.TabIndex = 10;
            this.txtNumero.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRg_KeyDown);
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
            // 
            // mskDataNasc
            // 
            this.mskDataNasc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mskDataNasc.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskDataNasc.Location = new System.Drawing.Point(291, 82);
            this.mskDataNasc.Mask = "00/00/0000";
            this.mskDataNasc.Name = "mskDataNasc";
            this.mskDataNasc.Size = new System.Drawing.Size(92, 27);
            this.mskDataNasc.TabIndex = 3;
            this.mskDataNasc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRg_KeyDown);
            // 
            // txtCidade
            // 
            this.txtCidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCidade.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.Location = new System.Drawing.Point(291, 312);
            this.txtCidade.MaxLength = 50;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(394, 27);
            this.txtCidade.TabIndex = 13;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.Location = new System.Drawing.Point(225, 286);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(59, 20);
            this.lblBairro.TabIndex = 107;
            this.lblBairro.Text = "Bairro:";
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCep.Location = new System.Drawing.Point(243, 187);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(41, 20);
            this.lblCep.TabIndex = 114;
            this.lblCep.Text = "CEP:";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.Location = new System.Drawing.Point(202, 220);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(83, 20);
            this.lblEndereco.TabIndex = 106;
            this.lblEndereco.Text = "Endereço:";
            // 
            // txtEndereco
            // 
            this.txtEndereco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEndereco.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.Location = new System.Drawing.Point(291, 213);
            this.txtEndereco.MaxLength = 50;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(394, 27);
            this.txtEndereco.TabIndex = 9;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.Location = new System.Drawing.Point(218, 319);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(66, 20);
            this.lblCidade.TabIndex = 101;
            this.lblCidade.Text = "Cidade:";
            // 
            // txtBairro
            // 
            this.txtBairro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBairro.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.Location = new System.Drawing.Point(291, 279);
            this.txtBairro.MaxLength = 50;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(394, 27);
            this.txtBairro.TabIndex = 12;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(211, 253);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(73, 20);
            this.lblNumero.TabIndex = 102;
            this.lblNumero.Text = "Número:";
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComplemento.Location = new System.Drawing.Point(392, 248);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(119, 20);
            this.lblComplemento.TabIndex = 108;
            this.lblComplemento.Text = "Complemento:";
            // 
            // tpgCadCursos
            // 
            this.tpgCadCursos.Controls.Add(this.dgvConsultaCursoAluno);
            this.tpgCadCursos.Location = new System.Drawing.Point(4, 26);
            this.tpgCadCursos.Name = "tpgCadCursos";
            this.tpgCadCursos.Padding = new System.Windows.Forms.Padding(3);
            this.tpgCadCursos.Size = new System.Drawing.Size(710, 574);
            this.tpgCadCursos.TabIndex = 1;
            this.tpgCadCursos.Text = "Cursos";
            this.tpgCadCursos.UseVisualStyleBackColor = true;
            // 
            // dgvConsultaCursoAluno
            // 
            this.dgvConsultaCursoAluno.AllowUserToAddRows = false;
            this.dgvConsultaCursoAluno.AllowUserToDeleteRows = false;
            this.dgvConsultaCursoAluno.AllowUserToResizeRows = false;
            this.dgvConsultaCursoAluno.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvConsultaCursoAluno.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConsultaCursoAluno.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvConsultaCursoAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaCursoAluno.Location = new System.Drawing.Point(0, 0);
            this.dgvConsultaCursoAluno.Name = "dgvConsultaCursoAluno";
            this.dgvConsultaCursoAluno.ReadOnly = true;
            this.dgvConsultaCursoAluno.RowHeadersVisible = false;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvConsultaCursoAluno.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvConsultaCursoAluno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsultaCursoAluno.Size = new System.Drawing.Size(708, 571);
            this.dgvConsultaCursoAluno.TabIndex = 90;
            // 
            // frmCadastroAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 646);
            this.Controls.Add(this.pnlFormulario);
            this.Controls.Add(this.pnlTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCadastroAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCadastroAluno";
            this.Load += new System.EventHandler(this.frmCadastroAluno_Load);
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.pnlFormulario.ResumeLayout(false);
            this.tbcAluno.ResumeLayout(false);
            this.tpgCadAluno.ResumeLayout(false);
            this.tpgCadAluno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCpf)).EndInit();
            this.tpgCadCursos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaCursoAluno)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel pnlFormulario;
        private System.Windows.Forms.PictureBox ptbCpf;
        private System.Windows.Forms.Button btnBuscaCep;
        private System.Windows.Forms.ComboBox cmbTipoTel3;
        private System.Windows.Forms.ComboBox cmbTipoTel2;
        private System.Windows.Forms.MaskedTextBox mskTelefone3;
        private System.Windows.Forms.MaskedTextBox mskTelefone2;
        private System.Windows.Forms.TextBox txtObsTel3;
        private System.Windows.Forms.TextBox txtObsTel2;
        private System.Windows.Forms.ComboBox cmbEmissao;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.ComboBox cmbTipoTel1;
        private System.Windows.Forms.MaskedTextBox mskCep;
        private System.Windows.Forms.MaskedTextBox mskDataNasc;
        private System.Windows.Forms.MaskedTextBox mskTelefone1;
        private System.Windows.Forms.MaskedTextBox mskCpf;
        private System.Windows.Forms.TextBox txtFiliacaoPai;
        private System.Windows.Forms.TextBox txtObsTel1;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.TextBox txtRg;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblDataNasc;
        private System.Windows.Forms.TextBox txtFiliacaoMae;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.Label lblEmissao;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblPai;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblMae;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblRg;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnCapturar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.PictureBox pctUsuario;
        private System.Windows.Forms.Label lblSair;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TabControl tbcAluno;
        private System.Windows.Forms.TabPage tpgCadAluno;
        private System.Windows.Forms.TabPage tpgCadCursos;
        private System.Windows.Forms.DataGridView dgvConsultaCursoAluno;
    }
}
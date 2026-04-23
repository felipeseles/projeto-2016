namespace Ides.UI.Consulta
{
    partial class frmConsultas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblSair = new System.Windows.Forms.Label();
            this.lblMaximizar = new System.Windows.Forms.Label();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.tbcConsultas = new System.Windows.Forms.TabControl();
            this.tpgAluno = new System.Windows.Forms.TabPage();
            this.rdbRG = new System.Windows.Forms.RadioButton();
            this.rdbNome = new System.Windows.Forms.RadioButton();
            this.lblFiltroAluno = new System.Windows.Forms.Label();
            this.txtAluno = new System.Windows.Forms.TextBox();
            this.dgvConsultaAluno = new System.Windows.Forms.DataGridView();
            this.tpgCurso = new System.Windows.Forms.TabPage();
            this.lblFiltroCurso = new System.Windows.Forms.Label();
            this.txtCurso = new System.Windows.Forms.TextBox();
            this.dgvConsultaCurso = new System.Windows.Forms.DataGridView();
            this.tpgMatricula = new System.Windows.Forms.TabPage();
            this.rdbNomeAluno = new System.Windows.Forms.RadioButton();
            this.rdbCodMatricula = new System.Windows.Forms.RadioButton();
            this.lblFiltroMatricula = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.dgvConsultaMatricula = new System.Windows.Forms.DataGridView();
            this.tpgProfessor = new System.Windows.Forms.TabPage();
            this.lblFiltroProfessor = new System.Windows.Forms.Label();
            this.txtProfessor = new System.Windows.Forms.TextBox();
            this.dgvConsultaProfessor = new System.Windows.Forms.DataGridView();
            this.tpgTurmas = new System.Windows.Forms.TabPage();
            this.rdbProfessor = new System.Windows.Forms.RadioButton();
            this.rdbCurso = new System.Windows.Forms.RadioButton();
            this.lblFiltroTurma = new System.Windows.Forms.Label();
            this.txtTurma = new System.Windows.Forms.TextBox();
            this.dgvConsultaTurma = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.pnlTitulo.SuspendLayout();
            this.tbcConsultas.SuspendLayout();
            this.tpgAluno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaAluno)).BeginInit();
            this.tpgCurso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaCurso)).BeginInit();
            this.tpgMatricula.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaMatricula)).BeginInit();
            this.tpgProfessor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaProfessor)).BeginInit();
            this.tpgTurmas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaTurma)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.lblTitulo.Text = "Consultas";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblTitulo_MouseDown);
            this.lblTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblTitulo_MouseMove);
            this.lblTitulo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblTitulo_MouseUp);
            // 
            // lblSair
            // 
            this.lblSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSair.AutoSize = true;
            this.lblSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSair.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSair.ForeColor = System.Drawing.Color.White;
            this.lblSair.Location = new System.Drawing.Point(863, 0);
            this.lblSair.Name = "lblSair";
            this.lblSair.Size = new System.Drawing.Size(35, 37);
            this.lblSair.TabIndex = 8;
            this.lblSair.Text = "X";
            this.toolTip1.SetToolTip(this.lblSair, "Fechar");
            this.lblSair.Click += new System.EventHandler(this.lblSair_Click);
            // 
            // lblMaximizar
            // 
            this.lblMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMaximizar.AutoSize = true;
            this.lblMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMaximizar.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaximizar.ForeColor = System.Drawing.Color.White;
            this.lblMaximizar.Location = new System.Drawing.Point(830, -10);
            this.lblMaximizar.Name = "lblMaximizar";
            this.lblMaximizar.Size = new System.Drawing.Size(41, 47);
            this.lblMaximizar.TabIndex = 9;
            this.lblMaximizar.Text = "□";
            this.toolTip1.SetToolTip(this.lblMaximizar, "Maximizar / Restaurar");
            this.lblMaximizar.Click += new System.EventHandler(this.lblMaximizar_Click);
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.DarkBlue;
            this.pnlTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTitulo.Controls.Add(this.lblMaximizar);
            this.pnlTitulo.Controls.Add(this.lblSair);
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(900, 36);
            this.pnlTitulo.TabIndex = 15;
            this.pnlTitulo.DoubleClick += new System.EventHandler(this.pnlTitulo_DoubleClick);
            this.pnlTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblTitulo_MouseDown);
            this.pnlTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblTitulo_MouseMove);
            this.pnlTitulo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblTitulo_MouseUp);
            // 
            // tbcConsultas
            // 
            this.tbcConsultas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbcConsultas.Controls.Add(this.tpgAluno);
            this.tbcConsultas.Controls.Add(this.tpgCurso);
            this.tbcConsultas.Controls.Add(this.tpgMatricula);
            this.tbcConsultas.Controls.Add(this.tpgProfessor);
            this.tbcConsultas.Controls.Add(this.tpgTurmas);
            this.tbcConsultas.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcConsultas.Location = new System.Drawing.Point(0, 94);
            this.tbcConsultas.Name = "tbcConsultas";
            this.tbcConsultas.SelectedIndex = 0;
            this.tbcConsultas.Size = new System.Drawing.Size(897, 604);
            this.tbcConsultas.TabIndex = 0;
            // 
            // tpgAluno
            // 
            this.tpgAluno.Controls.Add(this.rdbRG);
            this.tpgAluno.Controls.Add(this.rdbNome);
            this.tpgAluno.Controls.Add(this.lblFiltroAluno);
            this.tpgAluno.Controls.Add(this.txtAluno);
            this.tpgAluno.Controls.Add(this.dgvConsultaAluno);
            this.tpgAluno.Location = new System.Drawing.Point(4, 26);
            this.tpgAluno.Name = "tpgAluno";
            this.tpgAluno.Padding = new System.Windows.Forms.Padding(3);
            this.tpgAluno.Size = new System.Drawing.Size(889, 574);
            this.tpgAluno.TabIndex = 0;
            this.tpgAluno.Text = "Alunos";
            this.tpgAluno.UseVisualStyleBackColor = true;
            // 
            // rdbRG
            // 
            this.rdbRG.AutoSize = true;
            this.rdbRG.Location = new System.Drawing.Point(730, 33);
            this.rdbRG.Name = "rdbRG";
            this.rdbRG.Size = new System.Drawing.Size(43, 21);
            this.rdbRG.TabIndex = 92;
            this.rdbRG.TabStop = true;
            this.rdbRG.Text = "RG";
            this.rdbRG.UseVisualStyleBackColor = true;
            // 
            // rdbNome
            // 
            this.rdbNome.AutoSize = true;
            this.rdbNome.Checked = true;
            this.rdbNome.Location = new System.Drawing.Point(730, 6);
            this.rdbNome.Name = "rdbNome";
            this.rdbNome.Size = new System.Drawing.Size(62, 21);
            this.rdbNome.TabIndex = 92;
            this.rdbNome.TabStop = true;
            this.rdbNome.Text = "Nome";
            this.rdbNome.UseVisualStyleBackColor = true;
            // 
            // lblFiltroAluno
            // 
            this.lblFiltroAluno.AutoSize = true;
            this.lblFiltroAluno.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltroAluno.Location = new System.Drawing.Point(48, 19);
            this.lblFiltroAluno.Name = "lblFiltroAluno";
            this.lblFiltroAluno.Size = new System.Drawing.Size(47, 17);
            this.lblFiltroAluno.TabIndex = 91;
            this.lblFiltroAluno.Text = "Filtro:";
            // 
            // txtAluno
            // 
            this.txtAluno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAluno.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAluno.Location = new System.Drawing.Point(101, 16);
            this.txtAluno.Name = "txtAluno";
            this.txtAluno.Size = new System.Drawing.Size(573, 25);
            this.txtAluno.TabIndex = 90;
            this.txtAluno.TextChanged += new System.EventHandler(this.txtAluno_TextChanged);
            this.txtAluno.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtAluno_KeyUp);
            // 
            // dgvConsultaAluno
            // 
            this.dgvConsultaAluno.AllowUserToAddRows = false;
            this.dgvConsultaAluno.AllowUserToDeleteRows = false;
            this.dgvConsultaAluno.AllowUserToResizeRows = false;
            this.dgvConsultaAluno.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvConsultaAluno.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConsultaAluno.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvConsultaAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaAluno.Location = new System.Drawing.Point(6, 60);
            this.dgvConsultaAluno.Name = "dgvConsultaAluno";
            this.dgvConsultaAluno.ReadOnly = true;
            this.dgvConsultaAluno.RowHeadersVisible = false;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvConsultaAluno.RowsDefaultCellStyle = dataGridViewCellStyle21;
            this.dgvConsultaAluno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsultaAluno.Size = new System.Drawing.Size(877, 508);
            this.dgvConsultaAluno.TabIndex = 89;
            this.dgvConsultaAluno.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsultaAluno_CellDoubleClick);
            // 
            // tpgCurso
            // 
            this.tpgCurso.Controls.Add(this.lblFiltroCurso);
            this.tpgCurso.Controls.Add(this.txtCurso);
            this.tpgCurso.Controls.Add(this.dgvConsultaCurso);
            this.tpgCurso.Location = new System.Drawing.Point(4, 26);
            this.tpgCurso.Name = "tpgCurso";
            this.tpgCurso.Padding = new System.Windows.Forms.Padding(3);
            this.tpgCurso.Size = new System.Drawing.Size(889, 574);
            this.tpgCurso.TabIndex = 1;
            this.tpgCurso.Text = "Cursos";
            this.tpgCurso.UseVisualStyleBackColor = true;
            // 
            // lblFiltroCurso
            // 
            this.lblFiltroCurso.AutoSize = true;
            this.lblFiltroCurso.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltroCurso.Location = new System.Drawing.Point(48, 19);
            this.lblFiltroCurso.Name = "lblFiltroCurso";
            this.lblFiltroCurso.Size = new System.Drawing.Size(47, 17);
            this.lblFiltroCurso.TabIndex = 97;
            this.lblFiltroCurso.Text = "Filtro:";
            // 
            // txtCurso
            // 
            this.txtCurso.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCurso.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurso.Location = new System.Drawing.Point(101, 16);
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.Size = new System.Drawing.Size(573, 25);
            this.txtCurso.TabIndex = 94;
            this.txtCurso.TextChanged += new System.EventHandler(this.txtCurso_TextChanged_1);
            // 
            // dgvConsultaCurso
            // 
            this.dgvConsultaCurso.AllowUserToAddRows = false;
            this.dgvConsultaCurso.AllowUserToResizeRows = false;
            this.dgvConsultaCurso.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvConsultaCurso.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConsultaCurso.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvConsultaCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaCurso.Location = new System.Drawing.Point(6, 60);
            this.dgvConsultaCurso.Name = "dgvConsultaCurso";
            this.dgvConsultaCurso.ReadOnly = true;
            this.dgvConsultaCurso.RowHeadersVisible = false;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvConsultaCurso.RowsDefaultCellStyle = dataGridViewCellStyle22;
            this.dgvConsultaCurso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsultaCurso.Size = new System.Drawing.Size(877, 508);
            this.dgvConsultaCurso.TabIndex = 93;
            this.dgvConsultaCurso.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsultaCurso_CellDoubleClick);
            // 
            // tpgMatricula
            // 
            this.tpgMatricula.Controls.Add(this.rdbNomeAluno);
            this.tpgMatricula.Controls.Add(this.rdbCodMatricula);
            this.tpgMatricula.Controls.Add(this.lblFiltroMatricula);
            this.tpgMatricula.Controls.Add(this.txtMatricula);
            this.tpgMatricula.Controls.Add(this.dgvConsultaMatricula);
            this.tpgMatricula.Location = new System.Drawing.Point(4, 26);
            this.tpgMatricula.Name = "tpgMatricula";
            this.tpgMatricula.Padding = new System.Windows.Forms.Padding(3);
            this.tpgMatricula.Size = new System.Drawing.Size(889, 574);
            this.tpgMatricula.TabIndex = 2;
            this.tpgMatricula.Text = "Matriculas";
            this.tpgMatricula.UseVisualStyleBackColor = true;
            // 
            // rdbNomeAluno
            // 
            this.rdbNomeAluno.AutoSize = true;
            this.rdbNomeAluno.Location = new System.Drawing.Point(730, 33);
            this.rdbNomeAluno.Name = "rdbNomeAluno";
            this.rdbNomeAluno.Size = new System.Drawing.Size(119, 21);
            this.rdbNomeAluno.TabIndex = 96;
            this.rdbNomeAluno.TabStop = true;
            this.rdbNomeAluno.Text = "Nome do Aluno";
            this.rdbNomeAluno.UseVisualStyleBackColor = true;
            // 
            // rdbCodMatricula
            // 
            this.rdbCodMatricula.AutoSize = true;
            this.rdbCodMatricula.Checked = true;
            this.rdbCodMatricula.Location = new System.Drawing.Point(730, 6);
            this.rdbCodMatricula.Name = "rdbCodMatricula";
            this.rdbCodMatricula.Size = new System.Drawing.Size(146, 21);
            this.rdbCodMatricula.TabIndex = 97;
            this.rdbCodMatricula.TabStop = true;
            this.rdbCodMatricula.Text = "Código da Matricula";
            this.rdbCodMatricula.UseVisualStyleBackColor = true;
            // 
            // lblFiltroMatricula
            // 
            this.lblFiltroMatricula.AutoSize = true;
            this.lblFiltroMatricula.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltroMatricula.Location = new System.Drawing.Point(48, 19);
            this.lblFiltroMatricula.Name = "lblFiltroMatricula";
            this.lblFiltroMatricula.Size = new System.Drawing.Size(47, 17);
            this.lblFiltroMatricula.TabIndex = 95;
            this.lblFiltroMatricula.Text = "Filtro:";
            // 
            // txtMatricula
            // 
            this.txtMatricula.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMatricula.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatricula.Location = new System.Drawing.Point(101, 16);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(573, 25);
            this.txtMatricula.TabIndex = 94;
            // 
            // dgvConsultaMatricula
            // 
            this.dgvConsultaMatricula.AllowUserToAddRows = false;
            this.dgvConsultaMatricula.AllowUserToResizeRows = false;
            this.dgvConsultaMatricula.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvConsultaMatricula.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConsultaMatricula.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvConsultaMatricula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaMatricula.Location = new System.Drawing.Point(6, 60);
            this.dgvConsultaMatricula.Name = "dgvConsultaMatricula";
            this.dgvConsultaMatricula.ReadOnly = true;
            this.dgvConsultaMatricula.RowHeadersVisible = false;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvConsultaMatricula.RowsDefaultCellStyle = dataGridViewCellStyle23;
            this.dgvConsultaMatricula.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsultaMatricula.Size = new System.Drawing.Size(877, 508);
            this.dgvConsultaMatricula.TabIndex = 93;
            this.dgvConsultaMatricula.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsultaMatricula_CellDoubleClick);
            // 
            // tpgProfessor
            // 
            this.tpgProfessor.Controls.Add(this.lblFiltroProfessor);
            this.tpgProfessor.Controls.Add(this.txtProfessor);
            this.tpgProfessor.Controls.Add(this.dgvConsultaProfessor);
            this.tpgProfessor.Location = new System.Drawing.Point(4, 26);
            this.tpgProfessor.Name = "tpgProfessor";
            this.tpgProfessor.Padding = new System.Windows.Forms.Padding(3);
            this.tpgProfessor.Size = new System.Drawing.Size(889, 574);
            this.tpgProfessor.TabIndex = 3;
            this.tpgProfessor.Text = "Professores";
            this.tpgProfessor.UseVisualStyleBackColor = true;
            // 
            // lblFiltroProfessor
            // 
            this.lblFiltroProfessor.AutoSize = true;
            this.lblFiltroProfessor.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltroProfessor.Location = new System.Drawing.Point(48, 19);
            this.lblFiltroProfessor.Name = "lblFiltroProfessor";
            this.lblFiltroProfessor.Size = new System.Drawing.Size(47, 17);
            this.lblFiltroProfessor.TabIndex = 100;
            this.lblFiltroProfessor.Text = "Filtro:";
            // 
            // txtProfessor
            // 
            this.txtProfessor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProfessor.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProfessor.Location = new System.Drawing.Point(101, 16);
            this.txtProfessor.Name = "txtProfessor";
            this.txtProfessor.Size = new System.Drawing.Size(573, 25);
            this.txtProfessor.TabIndex = 99;
            this.txtProfessor.TextChanged += new System.EventHandler(this.txtProfessor_TextChanged_1);
            // 
            // dgvConsultaProfessor
            // 
            this.dgvConsultaProfessor.AllowUserToAddRows = false;
            this.dgvConsultaProfessor.AllowUserToResizeRows = false;
            this.dgvConsultaProfessor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvConsultaProfessor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConsultaProfessor.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvConsultaProfessor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaProfessor.Location = new System.Drawing.Point(6, 60);
            this.dgvConsultaProfessor.Name = "dgvConsultaProfessor";
            this.dgvConsultaProfessor.ReadOnly = true;
            this.dgvConsultaProfessor.RowHeadersVisible = false;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvConsultaProfessor.RowsDefaultCellStyle = dataGridViewCellStyle24;
            this.dgvConsultaProfessor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsultaProfessor.Size = new System.Drawing.Size(877, 508);
            this.dgvConsultaProfessor.TabIndex = 98;
            this.dgvConsultaProfessor.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsultaProfessor_CellDoubleClick);
            // 
            // tpgTurmas
            // 
            this.tpgTurmas.Controls.Add(this.rdbProfessor);
            this.tpgTurmas.Controls.Add(this.rdbCurso);
            this.tpgTurmas.Controls.Add(this.lblFiltroTurma);
            this.tpgTurmas.Controls.Add(this.txtTurma);
            this.tpgTurmas.Controls.Add(this.dgvConsultaTurma);
            this.tpgTurmas.Location = new System.Drawing.Point(4, 26);
            this.tpgTurmas.Name = "tpgTurmas";
            this.tpgTurmas.Padding = new System.Windows.Forms.Padding(3);
            this.tpgTurmas.Size = new System.Drawing.Size(889, 574);
            this.tpgTurmas.TabIndex = 4;
            this.tpgTurmas.Text = "Turmas";
            this.tpgTurmas.UseVisualStyleBackColor = true;
            // 
            // rdbProfessor
            // 
            this.rdbProfessor.AutoSize = true;
            this.rdbProfessor.Location = new System.Drawing.Point(730, 33);
            this.rdbProfessor.Name = "rdbProfessor";
            this.rdbProfessor.Size = new System.Drawing.Size(142, 21);
            this.rdbProfessor.TabIndex = 101;
            this.rdbProfessor.TabStop = true;
            this.rdbProfessor.Text = "Nome do Professor";
            this.rdbProfessor.UseVisualStyleBackColor = true;
            // 
            // rdbCurso
            // 
            this.rdbCurso.AutoSize = true;
            this.rdbCurso.Checked = true;
            this.rdbCurso.Location = new System.Drawing.Point(730, 6);
            this.rdbCurso.Name = "rdbCurso";
            this.rdbCurso.Size = new System.Drawing.Size(120, 21);
            this.rdbCurso.TabIndex = 102;
            this.rdbCurso.TabStop = true;
            this.rdbCurso.Text = "Nome do Curso";
            this.rdbCurso.UseVisualStyleBackColor = true;
            // 
            // lblFiltroTurma
            // 
            this.lblFiltroTurma.AutoSize = true;
            this.lblFiltroTurma.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltroTurma.Location = new System.Drawing.Point(48, 19);
            this.lblFiltroTurma.Name = "lblFiltroTurma";
            this.lblFiltroTurma.Size = new System.Drawing.Size(47, 17);
            this.lblFiltroTurma.TabIndex = 100;
            this.lblFiltroTurma.Text = "Filtro:";
            // 
            // txtTurma
            // 
            this.txtTurma.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTurma.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTurma.Location = new System.Drawing.Point(101, 16);
            this.txtTurma.Name = "txtTurma";
            this.txtTurma.Size = new System.Drawing.Size(573, 25);
            this.txtTurma.TabIndex = 99;
            this.txtTurma.TextChanged += new System.EventHandler(this.txtTurma_TextChanged);
            // 
            // dgvConsultaTurma
            // 
            this.dgvConsultaTurma.AllowUserToAddRows = false;
            this.dgvConsultaTurma.AllowUserToResizeRows = false;
            this.dgvConsultaTurma.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvConsultaTurma.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConsultaTurma.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvConsultaTurma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaTurma.Location = new System.Drawing.Point(6, 60);
            this.dgvConsultaTurma.Name = "dgvConsultaTurma";
            this.dgvConsultaTurma.ReadOnly = true;
            this.dgvConsultaTurma.RowHeadersVisible = false;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvConsultaTurma.RowsDefaultCellStyle = dataGridViewCellStyle25;
            this.dgvConsultaTurma.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsultaTurma.Size = new System.Drawing.Size(877, 508);
            this.dgvConsultaTurma.TabIndex = 98;
            this.dgvConsultaTurma.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsultaTurma_CellDoubleClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEditar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 36);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(900, 55);
            this.toolStrip1.TabIndex = 17;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnEditar
            // 
            this.btnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEditar.Image = global::Ides.Properties.Resources.edit_48x48;
            this.btnEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(52, 52);
            this.btnEditar.Text = "Editar Cadastro";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // frmConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 700);
            this.Controls.Add(this.tbcConsultas);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pnlTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConsultas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConsultas";
            this.Load += new System.EventHandler(this.frmConsultas_Load);
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.tbcConsultas.ResumeLayout(false);
            this.tpgAluno.ResumeLayout(false);
            this.tpgAluno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaAluno)).EndInit();
            this.tpgCurso.ResumeLayout(false);
            this.tpgCurso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaCurso)).EndInit();
            this.tpgMatricula.ResumeLayout(false);
            this.tpgMatricula.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaMatricula)).EndInit();
            this.tpgProfessor.ResumeLayout(false);
            this.tpgProfessor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaProfessor)).EndInit();
            this.tpgTurmas.ResumeLayout(false);
            this.tpgTurmas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaTurma)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TabControl tbcConsultas;
        private System.Windows.Forms.TabPage tpgAluno;
        private System.Windows.Forms.TabPage tpgCurso;
        private System.Windows.Forms.TabPage tpgMatricula;
        private System.Windows.Forms.TabPage tpgProfessor;
        private System.Windows.Forms.TabPage tpgTurmas;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.DataGridView dgvConsultaAluno;
        private System.Windows.Forms.RadioButton rdbRG;
        private System.Windows.Forms.RadioButton rdbNome;
        private System.Windows.Forms.Label lblFiltroAluno;
        private System.Windows.Forms.TextBox txtAluno;
        private System.Windows.Forms.Label lblSair;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.Label lblFiltroCurso;
        private System.Windows.Forms.TextBox txtCurso;
        private System.Windows.Forms.DataGridView dgvConsultaCurso;
        private System.Windows.Forms.RadioButton rdbNomeAluno;
        private System.Windows.Forms.RadioButton rdbCodMatricula;
        private System.Windows.Forms.Label lblFiltroMatricula;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.DataGridView dgvConsultaMatricula;
        private System.Windows.Forms.Label lblFiltroProfessor;
        private System.Windows.Forms.TextBox txtProfessor;
        private System.Windows.Forms.DataGridView dgvConsultaProfessor;
        private System.Windows.Forms.RadioButton rdbProfessor;
        private System.Windows.Forms.RadioButton rdbCurso;
        private System.Windows.Forms.Label lblFiltroTurma;
        private System.Windows.Forms.TextBox txtTurma;
        private System.Windows.Forms.DataGridView dgvConsultaTurma;
        private System.Windows.Forms.Label lblMaximizar;
    }
}
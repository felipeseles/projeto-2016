namespace Ides.UI.Aluno
{
    partial class frmCadastroSimplesAluno
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblSair = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.pnlFormulario = new System.Windows.Forms.Panel();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.cmbEmissao = new System.Windows.Forms.ComboBox();
            this.cmbTipoTel1 = new System.Windows.Forms.ComboBox();
            this.mskDataNasc = new System.Windows.Forms.MaskedTextBox();
            this.mskTelefone1 = new System.Windows.Forms.MaskedTextBox();
            this.txtObsTel1 = new System.Windows.Forms.TextBox();
            this.txtRg = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblDataNasc = new System.Windows.Forms.Label();
            this.lblEmissaoRg = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblRg = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.pnlTitulo.SuspendLayout();
            this.pnlFormulario.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSair
            // 
            this.lblSair.AutoSize = true;
            this.lblSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSair.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSair.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSair.ForeColor = System.Drawing.Color.White;
            this.lblSair.Location = new System.Drawing.Point(524, 0);
            this.lblSair.Name = "lblSair";
            this.lblSair.Size = new System.Drawing.Size(35, 37);
            this.lblSair.TabIndex = 9;
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
            this.lblTitulo.Text = "Cadastro de Aluno";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblTitulo_MouseDown);
            this.lblTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblTitulo_MouseMove);
            this.lblTitulo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblTitulo_MouseUp);
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
            this.pnlTitulo.Size = new System.Drawing.Size(561, 36);
            this.pnlTitulo.TabIndex = 8;
            this.pnlTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblTitulo_MouseDown);
            this.pnlTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblTitulo_MouseMove);
            this.pnlTitulo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblTitulo_MouseUp);
            // 
            // pnlFormulario
            // 
            this.pnlFormulario.BackColor = System.Drawing.SystemColors.Control;
            this.pnlFormulario.Controls.Add(this.lblObservacao);
            this.pnlFormulario.Controls.Add(this.btnCancelar);
            this.pnlFormulario.Controls.Add(this.btnGravar);
            this.pnlFormulario.Controls.Add(this.cmbEmissao);
            this.pnlFormulario.Controls.Add(this.cmbTipoTel1);
            this.pnlFormulario.Controls.Add(this.mskDataNasc);
            this.pnlFormulario.Controls.Add(this.mskTelefone1);
            this.pnlFormulario.Controls.Add(this.txtObsTel1);
            this.pnlFormulario.Controls.Add(this.txtRg);
            this.pnlFormulario.Controls.Add(this.txtNome);
            this.pnlFormulario.Controls.Add(this.lblDataNasc);
            this.pnlFormulario.Controls.Add(this.lblEmissaoRg);
            this.pnlFormulario.Controls.Add(this.lblTelefone);
            this.pnlFormulario.Controls.Add(this.lblRg);
            this.pnlFormulario.Controls.Add(this.lblNome);
            this.pnlFormulario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFormulario.Location = new System.Drawing.Point(0, 36);
            this.pnlFormulario.Name = "pnlFormulario";
            this.pnlFormulario.Size = new System.Drawing.Size(561, 301);
            this.pnlFormulario.TabIndex = 9;
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservacao.ForeColor = System.Drawing.Color.Red;
            this.lblObservacao.Location = new System.Drawing.Point(12, 275);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(258, 17);
            this.lblObservacao.TabIndex = 85;
            this.lblObservacao.Text = "* Todos os campos são obrigatórios";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.DarkBlue;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(403, 202);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(124, 32);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.BackColor = System.Drawing.Color.DarkBlue;
            this.btnGravar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGravar.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravar.ForeColor = System.Drawing.Color.White;
            this.btnGravar.Location = new System.Drawing.Point(133, 202);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(124, 32);
            this.btnGravar.TabIndex = 7;
            this.btnGravar.Text = "GRAVAR";
            this.btnGravar.UseVisualStyleBackColor = false;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
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
            this.cmbEmissao.Location = new System.Drawing.Point(380, 82);
            this.cmbEmissao.Name = "cmbEmissao";
            this.cmbEmissao.Size = new System.Drawing.Size(72, 28);
            this.cmbEmissao.TabIndex = 2;
            // 
            // cmbTipoTel1
            // 
            this.cmbTipoTel1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoTel1.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoTel1.FormattingEnabled = true;
            this.cmbTipoTel1.Items.AddRange(new object[] {
            "Celular",
            "Recado Cel.",
            "Recado Res.",
            "Residencial"});
            this.cmbTipoTel1.Location = new System.Drawing.Point(133, 148);
            this.cmbTipoTel1.Name = "cmbTipoTel1";
            this.cmbTipoTel1.Size = new System.Drawing.Size(121, 28);
            this.cmbTipoTel1.TabIndex = 4;
            this.cmbTipoTel1.SelectedIndexChanged += new System.EventHandler(this.cmbTipoTel1_SelectedIndexChanged);
            // 
            // mskDataNasc
            // 
            this.mskDataNasc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mskDataNasc.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskDataNasc.Location = new System.Drawing.Point(133, 115);
            this.mskDataNasc.Mask = "00/00/0000";
            this.mskDataNasc.Name = "mskDataNasc";
            this.mskDataNasc.Size = new System.Drawing.Size(92, 27);
            this.mskDataNasc.TabIndex = 3;
            this.mskDataNasc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRg_KeyDown);
            // 
            // mskTelefone1
            // 
            this.mskTelefone1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mskTelefone1.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskTelefone1.Location = new System.Drawing.Point(260, 148);
            this.mskTelefone1.Mask = "(00)00000-0000";
            this.mskTelefone1.Name = "mskTelefone1";
            this.mskTelefone1.Size = new System.Drawing.Size(114, 27);
            this.mskTelefone1.TabIndex = 5;
            this.mskTelefone1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRg_KeyDown);
            // 
            // txtObsTel1
            // 
            this.txtObsTel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtObsTel1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObsTel1.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObsTel1.Location = new System.Drawing.Point(380, 148);
            this.txtObsTel1.MaxLength = 20;
            this.txtObsTel1.Name = "txtObsTel1";
            this.txtObsTel1.Size = new System.Drawing.Size(147, 27);
            this.txtObsTel1.TabIndex = 6;
            this.txtObsTel1.Visible = false;
            // 
            // txtRg
            // 
            this.txtRg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRg.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRg.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRg.Location = new System.Drawing.Point(133, 82);
            this.txtRg.MaxLength = 15;
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(125, 27);
            this.txtRg.TabIndex = 1;
            this.txtRg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRg_KeyDown);
            this.txtRg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRg_KeyPress);
            // 
            // txtNome
            // 
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(133, 49);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(394, 27);
            this.txtNome.TabIndex = 0;
            // 
            // lblDataNasc
            // 
            this.lblDataNasc.AutoSize = true;
            this.lblDataNasc.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataNasc.Location = new System.Drawing.Point(9, 122);
            this.lblDataNasc.Name = "lblDataNasc";
            this.lblDataNasc.Size = new System.Drawing.Size(118, 20);
            this.lblDataNasc.TabIndex = 60;
            this.lblDataNasc.Text = "Data de Nasc.:";
            // 
            // lblEmissaoRg
            // 
            this.lblEmissaoRg.AutoSize = true;
            this.lblEmissaoRg.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmissaoRg.Location = new System.Drawing.Point(342, 89);
            this.lblEmissaoRg.Name = "lblEmissaoRg";
            this.lblEmissaoRg.Size = new System.Drawing.Size(32, 20);
            this.lblEmissaoRg.TabIndex = 62;
            this.lblEmissaoRg.Text = "UF:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(48, 156);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(79, 20);
            this.lblTelefone.TabIndex = 63;
            this.lblTelefone.Text = "Telefone:";
            // 
            // lblRg
            // 
            this.lblRg.AutoSize = true;
            this.lblRg.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRg.Location = new System.Drawing.Point(93, 90);
            this.lblRg.Name = "lblRg";
            this.lblRg.Size = new System.Drawing.Size(34, 20);
            this.lblRg.TabIndex = 61;
            this.lblRg.Text = "RG:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(69, 56);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(58, 20);
            this.lblNome.TabIndex = 64;
            this.lblNome.Text = "Nome:";
            // 
            // frmCadastroSimplesAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 337);
            this.Controls.Add(this.pnlFormulario);
            this.Controls.Add(this.pnlTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCadastroSimplesAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCadastroSimplesAluno";
            this.Load += new System.EventHandler(this.frmCadastroSimplesAluno_Load);
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.pnlFormulario.ResumeLayout(false);
            this.pnlFormulario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Panel pnlFormulario;
        private System.Windows.Forms.ComboBox cmbEmissao;
        private System.Windows.Forms.ComboBox cmbTipoTel1;
        private System.Windows.Forms.MaskedTextBox mskDataNasc;
        private System.Windows.Forms.MaskedTextBox mskTelefone1;
        private System.Windows.Forms.TextBox txtObsTel1;
        private System.Windows.Forms.TextBox txtRg;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblDataNasc;
        private System.Windows.Forms.Label lblEmissaoRg;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblRg;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Label lblObservacao;
        private System.Windows.Forms.Label lblSair;
    }
}
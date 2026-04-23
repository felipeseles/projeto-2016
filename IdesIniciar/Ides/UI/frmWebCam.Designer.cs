namespace Ides.UI
{
    partial class frmWebCam
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
            this.lblTituloWebCam = new System.Windows.Forms.Label();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.pnlFormulario = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.ptbCaptura = new System.Windows.Forms.PictureBox();
            this.pnlTitulo.SuspendLayout();
            this.pnlFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCaptura)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloWebCam
            // 
            this.lblTituloWebCam.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTituloWebCam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloWebCam.ForeColor = System.Drawing.Color.White;
            this.lblTituloWebCam.Location = new System.Drawing.Point(0, 0);
            this.lblTituloWebCam.Name = "lblTituloWebCam";
            this.lblTituloWebCam.Size = new System.Drawing.Size(206, 34);
            this.lblTituloWebCam.TabIndex = 7;
            this.lblTituloWebCam.Text = "WebCan";
            this.lblTituloWebCam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTituloWebCam.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblTituloWebCam_MouseDown);
            this.lblTituloWebCam.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblTituloWebCam_MouseMove);
            this.lblTituloWebCam.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblTituloWebCam_MouseUp);
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.DarkBlue;
            this.pnlTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTitulo.Controls.Add(this.lblTituloWebCam);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(398, 36);
            this.pnlTitulo.TabIndex = 13;
            this.pnlTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblTituloWebCam_MouseDown);
            this.pnlTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblTituloWebCam_MouseMove);
            this.pnlTitulo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblTituloWebCam_MouseUp);
            // 
            // pnlFormulario
            // 
            this.pnlFormulario.BackColor = System.Drawing.Color.White;
            this.pnlFormulario.Controls.Add(this.btnCancelar);
            this.pnlFormulario.Controls.Add(this.btnStart);
            this.pnlFormulario.Controls.Add(this.btnGravar);
            this.pnlFormulario.Controls.Add(this.ptbCaptura);
            this.pnlFormulario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFormulario.Location = new System.Drawing.Point(0, 0);
            this.pnlFormulario.Name = "pnlFormulario";
            this.pnlFormulario.Size = new System.Drawing.Size(398, 377);
            this.pnlFormulario.TabIndex = 14;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.DarkBlue;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(270, 343);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(124, 32);
            this.btnCancelar.TabIndex = 129;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.DarkBlue;
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(135, 343);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(124, 32);
            this.btnStart.TabIndex = 129;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.BackColor = System.Drawing.Color.DarkBlue;
            this.btnGravar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGravar.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravar.ForeColor = System.Drawing.Color.White;
            this.btnGravar.Location = new System.Drawing.Point(5, 343);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(124, 32);
            this.btnGravar.TabIndex = 129;
            this.btnGravar.Text = "CAPTURAR";
            this.btnGravar.UseVisualStyleBackColor = false;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // ptbCaptura
            // 
            this.ptbCaptura.BackColor = System.Drawing.SystemColors.Control;
            this.ptbCaptura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbCaptura.Location = new System.Drawing.Point(0, 0);
            this.ptbCaptura.Name = "ptbCaptura";
            this.ptbCaptura.Size = new System.Drawing.Size(396, 337);
            this.ptbCaptura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbCaptura.TabIndex = 0;
            this.ptbCaptura.TabStop = false;
            // 
            // frmWebCam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 377);
            this.Controls.Add(this.pnlTitulo);
            this.Controls.Add(this.pnlFormulario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmWebCam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmWebCam";
            this.pnlTitulo.ResumeLayout(false);
            this.pnlFormulario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbCaptura)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTituloWebCam;
        private System.Windows.Forms.PictureBox ptbCaptura;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Panel pnlFormulario;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnGravar;
    }
}
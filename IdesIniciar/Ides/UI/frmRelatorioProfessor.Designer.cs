namespace Ides.UI
{
    partial class frmRelatorioProfessor
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.PROFESSORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsRelatorios = new Ides.UI.dsRelatorios();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lblMaximizar = new System.Windows.Forms.Label();
            this.lblSair = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PROFESSORBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRelatorios)).BeginInit();
            this.pnlTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // PROFESSORBindingSource
            // 
            this.PROFESSORBindingSource.DataMember = "PROFESSOR";
            this.PROFESSORBindingSource.DataSource = this.dsRelatorios;
            // 
            // dsRelatorios
            // 
            this.dsRelatorios.DataSetName = "dsRelatorios";
            this.dsRelatorios.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.PROFESSORBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Ides.UI.rptProfessor.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(2, 38);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(867, 621);
            this.reportViewer1.TabIndex = 0;
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
            this.pnlTitulo.Size = new System.Drawing.Size(872, 36);
            this.pnlTitulo.TabIndex = 17;
            this.pnlTitulo.DoubleClick += new System.EventHandler(this.pnlTitulo_DoubleClick);
            this.pnlTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblTitulo_MouseDown);
            this.pnlTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblTitulo_MouseMove);
            this.pnlTitulo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblTitulo_MouseUp);
            // 
            // lblMaximizar
            // 
            this.lblMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMaximizar.AutoSize = true;
            this.lblMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMaximizar.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaximizar.ForeColor = System.Drawing.Color.White;
            this.lblMaximizar.Location = new System.Drawing.Point(802, -10);
            this.lblMaximizar.Name = "lblMaximizar";
            this.lblMaximizar.Size = new System.Drawing.Size(41, 47);
            this.lblMaximizar.TabIndex = 9;
            this.lblMaximizar.Text = "□";
            this.toolTip1.SetToolTip(this.lblMaximizar, "Maximizar / Restaurar");
            this.lblMaximizar.Click += new System.EventHandler(this.lblMaximizar_Click);
            // 
            // lblSair
            // 
            this.lblSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSair.AutoSize = true;
            this.lblSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSair.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSair.ForeColor = System.Drawing.Color.White;
            this.lblSair.Location = new System.Drawing.Point(835, 0);
            this.lblSair.Name = "lblSair";
            this.lblSair.Size = new System.Drawing.Size(35, 37);
            this.lblSair.TabIndex = 8;
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
            this.lblTitulo.Text = "Relatorio Professor";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblTitulo_MouseDown);
            this.lblTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblTitulo_MouseMove);
            this.lblTitulo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblTitulo_MouseUp);
            // 
            // frmRelatorioProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 661);
            this.Controls.Add(this.pnlTitulo);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRelatorioProfessor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRelatorioProfessor";
            this.Load += new System.EventHandler(this.frmRelatorioProfessor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PROFESSORBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRelatorios)).EndInit();
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PROFESSORBindingSource;
        private dsRelatorios dsRelatorios;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label lblMaximizar;
        private System.Windows.Forms.Label lblSair;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
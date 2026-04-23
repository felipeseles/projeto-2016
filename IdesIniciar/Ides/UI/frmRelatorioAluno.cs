using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ides.UI
{
    public partial class frmRelatorioAluno : Form
    {
        //variaveis usadas para mover painel
        private bool mover;
        private int cX, cY;

        public frmRelatorioAluno()
        {
            InitializeComponent();
        }

        // -------------------- INICIAR O FORMULÁRIO --------------------

        private void frmRelatorioAluno_Load(object sender, EventArgs e)
        {
            DAL.RelatorioDAL rDAL = new DAL.RelatorioDAL();
            rDAL.RelatorioAlunos().Fill(dsRelatorios.ALUNO);
            this.reportViewer1.RefreshReport();
        }

        // -------------------- FECHAR O FORMULÁRIO --------------------


        private void lblSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        // -------------------- MAXIMIZAR --------------------

        private void lblMaximizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void pnlTitulo_DoubleClick(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        // -------------------- MOVER A BARA DE TAREFAS --------------------

        private void lblTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            //Este método também esta sendo utilizado no pnlTitulo
            if (e.Button == MouseButtons.Left)
            {
                cX = e.X;
                cY = e.Y;
                mover = true;
            }
        }

        private void lblTitulo_MouseUp(object sender, MouseEventArgs e)
        {
            //Este método também esta sendo utilizado no pnlTitulo
            if (e.Button == MouseButtons.Left)
                mover = false;
        }

        private void lblTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            //Este método também esta sendo utilizado no pnlTitulo
            if (mover)
            {
                this.Left += e.X - (cX - pnlTitulo.Left);
                this.Top += e.Y - (cY - pnlTitulo.Top);
            }
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        
    }
}

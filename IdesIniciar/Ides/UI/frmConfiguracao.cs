using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ides.Properties;
using System.IO;
using System.Drawing.Imaging;


namespace Ides.UI
{
    public partial class frmConfiguracao : Form
    {
        //variaveis usadas para mover painel
        private bool mover;
        private int cX, cY;
        DAL.BackupDAL bkp = new DAL.BackupDAL();//instancia a classe

        public frmConfiguracao()
        {
            InitializeComponent();
        }

        // ------------------------------ MENSAGEM ----------------------------
        public string Mensagem(string mensagem, string foto)
        {
            frmMensagem m = new frmMensagem();
            m.mensagem = mensagem;
            m.foto = foto;
            m.ShowDialog();
            return m.sn;
        }
        // ------------------------------ FECHAR FORMULÁRIO ----------------------------
        private void lblSair_Click(object sender, EventArgs e)
        {
            Close();
        }

         //------------------------------ MOVER O FORMULÁRIO ----------------------------
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

        private void lblTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            //Este método também esta sendo utilizado no pnlTitulo
            if (mover)
            {
                this.Left += e.X - (cX - pnlTitulo.Left);
                this.Top += e.Y - (cY - pnlTitulo.Top);
            }
        }

        private void lblTitulo_MouseUp(object sender, MouseEventArgs e)
        {
            //Este método também esta sendo utilizado no pnlTitulo
            if (e.Button == MouseButtons.Left)
                mover = false;
        }

        private void btnEfetuarBackup_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    bkp.GerarBackup(saveFileDialog1.FileName);
                    Mensagem("Backup efetuado com sucesso!", "ok");
                }
            }
            catch
            {
                Mensagem("O Backup deve ser realizado em uma mídia externa", "warning");
            }
        }

        private void btnRestaurarBackup_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                bkp.RestaurarBackup(openFileDialog1.FileName);
                Mensagem("Backup restaurado com sucesso!", "ok");

            }

        }
    }
}

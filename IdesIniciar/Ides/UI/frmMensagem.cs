using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ides.Properties; //necessario para pegar a imagem da pasta Resources para funcionar na mensagem

namespace Ides.UI
{
    public partial class frmMensagem : Form
    {
        public string mensagem { get; set; }
        public string foto { get; set; }
        public string sn { get; set; }

        private bool mover;
        private int cX, cY;

        public frmMensagem()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMensagem_Load(object sender, EventArgs e)
        {
            lblMensagem.Text = mensagem;
            if (foto == "ok")
                ptbImagem.Image = Resources.ok;
            else if (foto == "error")
                ptbImagem.Image = Resources.error;
            else if (foto == "warning")
                ptbImagem.Image = Resources.warning;
            else
            {
                ptbImagem.Image = Resources.question;
                btnNao.Visible = true;
                btnOk.Text = "SIM";
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            sn = "sim";
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                cX = e.X;
                cY = e.Y;
                mover = true;
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                mover = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mover)
            {
                this.Left += e.X - (cX - panel1.Left);
                this.Top += e.Y - (cY - panel1.Top);
            }
        }

        private void btnNao_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

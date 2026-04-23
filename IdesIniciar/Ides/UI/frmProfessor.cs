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

namespace Ides.UI
{
    public partial class frmProfessor : Form
    {
        private bool mover;
        private int cX, cY;

        public frmProfessor()
        {
            InitializeComponent();
        }

        public string Mensagem(string mensagem, string foto)
        {
            UI.frmMensagem m = new UI.frmMensagem();
            m.mensagem = mensagem;
            m.foto = foto;
            m.ShowDialog();
            return m.sn;
        }

        private void label4_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                cX = e.X;
                cY = e.Y;
                mover = true;
            }
        }

        private void label4_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                mover = false;
        }

        private void label4_MouseMove(object sender, MouseEventArgs e)
        {
            if (mover)
            {
                this.Left += e.X - (cX - pnlProfessor.Left);
                this.Top += e.Y - (cY - pnlProfessor.Top);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnBuscaCep_Click(object sender, EventArgs e)
        {
            if (!mskCep.MaskFull)
            {
                //MessageBox.Show("PREENCHA OS NUMEROS DO CEP!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Mensagem("PREENCHA OS NUMEROS DO CEP!", "warning");
                mskCep.Focus();
                return;
            }
            Utilidades.SPERA.BuscarCEP(mskCep.Text);
            txtEndereco.Text = Utilidades.SPERA.tipologradouro + " " + Utilidades.SPERA.logradouro;
            txtBairro.Text = Utilidades.SPERA.bairro;
            txtCidade.Text = Utilidades.SPERA.cidade;

            if (txtEndereco.Text != "" && txtBairro.Text != "" && txtCidade.Text != "")
            {
                txtNumero.Focus();
            }
            else
            {
                txtEndereco.Focus();
                txtEndereco.Clear();
            }
        }

        private void mskCpf_KeyUp(object sender, KeyEventArgs e)
        {
            if (mskCpf.MaskFull)
            {
                if (Utilidades.SPERA.ValidarCPF(mskCpf.Text))
                    ptbCpf.Image = Resources.ok_cpf;
                else
                    ptbCpf.Image = Resources.erro_cpf;
            }
            else if (mskCpf.Text.Trim() == "")
            {
                ptbCpf.Image = Resources.erro_cpf;
            }
            else
            {
                ptbCpf.Image = Resources.erro_cpf;
            }
        }
    }
}

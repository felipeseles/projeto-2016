using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ides
{
    public partial class frmLogin : Form
    {
        BLL.UsuarioBLL usuarioBLL = new BLL.UsuarioBLL();
        DAL.UsuarioDAL usuarioDAL = new DAL.UsuarioDAL();

        public bool logado { get; set; }
        private bool mover;
        private int cX, cY;
        public frmLogin()
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

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                cX = e.X;
                cY = e.Y;
                mover = true;
            }
        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                mover = false;
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mover)
            {
                this.Left += e.X - (cX - panel1.Left);
                this.Top += e.Y - (cY - panel1.Top);
            }
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntar_Click(object sender, EventArgs e)
        {
            usuarioBLL.Nomeusuario = txtUsuario.Text;
            usuarioBLL.Senha = txtSenha.Text;

            usuarioBLL = usuarioDAL.Logar(usuarioBLL);
            if (usuarioBLL.Codusuario == 0)
            {
                logado = false; //não conseguiu

                Mensagem("Usuário ou Senha inválidos!", "error");
                txtUsuario.Clear();
                txtSenha.Clear();
                txtUsuario.Focus();

                //MessageBox.Show("Usuário ou Senha inválidos!");
            }
            else
            {
                logado = true; //conseguiu
                Close(); //fechando form de login
            }

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

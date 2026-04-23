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
    public partial class frmCadastroUsuario : Form
    {

        private bool mover;
        private int cX, cY;

        //referencias para as classes
        BLL.UsuarioBLL usuarioBLL = new BLL.UsuarioBLL();
        DAL.UsuarioDAL usuarioDAL = new DAL.UsuarioDAL();
        public bool alterar { get; set; }

        public string Mensagem(string mensagem, string foto)
        {
            frmMensagem m = new frmMensagem();
            m.mensagem = mensagem;
            m.foto = foto;
            m.ShowDialog();
            return m.sn;
        }

        public void LimparControles()
        {
            foreach (Control controles in panel2.Controls)
            {
                if (controles is TextBox)
                {
                    (controles as TextBox).Text = "";
                }
                else if (controles is ComboBox)
                {
                    (controles as ComboBox).SelectedIndex = -1;
                }
                else if (controles is MaskedTextBox)
                {
                    (controles as MaskedTextBox).Text = "";
                }

            }
        }

        public frmCadastroUsuario()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            //if (txtNome.Text.Trim() == "")
            //{
            //    Mensagem("Você deve preencher o campo nome!", "warning"); return; 
            //}
            //if (txtSobrenome.Text.Trim() == "")
            //{
            //     Mensagem("Você deve preencher o campo sobrenome!", "warning"); return;
            //}
            //if (cmbSexo.Text.Trim() == "")
            //{
            //     Mensagem("Você deve preencher o campo sexo!", "warning"); return;
            //}
            //if (txtNomeUsuario.Text.Trim() == "")
            //{
            //    Mensagem("Você deve preencher o campo nome usuário!", "warning"); return;
            //}
            //if (txtSenha.Text.Trim() == "")
            //{
            //    Mensagem("Você deve preencher o campo senha!", "warning"); return;
            //}
            //if (cmbTipo.Text.Trim() == "")
            //{
            //    Mensagem("Você deve preencher o campo tipo de usuário!", "warning"); return;
            //}

            //if (txtNome.Text.Trim() == "" && txtSobrenome.Text.Trim() == "" && !mskCpf.MaskFull && cmbSexo.Text.Trim() == "" && txtNomeUsuario.Text.Trim() == "" && txtSenha.Text.Trim() == "" && txtConfirmarSenha.Text.Trim() == "" && cmbTipo.Text.Trim() == "")
            //{

            //}

            //if (txtNome.Text.Trim() == "" && txtSobrenome.Text.Trim() == "" && !mskCpf.MaskFull && cmbSexo.Text.Trim() == "" && txtNomeUsuario.Text.Trim() == "" && txtSenha.Text.Trim() == "" && txtConfirmarSenha.Text.Trim() == "" && cmbTipo.Text.Trim() == "")
            //{
            //    Mensagem("PREENCHA TODOS OS CAMPOS!", "warning");
            //    return;
            //}
            

            //else if (ptbCpf.Image == Resources.erro_cpf)
            //{
            //    Mensagem("CPF inválido!", "warning");
            //    return;
            //}

            //else if (mskCpf.Text == usuarioBLL.Cpf)
            //{
            //    Mensagem("Já existe um usuário cadastrado com o mesmo CPF", "warning");
            //    return;
            //}
            
            

            try
            {
                
                
                if (txtNome.Text.Trim() == "" || txtSobrenome.Text.Trim() == "" || !mskCpf.MaskFull || cmbSexo.Text.Trim() == "" || txtNomeUsuario.Text.Trim() == "" || txtSenha.Text.Trim() == "" || txtConfirmarSenha.Text.Trim() == "" || cmbTipo.Text.Trim() == "")
                {
                    Mensagem("PREENCHA TODOS OS CAMPOS!", "warning");
                    return;
                }

              
                if (mskCpf.MaskFull)
                {
                    if (Utilidades.SPERA.ValidarCPF(mskCpf.Text))
                        ptbCpf.Image = Resources.ok_cpf;
                    else
                    {
                        Mensagem("Insira um CPF válido!", "error");
                        mskCpf.Clear();
                        mskCpf.Focus();
                        return;
                    }
                    
                }
                
           
            if (mskCpf.Text == usuarioBLL.Cpf)
            {
                Mensagem("Já existe um usuário cadastrado com o mesmo CPF", "warning");
                return;
            }
            
            if (txtSenha.Text != txtConfirmarSenha.Text)
            {
                Mensagem("O campo senha não bate com a confirmação", "warning");
                txtSenha.Clear();
                txtConfirmarSenha.Clear();
                txtSenha.Focus();
                return;
            }

                //passar valores para as variáveis
                usuarioBLL.Nome = txtNome.Text;
                usuarioBLL.Sobrenome = txtSobrenome.Text;
                usuarioBLL.Sexo = cmbSexo.Text;
                usuarioBLL.Cpf = mskCpf.Text;
                usuarioBLL.Nomeusuario = txtNomeUsuario.Text;
                usuarioBLL.Senha = txtSenha.Text;
                usuarioBLL.Acesso = cmbTipo.Text;
                if (alterar == false)
                {
                    usuarioDAL.Cadastrar(usuarioBLL);
                }
                else
                {
                    usuarioDAL.Alterar(usuarioBLL);
                    Close(); //fechar formulario
                }

                //exibir mensagem de confirmação
                Mensagem("DADOS GRAVADOS COM SUCESSO!", "ok");
                LimparControles();
                txtNome.Focus();

            }
            catch
            {

                //MessageBox.Show("PREENCHA OS CAMPOS OBRIGATÓRIOS!", "GRAVAR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Mensagem("PREENCHA TODOS OS CAMPOS!", "warning");
                return;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
                this.Left += e.X - (cX - panel1.Left);
                this.Top += e.Y - (cY - panel1.Top);
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

        private void mskCpf_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                return;
            }
        }

        private void txtNomeUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                return;
            }
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                return;
            }
        }

        private void txtConfirmarSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                return;
            }
        }
    }
}

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
    public partial class frmCadastroUsuario : Form
    {
        //referencias para as classes
        BLL.UsuarioBLL usuarioBLL = new BLL.UsuarioBLL();
        DAL.UsuarioDAL usuarioDAL = new DAL.UsuarioDAL();

       

        // variaveis usadas para alteração
        public bool alterar { get; set; }
        public int mostrar { get; set; }
        public int codusuario { get; set; }
        

        //variaveis usadas para mover painel
        private bool mover;
        private int cX, cY;

        

        

        public frmCadastroUsuario()
        {
            InitializeComponent();
            
        }

        // ------------------------------ LOAD DO FORMULÁRIO ------------------------------

        private void frmCadastroUsuario_Load(object sender, EventArgs e)
        {
            if (mostrar == 1)
            {
                mskCpf.Enabled = false;
                ptbCpf.Image = Resources.ok_cpf;
                cmbSexo.Enabled = false;
                txtNomeUsuario.Enabled = false;
                cmbTipo.Enabled = false;
            }

            if (alterar == true)
            {
                usuarioBLL.Codusuario = BLL.UsuarioBLL.codigousu;
                usuarioBLL = usuarioDAL.RetornarDados(usuarioBLL);

                txtNome.Text = usuarioBLL.Nome;
                txtSobrenome.Text = usuarioBLL.Sobrenome;
                mskCpf.Text = usuarioBLL.Cpf;
                cmbSexo.Text = usuarioBLL.Sexo;
                txtEmail.Text = usuarioBLL.Email;
                txtNomeUsuario.Text = usuarioBLL.Nomeusuario;
                txtSenha.Text = usuarioBLL.Senha;
                txtConfirmarSenha.Text = usuarioBLL.Senha;
                cmbTipo.Text = usuarioBLL.Acesso;

                if (txtSenha.Text != txtConfirmarSenha.Text)
                {
                    Mensagem("O campo senha não bate com a confirmação", "warning");
                    txtSenha.Clear();
                    txtConfirmarSenha.Clear();
                    txtSenha.Focus();
                    return;
                }

            }
        }

        // ------------------------------ MOVER PAINEL ------------------------------

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

        // ------------------------------ MENSAGEM ------------------------------

        public string Mensagem(string mensagem, string foto)
        {
            frmMensagem m = new frmMensagem();
            m.mensagem = mensagem;
            m.foto = foto;
            m.ShowDialog();
            return m.sn;
        }

        // ---------------------------- METODO LIMPAR CAMPOS ---------------------------

        public void LimparControles()
        {
            foreach (Control controles in pnlFormulario.Controls)
            {
                if (controles is TextBox)
                {
                    (controles as TextBox).Text = "";
                }
                else if (controles is MaskedTextBox)
                {
                    (controles as MaskedTextBox).Text = "";
                }
                else if (controles is ComboBox)
                {
                    (controles as ComboBox).SelectedIndex = -1;
                }
            }
        }

        // ---------------------------- METODO BLOQUEAR ESPAÇO -------------------------

        private void mskCpf_KeyDown(object sender, KeyEventArgs e)
        {
            //Este método também esta sendo utilizado no txtEmail, txtNomeUsuario, txtSenha, txtConfirmarSenha
            if (e.KeyCode == Keys.Space)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                return;
            }
        }

        // ---------------------- METODO PERMITIR APENAS NÚMEROS -------------------------



        // -------------------------- CAPTURAR IMAGEM E WEB CAM -------------------------

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            Mensagem("AINDA SEM PROGRAMAR!", "warning");
            return;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Mensagem("AINDA SEM PROGRAMAR!", "warning");
            return;

            //if (openFileDialog1.ShowDialog() == DialogResult.OK)
            //{
            //    //exibir a imagem no formulário
            //    string nomeArquivo = openFileDialog1.FileName;
            //    Bitmap bmp = new Bitmap(nomeArquivo);
            //    pctUsuario.Image = bmp;

            //    //Salvar no Banco de Dados
            //    MemoryStream ms = new MemoryStream();
            //    bmp.Save(ms, ImageFormat.Bmp);

            //    byte[] foto = ms.ToArray();

            //} 
        }
        // -------------------------- TRATAMENTO DO CPF -------------------------

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

        // ---------------------------- GRAVAR DADOS -------------------------


        private void btnGravar_Click(object sender, EventArgs e)
        {

                if (txtNome.Text.Trim() != "" && txtSobrenome.Text.Trim() != "" && mskCpf.MaskFull && cmbSexo.Text.Trim() != "" &&
                    txtNomeUsuario.Text.Trim() != "" && txtSenha.Text.Trim() != "" && txtConfirmarSenha.Text.Trim() != "" && cmbTipo.Text.Trim() != "")
                {

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
                    usuarioBLL.Cpf = mskCpf.Text;
                    usuarioBLL.Sexo = cmbSexo.Text;
                    usuarioBLL.Email = txtEmail.Text;
                    usuarioBLL.Nomeusuario = txtNomeUsuario.Text;
                    usuarioBLL.Senha = txtSenha.Text;
                    usuarioBLL.Acesso = cmbTipo.Text;
                    //usuarioBLL.Foto = pctUsuario.Image.ToString();

                    if (usuarioDAL.VerificaCpf(usuarioBLL) > 0 && alterar == false)
                    {
                        Mensagem("JÁ EXISTE UM USUARIO CADASTRADO COM ESTE CPF!", "warning");
                        mskCpf.Clear();
                        mskCpf.Focus();
                        ptbCpf.Image = Resources.erro_cpf;
                        return;
                    }


                    if (alterar == false)
                    {
                        usuarioDAL.Cadastrar(usuarioBLL);
                        //exibir mensagem de confirmação
                        Mensagem("DADOS GRAVADOS COM SUCESSO!", "ok");
                        LimparControles();
                        txtNome.Focus();
                        return;
                    }
                    else
                    {
                        usuarioDAL.Alterar(usuarioBLL);
                        Mensagem("DADOS GRAVADOS COM SUCESSO!", "ok");
                        //Close(); //fechar formulario
                        frmTelaPrincipal logout = new frmTelaPrincipal();
                        logout.ShowDialog();
                        
                    }

                    
                }

                else
                {
                    Mensagem("PREENCHA TODOS OS CAMPOS!", "warning");
                    return;
                }

        }


        // ---------------------------- FECHAR FORMULÁRIO -------------------------

        private void lblSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

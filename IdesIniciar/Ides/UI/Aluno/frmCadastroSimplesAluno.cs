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

namespace Ides.UI.Aluno
{
    public partial class frmCadastroSimplesAluno : Form
    {
        //referencias para as classes
        BLL.AlunoBLL alunoBLL = new BLL.AlunoBLL();
        DAL.AlunoDAL alunoDAL = new DAL.AlunoDAL();

        //variaveis usadas para alterar
        public bool alterar { get; set; }
        private bool mover;
        private int cX, cY;

        public frmCadastroSimplesAluno()
        {
            InitializeComponent();
        }

        // ------------------------------ LOAD DO FORMULÁRIO ------------------------------

        private void frmCadastroSimplesAluno_Load(object sender, EventArgs e)
        {
            txtNome.Focus();
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
            UI.frmMensagem m = new UI.frmMensagem();
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

        // ---------------------------- METODO BLOQUEAR ESPAÇO --------------------------

        private void txtRg_KeyDown(object sender, KeyEventArgs e)
        {
            //Este método também esta sendo utilizado no mskDataNasc e mskTelefone1
            if (e.KeyCode == Keys.Space)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                return;
            }
        }

        // ----------------------- METODO BLOQUEAR PONTUAÇÃO E SIMBOLOS -----------------------

        private void txtRg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSymbol(e.KeyChar))
                e.Handled = true;
            else if (char.IsPunctuation(e.KeyChar))
                e.Handled = true;

        }

        // -------------------------- TRATAMENTO DE ERROS TELEFONE ------------------------

        private void cmbTipoTel1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoTel1.Text == "Recado Cel." || cmbTipoTel1.Text == "Recado Res.")
            {
                txtObsTel1.Visible = true;

            }
            else
            {
                txtObsTel1.Visible = false;

            }

            if (cmbTipoTel1.Text == "Residencial" || cmbTipoTel1.Text == "Recado Res.")
            {
                mskTelefone1.Mask = "(00)0000-0000";
                mskTelefone1.Clear();
                txtObsTel1.Clear();
                mskTelefone1.Focus();
            }
            else if (cmbTipoTel1.Text == "Celular" || cmbTipoTel1.Text == "Recado Cel.")
            {
                mskTelefone1.Mask = "(00)00000-0000";
                mskTelefone1.Clear();
                txtObsTel1.Clear();
                mskTelefone1.Focus();
            }
        }

        // ---------------------------- GRAVAR -------------------------

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNome.Text.Trim() != "" && txtRg.Text.Trim() != "" && cmbEmissao.Text != "" &&
                    mskDataNasc.MaskFull && cmbTipoTel1.Text != "" && mskTelefone1.MaskFull)

                    
                
                    //PASSAR VALORES PARA AS VARIÁVEIS
                    alunoBLL.Nome = txtNome.Text;
                    alunoBLL.Rg = txtRg.Text;
                    alunoBLL.Emissao = cmbEmissao.Text;
                    alunoBLL.Datanasc = DateTime.Parse(mskDataNasc.Text);
                    alunoBLL.Tipotel1 = cmbTipoTel1.Text;
                    alunoBLL.Telefone1 = mskTelefone1.Text;
                    alunoBLL.Observacaotel1 = txtObsTel1.Text;

                    if (alterar == false)
                    {
                        alunoDAL.CadastrarSimples(alunoBLL);
                    }
                    else
                    {
                        alunoDAL.AlterarSimples(alunoBLL);
                        Close(); //fechar formulario
                    }

                    //exibir mensagem de confirmação
                    Mensagem("DADOS GRAVADOS COM SUCESSO!", "ok");
                    LimparControles();
                    txtNome.Focus();
            }
            catch
            {
                Mensagem("PREENCHA OS CAMPOS OBRIGATÓRIOS!", "warning");
                return;
            }
            
        }


        // ---------------------------- FECHAR FORMULÁRIO -------------------------

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        

    }
}

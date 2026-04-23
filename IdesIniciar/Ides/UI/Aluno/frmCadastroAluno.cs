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
    public partial class frmCadastroAluno : Form
    {
        //referencias para as classes
        BLL.AlunoBLL alunoBLL = new BLL.AlunoBLL();
        DAL.AlunoDAL alunoDAL = new DAL.AlunoDAL();

        BLL.TurmaBLL tBLL = new BLL.TurmaBLL();
        DAL.TurmaDAL tDAL = new DAL.TurmaDAL();

        // variaveis usadas para alteração
        public int codaluno { get; set; }
        public bool alterar { get; set; }
        public int mostrar { get; set; }

        //variaveis usadas para mover painel
        private bool mover;
        private int cX, cY;

        public frmCadastroAluno()
        {
            InitializeComponent();

            
        }


        // ------------------------------ LOAD DO FORMULÁRIO ------------------------------
        
        
        private void frmCadastroAluno_Load(object sender, EventArgs e)
        {
            //dgvConsultaCursoAluno.DataSource = tDAL.ConsultarCursoAluno();
            if (mostrar == 1)
            {
                tpgCadAluno.Enabled = false;
                tpgCadCursos.Enabled = false;

                if (mskCpf.MaskFull)
                {
                    ptbCpf.Image = Resources.ok_cpf;
                }
                else
                {
                    ptbCpf.Image = Resources.erro_cpf;
                }
            }

            if (alterar == true)
            {
                alunoBLL.Codaluno = codaluno;
                alunoBLL = alunoDAL.RetornarDados(alunoBLL);

                txtNome.Text = alunoBLL.Nome;
                txtRg.Text = alunoBLL.Rg;
                cmbEmissao.Text = alunoBLL.Emissao;
                mskDataNasc.Text = alunoBLL.Datanasc.ToString();
                mskCpf.Text = alunoBLL.Cpf;
                txtFiliacaoMae.Text = alunoBLL.Filiacaomae;
                txtFiliacaoPai.Text = alunoBLL.Filiacaopai;
                mskCep.Text = alunoBLL.Cep;
                txtEndereco.Text = alunoBLL.Endereco;
                txtNumero.Text = alunoBLL.Numero;
                txtComplemento.Text = alunoBLL.Complemento;
                txtBairro.Text = alunoBLL.Bairro;
                txtCidade.Text = alunoBLL.Cidade;
                cmbEstado.Text = alunoBLL.Estado;
                cmbTipoTel1.Text = alunoBLL.Tipotel1;
                mskTelefone1.Text = alunoBLL.Telefone1;
                txtObsTel1.Text = alunoBLL.Observacaotel1;
                cmbTipoTel2.Text = alunoBLL.Tipotel2;
                mskTelefone2.Text = alunoBLL.Telefone2;
                txtObsTel2.Text = alunoBLL.Observacaotel2;
                cmbTipoTel3.Text = alunoBLL.Tipotel3;
                mskTelefone3.Text = alunoBLL.Telefone3;
                txtObsTel3.Text = alunoBLL.Observacaotel3;
                txtEmail.Text = alunoBLL.Email;

                txtRg.Enabled = false;
                cmbEmissao.Enabled = false;
                mskDataNasc.Enabled = false;
                if (mskCpf.MaskFull)
                {
                    mskCpf.Enabled = false;
                    ptbCpf.Image = Resources.ok_cpf;
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

        // ---------------------------- METODO BLOQUEAR ESPAÇO -------------------------

        private void txtRg_KeyDown(object sender, KeyEventArgs e)
        {
            /*      Este método também esta sendo utilizado nos campos:
mskDataNasc, mskCpf, mskCep, txtNumero, mskTelefone1, mskTelefone2, mskTelefone3, txtEmail     */
            if (e.KeyCode == Keys.Space)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                return;
            }
        }


        // ---------------------- METODO PERMITIR APENAS NÚMEROS -------------------------

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
                e.Handled = true;
            else if (char.IsSymbol(e.KeyChar))
                e.Handled = true;
            else if (char.IsPunctuation(e.KeyChar))
                e.Handled = true;
        }

        // -------------------------- CAPTURAR IMAGEM E WEB CAM -------------------------

        private void pctUsuario_Click(object sender, EventArgs e)
        {
            //videoSource.Start();
        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            Mensagem("AINDA SEM PROGRAMAR!", "warning");
            return;
            //pctUsuario.Image.Save(string.Format("snapshot-{0}.png", contador++), System.Drawing.Imaging.ImageFormat.Png);
            //videoSource.SignalToStop();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Mensagem("AINDA SEM PROGRAMAR!", "warning");
            return;
        }

        // -------------------------- TRATAMENTO DO CEP -------------------------

        private void btnBuscaCep_Click_1(object sender, EventArgs e)
        {
            if (!mskCep.MaskFull)
            {
                Mensagem("PREENCHA OS NUMEROS DO CEP!", "warning");
                mskCep.Focus();
                return;
            }
            Utilidades.SPERA.BuscarCEP(mskCep.Text);
            txtEndereco.Text = Utilidades.SPERA.tipologradouro + " " + Utilidades.SPERA.logradouro;
            txtBairro.Text = Utilidades.SPERA.bairro;
            txtCidade.Text = Utilidades.SPERA.cidade;
            cmbEstado.Text = Utilidades.SPERA.uf;

            if (txtEndereco.Text != "" && txtBairro.Text != "" && txtCidade.Text != "" && cmbEstado.Text != "")
            {
                txtNumero.Focus();
            }
            else
            {
                txtEndereco.Focus();
                txtEndereco.Clear();
            }
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

        private void cmbTipoTel2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoTel2.Text == "Recado Cel." || cmbTipoTel2.Text == "Recado Res.")
            {
                txtObsTel2.Visible = true;
            }
            else
            {
                txtObsTel2.Visible = false;
            }

            if (cmbTipoTel2.Text == "Residencial" || cmbTipoTel2.Text == "Recado Res.")
            {
                mskTelefone2.Mask = "(00)0000-0000";
                mskTelefone2.Clear();
                txtObsTel2.Clear();
                mskTelefone2.Focus();
            }
            else if (cmbTipoTel2.Text == "Celular" || cmbTipoTel2.Text == "Recado Cel.")
            {
                mskTelefone2.Mask = "(00)00000-0000";
                mskTelefone2.Clear();
                txtObsTel2.Clear();
                mskTelefone2.Focus();
            }
        }

        private void cmbTipoTel3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoTel3.Text == "Recado Cel." || cmbTipoTel3.Text == "Recado Res.")
            {
                txtObsTel3.Visible = true;
            }
            else
            {
                txtObsTel3.Visible = false;
            }

            if (cmbTipoTel3.Text == "Residencial" || cmbTipoTel3.Text == "Recado Res.")
            {
                mskTelefone3.Mask = "(00)0000-0000";
                mskTelefone3.Clear();
                txtObsTel3.Clear();
                mskTelefone3.Focus();
            }
            else if (cmbTipoTel3.Text == "Celular" || cmbTipoTel3.Text == "Recado Cel.")
            {
                mskTelefone3.Mask = "(00)00000-0000";
                mskTelefone3.Clear();
                txtObsTel3.Clear();
                mskTelefone3.Focus();
            }
        }

        // ---------------------------- GRAVAR DADOS -------------------------

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                if (mskCpf.MaskFull != Utilidades.SPERA.ValidarCPF(mskCpf.Text))
                {
                    Mensagem("INFORME UM NÚMERO DE CPF VÁLIDO!", "warning");
                    mskCpf.Clear();
                    mskCpf.Focus();
                    return;
                }

              

                //PASSAR VALORES PARA AS VARIÁVEIS

                alunoBLL.Nome = txtNome.Text;
                alunoBLL.Rg = txtRg.Text;
                alunoBLL.Emissao = cmbEmissao.Text;
                alunoBLL.Datanasc = DateTime.Parse(mskDataNasc.Text);
                alunoBLL.Cpf = mskCpf.Text;
                alunoBLL.Filiacaomae = txtFiliacaoMae.Text;
                alunoBLL.Filiacaopai = txtFiliacaoPai.Text;
                alunoBLL.Cep = mskCep.Text;
                alunoBLL.Endereco = txtEndereco.Text;
                alunoBLL.Numero = txtNumero.Text;
                alunoBLL.Complemento = txtComplemento.Text;
                alunoBLL.Bairro = txtBairro.Text;
                alunoBLL.Cidade = txtCidade.Text;
                alunoBLL.Estado = cmbEstado.Text;
                alunoBLL.Tipotel1 = cmbTipoTel1.Text;
                alunoBLL.Telefone1 = mskTelefone1.Text;
                alunoBLL.Observacaotel1 = txtObsTel1.Text;
                alunoBLL.Tipotel2 = cmbTipoTel2.Text;
                alunoBLL.Telefone2 = mskTelefone2.Text;
                alunoBLL.Observacaotel2 = txtObsTel2.Text;
                alunoBLL.Tipotel3 = cmbTipoTel3.Text;
                alunoBLL.Telefone3 = mskTelefone3.Text;
                alunoBLL.Observacaotel3 = txtObsTel3.Text;
                alunoBLL.Email = txtEmail.Text;

                if (alunoDAL.VerificaRg(alunoBLL) > 0 && alterar == false)
                {
                    Mensagem("JÁ EXISTE UM ALUNO CADASTRADO COM ESTE RG!", "warning");
                    txtRg.Clear();
                    cmbEmissao.Text = string.Empty;
                    txtRg.Focus();
                    return;
                }


                if (alunoDAL.VerificaCpf(alunoBLL) > 0)
                {
                    Mensagem("JÁ EXISTE UM ALUNO CADASTRADO COM ESTE CPF!", "warning");
                    mskCpf.Clear();
                    mskCpf.Focus();
                    ptbCpf.Image = Resources.erro_cpf;
                    return;
                }



                if (alterar == false)
                {
                    alunoDAL.Cadastrar(alunoBLL);
                }
                else
                {
                    alunoDAL.Alterar(alunoBLL);
                    Close();

                }

                //exibir mensagem de confirmação
                Mensagem("DADOS ALTERADOS COM SUCESSO!", "ok");
                
            }
            catch
            {
                Mensagem("ERRO NA ALTERAÇÃO DOS DADOS!", "warning");
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

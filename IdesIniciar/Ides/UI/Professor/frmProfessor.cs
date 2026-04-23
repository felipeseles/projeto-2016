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
        //referencias para as classes
        BLL.ProfessorBLL professorBLL = new BLL.ProfessorBLL();
        DAL.ProfessorDAL professorDAL = new DAL.ProfessorDAL();

        // variaveis usadas para alteração
        public int codprofessor { get; set; }
        public bool alterar { get; set; }
        public int mostrar { get; set; }

        //variaveis usadas para mover painel
        private bool mover;
        private int cX, cY;

        public frmProfessor()
        {
            InitializeComponent();
        }

        // ------------------------------ LOAD DO FORMULÁRIO -----------------------------

        private void frmProfessor_Load(object sender, EventArgs e)
        {
            if (mostrar == 2)
            {
                pnlFormulario.Enabled = false;
                ptbCpf.Image = Resources.ok_cpf;
            }
            
            if (alterar == true)
            {
                professorBLL.Codprofessor = codprofessor;
                professorBLL = professorDAL.RetornarDados(professorBLL);

                txtRg.Enabled = false;
                cmbEmissao.Enabled = false;
                mskDataNasc.Enabled = false;
                mskCpf.Enabled = false;
                ptbCpf.Image = Resources.ok_cpf;
                mskAdmissao.Enabled = false;

                txtNome.Text = professorBLL.Nomeprofessor;
                txtRg.Text = professorBLL.Rg;
                cmbEmissao.Text = professorBLL.Emissao;
                mskDataNasc.Text = professorBLL.Datanasc.ToString();
                mskCpf.Text = professorBLL.Cpf;
                txtFiliacaoMae.Text = professorBLL.Filiacaomae;
                txtFiliacaoPai.Text = professorBLL.Filiacaopai;
                mskCep.Text = professorBLL.Cep;
                txtEndereco.Text = professorBLL.Endereco;
                txtNumero.Text = professorBLL.Numero;
                txtComplemento.Text = professorBLL.Complemento;
                txtBairro.Text = professorBLL.Bairro;
                txtCidade.Text = professorBLL.Cidade;
                cmbEstado.Text = professorBLL.Estado;
                cmbTipoTel1.Text = professorBLL.Tipotel1;
                mskTelefone1.Text = professorBLL.Telefone1;
                txtObsTel1.Text = professorBLL.Observacaotel1;
                cmbTipoTel2.Text = professorBLL.Tipotel2;
                mskTelefone2.Text = professorBLL.Telefone2;
                txtObsTel2.Text = professorBLL.Observacaotel2;
                cmbTipoTel3.Text = professorBLL.Tipotel3;
                mskTelefone3.Text = professorBLL.Telefone3;
                txtObsTel3.Text = professorBLL.Observacaotel3;
                txtEmail.Text = professorBLL.Email;
                cmbEscolaridade.Text = professorBLL.Escolaridade;
                mskAdmissao.Text = professorBLL.Dtadmissao.ToString();
                mskDemissao.Text = professorBLL.Dtdemissao.ToString();
            }
        }

        // ------------------------------ MOVER PAINEL -----------------------------

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
                    mskDataNasc, mskCpf, mskCep, txtNumero, mskTelefone1, mskTelefone2, 
                    mskTelefone3, txtEmail, mskAdmissao, mskDemissao                                  */
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

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Mensagem("AINDA SEM PROGRAMAR!", "warning");
            return;
        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            Mensagem("AINDA SEM PROGRAMAR!", "warning");
            return;
            //frmWebCam can = new frmWebCam();
            //can.ShowDialog();
        }

        // -------------------------- TRATAMENTO DO CEP -------------------------

        private void btnBuscaCep_Click(object sender, EventArgs e)
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
                lblObrigatorio15.Visible = false;
                txtObsTel1.Visible = true;
                lblObrigatorio12.Visible = true;
            }
            else
            {
                lblObrigatorio15.Visible = true;
                txtObsTel1.Visible = false;
                lblObrigatorio12.Visible = false;
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

                if (txtNome.Text.Trim() != "" && txtRg.Text.Trim() != "" &&
                    cmbEmissao.Text != "" && mskDataNasc.MaskFull && mskCpf.MaskFull &&
                    mskCep.MaskFull && txtEndereco.Text.Trim() != "" && txtNumero.Text.Trim() != "" &&
                    txtBairro.Text.Trim() != "" && txtCidade.Text.Trim() != "" && cmbEstado.Text != "" &&
                    cmbTipoTel1.Text != "" && mskTelefone1.MaskFull && cmbEscolaridade.Text != "" && mskAdmissao.MaskFull)
                {

                    if (mskCpf.MaskFull != Utilidades.SPERA.ValidarCPF(mskCpf.Text))
                    {
                        Mensagem("INFORME UM NÚMERO DE CPF VÁLIDO!", "warning");
                        mskCpf.Clear();
                        mskCpf.Focus();
                        return;
                    }

                    //PASSAR VALORES PARA AS VARIÁVEIS
                    professorBLL.Nomeprofessor = txtNome.Text;
                    professorBLL.Rg = txtRg.Text;
                    professorBLL.Emissao = cmbEmissao.Text;
                    professorBLL.Datanasc = DateTime.Parse(mskDataNasc.Text);
                    professorBLL.Cpf = mskCpf.Text;
                    professorBLL.Filiacaomae = txtFiliacaoMae.Text;
                    professorBLL.Filiacaopai = txtFiliacaoPai.Text;
                    professorBLL.Cep = mskCep.Text;
                    professorBLL.Endereco = txtEndereco.Text;
                    professorBLL.Numero = txtNumero.Text;
                    professorBLL.Complemento = txtComplemento.Text;
                    professorBLL.Bairro = txtBairro.Text;
                    professorBLL.Cidade = txtCidade.Text;
                    professorBLL.Estado = cmbEstado.Text;
                    professorBLL.Tipotel1 = cmbTipoTel1.Text;
                    professorBLL.Telefone1 = mskTelefone1.Text;
                    professorBLL.Observacaotel1 = txtObsTel1.Text;
                    professorBLL.Tipotel2 = cmbTipoTel2.Text;
                    professorBLL.Telefone2 = mskTelefone2.Text;
                    professorBLL.Observacaotel2 = txtObsTel2.Text;
                    professorBLL.Tipotel3 = cmbTipoTel3.Text;
                    professorBLL.Telefone3 = mskTelefone3.Text;
                    professorBLL.Observacaotel3 = txtObsTel3.Text;
                    professorBLL.Email = txtEmail.Text;
                    professorBLL.Escolaridade = cmbEscolaridade.Text;
                    professorBLL.Dtadmissao = DateTime.Parse(mskAdmissao.Text);

                    if (mskDemissao.MaskFull)
                    {
                        professorBLL.Dtdemissao = DateTime.Parse(mskDemissao.Text);
                    }
                    else
                    {
                        professorBLL.Dtdemissao = null;
                    }

                    if (professorDAL.VerificaCpf(professorBLL) > 0 && alterar == false)
                    {
                        Mensagem("JÁ EXISTE UM PROFESSOR CADASTRADO \nCOM ESTE CPF!", "warning");
                        mskCpf.Clear();
                        mskCpf.Focus();
                        ptbCpf.Image = Resources.erro_cpf;
                        return;
                    }

                    if (alterar == false)
                    {
                        professorDAL.Cadastrar(professorBLL);
                    }
                    else
                    {
                        professorDAL.Alterar(professorBLL);
                        Close(); //fechar formulario
                    }

                    //exibir mensagem de confirmação
                    Mensagem("DADOS GRAVADOS COM SUCESSO!", "ok");
                    LimparControles();
                    ptbCpf.Image = Resources.erro_cpf;
                    txtNome.Focus();
                }

                else
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

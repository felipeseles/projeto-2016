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

        //variaveis usadas para alterar
        public bool alterar { get; set; }
        private bool mover;
        private int cX, cY;
        public int codaluno { get; set; }

        public frmCadastroAluno()
        {
            InitializeComponent();
        }


        public void LimparControles()
        {
            foreach (Control controles in tabControl1.SelectedTab.Controls)
            {
                if (controles is TextBox)
                {
                    //txtCodigo.Text = txtCodigo.Text;
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
        
        public string Mensagem(string mensagem, string foto)
        {
            UI.frmMensagem m = new UI.frmMensagem();
            m.mensagem = mensagem;
            m.foto = foto;
            m.ShowDialog();
            return m.sn;
        }

        private void label2_Click(object sender, EventArgs e)
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

        private void btnBuscaCep_Click(object sender, EventArgs e)
        {
            if (!mskCep.MaskFull)
            {
                //MessageBox.Show("PREENCHA OS NUMEROS DO CEP!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Mensagem("PREENCHA OS NUMEROS DO CEP!","warning");
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

        private void mskCpf_KeyUp_1(object sender, KeyEventArgs e)
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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Trim() == "" || txtRg.Text.Trim() == "" || cmbEmissao.Text == "" || !mskDataNasc.MaskFull || cmbTipoTel1.Text == "" || !mskTelefone1.MaskFull)
            {

            }


            try
            {
                //passar valores para as variáveis
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

                if (alterar == false)
                {
                    alunoDAL.Cadastrar(alunoBLL);
                }
                else
                {
                    alunoDAL.Alterar(alunoBLL);
                    Close(); //fechar formulario
                }

                //exibir mensagem de confirmação
                Mensagem("DADOS GRAVADOS COM SUCESSO!","ok");
                LimparControles();
                txtNome.Focus();

            }
            catch
            {

                //MessageBox.Show("PREENCHA OS CAMPOS OBRIGATÓRIOS!", "GRAVAR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Mensagem("PREENCHA OS CAMPOS OBRIGATÓRIOS!", "warning");
                return;
            }
        }

        private void tspNovo_Click(object sender, EventArgs e)
        {
            LimparControles();
            txtCodigo.Text = alunoDAL.RetornaCodaluno().ToString().PadLeft(5, '0');
            txtNome.Focus();
        }

        private void frmCadastroAluno_Load(object sender, EventArgs e)
        {
            txtCodigo.Text = alunoDAL.RetornaCodaluno().ToString().PadLeft(5, '0');
        }

        private void cmbTipoTel1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbTipoTel1.Text == "Recado")
            {
                txtObsTel1.Visible = true;
                label25.Visible = true;
                label26.Visible = false;
            }
            else
            {
                txtObsTel1.Visible = false;
                label25.Visible = false;
                label26.Visible = true;
            }

            if (cmbTipoTel1.Text == "Residencial")
            {
                mskTelefone1.Mask = "(00)0000-0000";
            }
        }

        private void cmbTipoTel2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoTel2.Text == "Recado")
            {
                txtObsTel2.Visible = true;
            }
            else
            {
                txtObsTel2.Visible = false;
            }

            if (cmbTipoTel2.Text == "Residencial")
            {
                mskTelefone2.Mask = "(00)0000-0000";
            }
        }

        private void cmbTipoTel3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoTel3.Text == "Recado")
            {
                txtObsTel3.Visible = true;
            }
            else
            {
                txtObsTel3.Visible = false;
            }

            if (cmbTipoTel3.Text == "Residencial")
            {
                mskTelefone3.Mask = "(00)0000-0000";
            }
        }

        private void txtRg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                return;
            }
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            //Passar filtro
            alunoBLL.Nome = txtFiltro.Text;

            //executar consulta com filtro
            dgvConsulta.DataSource = alunoDAL.ConsultarPorNome(alunoBLL);
        }
    }
}

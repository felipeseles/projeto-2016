using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ides.UI
{
    public partial class frmTurma : Form
    {
        //referencias para as classes
        BLL.TurmaBLL turmaBLL = new BLL.TurmaBLL();
        DAL.TurmaDAL turmaDAL = new DAL.TurmaDAL();

        BLL.ProfessorBLL professorBLL = new BLL.ProfessorBLL();
        DAL.ProfessorDAL professorDAL = new DAL.ProfessorDAL();

        BLL.CursoBLL cursoBLL = new BLL.CursoBLL();
        DAL.CursoDAL cursoDAL = new DAL.CursoDAL();

        // variaveis usadas para alteração
        public bool alterar { get; set; }
        public int codturma { get; set; }
        public int mostrar { get; set; }

        //variaveis usadas para mover painel
        private bool mover;
        private int cX, cY;

        public frmTurma()
        {
            InitializeComponent();
        }

        // ------------------------------ LOAD DO FORMULÁRIO ------------------------------
        private void frmTurma_Load(object sender, EventArgs e)
        {
            //atualizando a consulta ComboBox Professor
            cmbProfessor.DataSource = professorDAL.ConsultarTodos();
            cmbProfessor.DisplayMember = "Professor";
            cmbProfessor.ValueMember = "Código";

            //atualizando a consulta ComboBox Curso
            cmbCurso.DataSource = cursoDAL.ConsultarTodos();
            cmbCurso.DisplayMember = "Curso";
            cmbCurso.ValueMember = "Código";

            if (mostrar == 3)
            {
                pnlFormulario.Enabled = false;
                cmbHoraEntrada.DropDownStyle = ComboBoxStyle.DropDown;
                cmbHoraSaida.DropDownStyle = ComboBoxStyle.DropDown;
                cmbProfessor.DropDownStyle = ComboBoxStyle.DropDown;
                cmbCurso.DropDownStyle = ComboBoxStyle.DropDown;
            }

            if (alterar == true)
            {
                turmaBLL.Codturma = codturma;
                turmaBLL = turmaDAL.RetornarDados(turmaBLL);

                cmbHoraEntrada.DropDownStyle = ComboBoxStyle.DropDown;
                cmbHoraSaida.DropDownStyle = ComboBoxStyle.DropDown;
                //cmbProfessor.DropDownStyle = ComboBoxStyle.DropDown;
                //cmbCurso.DropDownStyle = ComboBoxStyle.DropDown;
                txtQtdVagas.Text = turmaBLL.Qtdvagas.ToString();
                cmbDiaSemana.Text = turmaBLL.Diasemana;
                cmbHoraEntrada.Text = turmaBLL.Horaentrada.ToLongTimeString();
                cmbHoraSaida.Text = turmaBLL.Horasaida.ToLongTimeString();
                mskDataInicio.Text = turmaBLL.Datainicio.ToString();
                mskDataConclusao.Text = turmaBLL.Dataconclusao.ToString();
                cmbProfessor.SelectedValue = turmaBLL.Codprofessor.ToString();
                cmbCurso.SelectedValue = turmaBLL.Codcurso.ToString();
           
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

        // ---------------------------- GRAVAR -------------------------

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (txtQtdVagas.Text.Trim() != "" && cmbDiaSemana.Text != "" && cmbHoraEntrada.Text != "" && cmbHoraSaida.Text != "" &&
                mskDataInicio.MaskFull && mskDataConclusao.MaskFull && cmbProfessor.Text != "" && cmbCurso.Text != "")
            {
                //PASSAR VALORES PARA AS VARIÁVEIS

                turmaBLL.Qtdvagas = txtQtdVagas.Text;
                turmaBLL.Diasemana = cmbDiaSemana.Text;
                turmaBLL.Horaentrada = DateTime.Parse(cmbHoraEntrada.Text);
                turmaBLL.Horasaida = DateTime.Parse(cmbHoraSaida.Text);
                turmaBLL.Datainicio = DateTime.Parse(mskDataInicio.Text);
                turmaBLL.Dataconclusao = DateTime.Parse(mskDataConclusao.Text);
                turmaBLL.Codprofessor = int.Parse(cmbProfessor.SelectedValue.ToString());
                turmaBLL.Codcurso = int.Parse(cmbCurso.SelectedValue.ToString());


                if (alterar == false)
                {
                    turmaDAL.Cadastrar(turmaBLL);
                }
                else
                {
                    turmaDAL.Alterar(turmaBLL);
                    Close();

                }

                //exibir mensagem de confirmação
                Mensagem("DADOS GRAVADOS COM SUCESSO!", "ok");
                LimparControles();
                txtQtdVagas.Focus();
            }
            else
            {
                Mensagem("PREENCHA OS CAMPOS OBRIGATÓRIOS!", "warning");
                return;
            }
        
        }

        // ---------------------------- FECHAR FORMULÁRIO -------------------------
        private void lblSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}

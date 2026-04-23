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
    public partial class frmMatricula : Form
    {
        //referencias para as classes
        BLL.AlunoBLL aBLL = new BLL.AlunoBLL();
        DAL.AlunoDAL aDAL = new DAL.AlunoDAL();

        BLL.CursoBLL cBLL = new BLL.CursoBLL();
        DAL.CursoDAL cDAL = new DAL.CursoDAL();

        BLL.TurmaBLL tBLL = new BLL.TurmaBLL();
        DAL.TurmaDAL tDAL = new DAL.TurmaDAL();

        BLL.ProfessorBLL pBLL = new BLL.ProfessorBLL();
        DAL.ProfessorDAL pDAL = new DAL.ProfessorDAL();

        BLL.MatriculaBLL mBLL = new BLL.MatriculaBLL();
        DAL.MatriculaDAL mDAL = new DAL.MatriculaDAL();

        frmLogin login = new frmLogin();

        // variaveis usadas para alteração
        public int atualizar { get; set; }
        public int aba { get; set; }
        public int codaluno { get; set; }
        public int codprofessor { get; set; }
        public int codcurso { get; set; }
        public int codturma { get; set; }
        public bool alterar { get; set; }
        public int mostrar { get; set; }


        //variaveis usadas para mover painel
        private bool mover;
        private int cX, cY;

        public frmMatricula()
        {
            InitializeComponent();
        }

        // ------------------------------ LOAD DO FORMULÁRIO -----------------------------

        private void frmMatricula_Load(object sender, EventArgs e)
        {
            if (rdbAluno.Checked)
            {
                dgvConsulta.DataSource = aDAL.ConsultarTodos();
            }
            else if (rdbTurma.Checked)
            {
                dgvConsulta.DataSource = tDAL.ConsultarTodos();
            }

            mskDataInscricao.Text = DateTime.Now.ToShortDateString();
                
        }

        // ------------------------------ ALTERNAR A CONSULTA  -----------------------------

        private void rdbAluno_CheckedChanged(object sender, EventArgs e)
        {
            dgvConsulta.DataSource = aDAL.ConsultarTodos();
        }

        private void rdbTurma_CheckedChanged(object sender, EventArgs e)
        {
            dgvConsulta.DataSource = tDAL.ConsultarTodos();
        }

        // -------------------- MAXIMIZAR/RESTAURAR FORMULÁRIO --------------------
        private void lblMaximizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
        }
        
        private void pnlTitulo_DoubleClick(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
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

        // ---------------------------- METODO LIMPAR CAMPOS --------------------------

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

        // ---------------------------- CADASTRAR NOVO ALUNO -------------------------
        private void btnNovoAluno_Click(object sender, EventArgs e)
        {
            UI.Aluno.frmCadastroSimplesAluno cadAluno = new Aluno.frmCadastroSimplesAluno();
            cadAluno.ShowDialog();
        }

        // -------------------- CHECAGEM DO FILTRO --------------------

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            if (rdbAluno.Checked)
            {
                aBLL.Nome = txtFiltro.Text;
                dgvConsulta.DataSource = aDAL.ConsultarPorNome(aBLL);
            }
            else if (rdbTurma.Checked)
            {
                cBLL.Nomecurso = txtFiltro.Text;
                dgvConsulta.DataSource = tDAL.ConsultarPorCurso(cBLL);
            }
        }

        // -------------------- MOSTRAR DADOS SEM ALTERAÇÃO --------------------

        private void dgvConsulta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (rdbAluno.Checked)
            {
                if (dgvConsulta.RowCount > 0)
                {
                UI.frmCadastroAluno aluno = new frmCadastroAluno();
                aluno.codaluno = int.Parse(dgvConsulta.SelectedCells[0].Value.ToString());
                aluno.mostrar = 1;
                aluno.alterar = true;
                aluno.ShowDialog();
                }
            }

            else if (rdbTurma.Checked)
            {
                if (dgvConsulta.RowCount > 0)
                {
                UI.frmTurma turma = new frmTurma();
                turma.codturma = int.Parse(dgvConsulta.SelectedCells[0].Value.ToString());
                turma.mostrar = 3;
                turma.alterar = true;
                turma.ShowDialog();
                }
            }
        }


        // ---------------------------- EDITAR ALUNO -------------------------

        // ---------------------------- ADICIONAR ALUNO E TURMA-------------------------
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (rdbAluno.Checked)
            {
                if (dgvConsulta.RowCount > 0)
                {
                    codaluno = int.Parse(dgvConsulta.SelectedCells[0].Value.ToString());

                    aBLL.Codaluno = codaluno;
                    aBLL = aDAL.RetornarDados(aBLL);
                    txtNome.Text = aBLL.Nome;
                    
                }
            }
            else if (rdbTurma.Checked)
            {
                if (dgvConsulta.RowCount > 0)
                {
                    
                    codturma = int.Parse(dgvConsulta.SelectedCells[0].Value.ToString());

                    tBLL.Codturma = codturma;
                    tBLL = tDAL.RetornarDados(tBLL);
                    txtDiaSemana.Text = tBLL.Diasemana;
                    txtEntrada.Text = tBLL.Horaentrada.ToShortTimeString();
                    txtHoraSaida.Text = tBLL.Horasaida.ToShortTimeString();

                    txtTurma.Text = dgvConsulta.CurrentRow.Cells[1].Value.ToString();
                    txtProfessor.Text = dgvConsulta.CurrentRow.Cells[7].Value.ToString();

                    //cBLL.Codcurso = codcurso;
                    //cBLL = cDAL.RetornarDados(cBLL);
                    //txtTurma.Text = cBLL.Nomecurso;

                    //pBLL.Codprofessor = codprofessor;
                    //pBLL = pDAL.RetornarDados(pBLL);
                    //txtProfessor.Text = pBLL.Nomeprofessor;
                }
            }

        }
        // ---------------------------- GRAVAR -------------------------

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (txtMatricula.Text.Trim() != "" && mskDataInscricao.MaskFull && txtMatricula.Text.Trim() != "" &&
                txtNome.Text.Trim() != "" && txtTurma.Text.Trim() != "" && txtProfessor.Text.Trim() != "" &&
                txtDiaSemana.Text.Trim() != "" && txtEntrada.Text.Trim() != "" && txtHoraSaida.Text.Trim() != "")
            {
                //PASSAR VALORES PARA AS VARIÁVEIS

                mBLL.Matriculanumero = txtMatricula.Text;
                mBLL.Datamatricula = DateTime.Parse(mskDataInscricao.Text);
                mBLL.Codaluno = codaluno;
                mBLL.Codturma = codturma;
               
                mBLL.Codusuario = BLL.UsuarioBLL.codigousu;
                
                
                if (alterar == false)
                {
                    mDAL.Cadastrar(mBLL);
                }
                else
                {
                    mDAL.Alterar(mBLL);
                    Close(); //fechar formulario
                }

                //exibir mensagem de confirmação
                Mensagem("DADOS GRAVADOS COM SUCESSO!", "ok");
                LimparControles();
                mskDataInscricao.Text = DateTime.Now.ToShortDateString();
                txtFiltro.Focus();
            }
            else
            {
                Mensagem("PREENCHA TODOS OS CAMPOS OBRIGATÓRIOS!", "warning");
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

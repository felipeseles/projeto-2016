using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ides.UI.Consulta
{
    public partial class frmConsultas : Form
    {
        //referencias para as classes
        BLL.AlunoBLL aBLL = new BLL.AlunoBLL();
        DAL.AlunoDAL aDAL = new DAL.AlunoDAL();

        BLL.CursoBLL cBLL = new BLL.CursoBLL();
        DAL.CursoDAL cDAL = new DAL.CursoDAL();

        BLL.ProfessorBLL pBLL = new BLL.ProfessorBLL();
        DAL.ProfessorDAL pDAL = new DAL.ProfessorDAL();

        BLL.TurmaBLL tBLL = new BLL.TurmaBLL();
        DAL.TurmaDAL tDAL = new DAL.TurmaDAL();

        BLL.MatriculaBLL mBLL = new BLL.MatriculaBLL();
        DAL.MatriculaDAL mDAL = new DAL.MatriculaDAL();

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

        public frmConsultas()
        {
            InitializeComponent();
            
        }

        // -------------------- INICIAR O FORMULÁRIO --------------------

        private void frmConsultas_Load(object sender, EventArgs e)
        {
            
            dgvConsultaAluno.DataSource = aDAL.ConsultarTodos();
            dgvConsultaCurso.DataSource = cDAL.ConsultarTodos();
            dgvConsultaProfessor.DataSource = pDAL.ConsultarTodos();
            dgvConsultaTurma.DataSource = tDAL.ConsultarTodos();
            dgvConsultaMatricula.DataSource = mDAL.ConsultarTodos();

            //dgvConsultaAluno.column
            if (aba == 2)
            {
                tbcConsultas.SelectedTab = tpgCurso;
            }
            if (aba == 3)
            {
                tbcConsultas.SelectedTab = tpgMatricula;
            }
            if (aba == 4)
            {
                tbcConsultas.SelectedTab = tpgProfessor;
            }
            if (aba == 5)
            {
                tbcConsultas.SelectedTab = tpgTurmas;
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

        // -------------------- CHECAGEM DO FILTRO --------------------

        private void txtAluno_TextChanged(object sender, EventArgs e)
        {
            if (rdbNome.Checked)
            {
                aBLL.Nome = txtAluno.Text;
                dgvConsultaAluno.DataSource = aDAL.ConsultarPorNome(aBLL);
            }
            else if (rdbRG.Checked)
            {
                aBLL.Rg = txtAluno.Text;
                dgvConsultaAluno.DataSource = aDAL.ConsultarPorRg(aBLL);
            }
        }

        private void txtCurso_TextChanged_1(object sender, EventArgs e)
        {
            cBLL.Nomecurso = txtCurso.Text;
            dgvConsultaCurso.DataSource = cDAL.ConsultarPorNome(cBLL);
        }

        private void txtProfessor_TextChanged_1(object sender, EventArgs e)
        {
            pBLL.Nomeprofessor = txtProfessor.Text;
            dgvConsultaProfessor.DataSource = pDAL.ConsultarPorNome(pBLL);
        }

        private void txtTurma_TextChanged(object sender, EventArgs e)
        {
            if (rdbCurso.Checked)
            {
                cBLL.Nomecurso = txtTurma.Text;
                dgvConsultaTurma.DataSource = tDAL.ConsultarPorCurso(cBLL);
            }
            else if (rdbProfessor.Checked)
            {
                pBLL.Nomeprofessor = txtTurma.Text;
                dgvConsultaTurma.DataSource = tDAL.ConsultarPorProfessor(pBLL);
            }
        }


        private void txtAluno_KeyUp(object sender, KeyEventArgs e)
        {
            //if (rdbNome.Checked)
            //{
            //    aBLL.Nome = txtAluno.Text;
            //    dgvConsultaAluno.DataSource = aDAL.ConsultarPorNome(aBLL);
            //}
            //else if (rdbRG.Checked)
            //{
            //    aBLL.Rg = txtAluno.Text;
            //    dgvConsultaAluno.DataSource = aDAL.ConsultarPorRg(aBLL);
            //}
        }

        // -------------------- MOSTRAR DADOS SEM ALTERAÇÃO --------------------

        private void dgvConsultaAluno_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvConsultaAluno.RowCount > 0)
            {
                UI.frmCadastroAluno aluno = new frmCadastroAluno();
                aluno.codaluno = int.Parse(dgvConsultaAluno.SelectedCells[0].Value.ToString());
                aluno.mostrar = 1;
                aluno.alterar = true;
                aluno.ShowDialog();
            }
        }

        private void dgvConsultaCurso_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvConsultaCurso.RowCount > 0)
            {
                UI.frmCurso curso = new frmCurso();
                curso.codcurso = int.Parse(dgvConsultaCurso.SelectedCells[0].Value.ToString());
                curso.mostrar = 1;
                curso.alterar = true;
                curso.ShowDialog();
            }
        }

        private void dgvConsultaMatricula_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvConsultaProfessor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvConsultaProfessor.RowCount > 0)
            {
                UI.frmProfessor professor = new frmProfessor();
                professor.codprofessor = int.Parse(dgvConsultaProfessor.SelectedCells[0].Value.ToString());
                professor.mostrar = 2;
                professor.alterar = true;
                professor.ShowDialog();
            }
            
        }

        private void dgvConsultaTurma_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvConsultaTurma.RowCount > 0)
            {
                UI.frmTurma turma = new frmTurma();
                turma.codturma = int.Parse(dgvConsultaTurma.SelectedCells[0].Value.ToString());
                turma.mostrar = 3;
                turma.alterar = true;
                turma.ShowDialog();
            }
        }

        // ------------------------- EDITAR CADASTROS ---------------------------
        
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (tbcConsultas.SelectedTab == tpgAluno)
            {
                if (dgvConsultaAluno.RowCount > 0)
                {
                    UI.frmCadastroAluno aluno = new frmCadastroAluno();
                    aluno.codaluno = int.Parse(dgvConsultaAluno.SelectedCells[0].Value.ToString());
                    aluno.mostrar = 2;
                    aluno.alterar = true;
                    aluno.ShowDialog();
                    dgvConsultaAluno.DataSource = aDAL.ConsultarTodos();
                    
                }
            }
            
            if (tbcConsultas.SelectedTab == tpgCurso)
	        {
                if (BLL.UsuarioBLL.acessousu != "Usuário")
                {
                    if (dgvConsultaCurso.RowCount > 0)
                    {
                        UI.frmCurso curso = new frmCurso();
                        curso.codcurso = int.Parse(dgvConsultaCurso.SelectedCells[0].Value.ToString());
                        curso.alterar = true;
                        curso.ShowDialog();
                        dgvConsultaCurso.DataSource = cDAL.ConsultarTodos();
                        return;
                    }
                }
                Mensagem("Você não possui permissão de Administrador \npara executar essa ação!", "warning");
                return;
                
	        }

            if (tbcConsultas.SelectedTab == tpgProfessor)
            {
                if (BLL.UsuarioBLL.acessousu != "Usuário")
                {
                    if (dgvConsultaProfessor.RowCount > 0)
                    {
                        frmProfessor professor = new frmProfessor();
                        professor.codprofessor = int.Parse(dgvConsultaProfessor.SelectedCells[0].Value.ToString());
                        professor.alterar = true;
                        professor.ShowDialog();
                        dgvConsultaProfessor.DataSource = pDAL.ConsultarTodos();
                        return;
                    }
                }
                Mensagem("Você não possui permissão de Administrador \npara executar essa ação!", "warning");
                return;
            }

            if (tbcConsultas.SelectedTab == tpgTurmas)
            {
                if (BLL.UsuarioBLL.acessousu != "Usuário")
                {
                    if (dgvConsultaTurma.RowCount > 0)
                    {
                        frmTurma turma = new frmTurma();
                        turma.codturma = int.Parse(dgvConsultaTurma.SelectedCells[0].Value.ToString());
                        turma.alterar = true;
                        turma.ShowDialog();
                        dgvConsultaTurma.DataSource = tDAL.ConsultarTodos();
                        return;
                    }
                }
                Mensagem("Você não possui permissão de Administrador \npara executar essa ação!", "warning");
                return;
            }
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
        
        // -------------------- FECHAR FORMULÁRIO --------------------
        private void lblSair_Click(object sender, EventArgs e)
        {
            Close();
        }

      

       

        

       

        

        

        

        

        

       

        

    }
}

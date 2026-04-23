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
    public partial class frmExcluir : Form
    {
        //referencias para as classes
        BLL.AlunoBLL aBLL = new BLL.AlunoBLL();
        DAL.AlunoDAL aDAL = new DAL.AlunoDAL();

        BLL.CursoBLL cBLL = new BLL.CursoBLL();
        DAL.CursoDAL cDAL = new DAL.CursoDAL();

        BLL.MatriculaBLL mBLL = new BLL.MatriculaBLL();
        DAL.MatriculaDAL mDAL = new DAL.MatriculaDAL();

        BLL.ProfessorBLL pBLL = new BLL.ProfessorBLL();
        DAL.ProfessorDAL pDAL = new DAL.ProfessorDAL();

        BLL.TurmaBLL tBLL = new BLL.TurmaBLL();
        DAL.TurmaDAL tDAL = new DAL.TurmaDAL();

        BLL.UsuarioBLL uBLL = new BLL.UsuarioBLL();
        DAL.UsuarioDAL uDAL = new DAL.UsuarioDAL();

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

        public frmExcluir()
        {
            InitializeComponent();
        }

        // -------------------- INICIAR O FORMULÁRIO --------------------

        private void frmExcluir_Load(object sender, EventArgs e)
        {
            dgvConsultaAluno.DataSource = aDAL.ConsultarTodos();
            dgvConsultaCurso.DataSource = cDAL.ConsultarTodos();
            dgvConsultaMatricula.DataSource = mDAL.ConsultarTodos();
            dgvConsultaProfessor.DataSource = pDAL.ConsultarTodos();
            dgvConsultaTurma.DataSource = tDAL.ConsultarTodos();
            dgvConsultaUsuario.DataSource = uDAL.ConsultarTodos();

            //Escolher qual aba abrir

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
            if (aba == 6)
            {
                tbcConsultas.SelectedTab = tpgUsuarios;
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

        private void txtCurso_TextChanged(object sender, EventArgs e)
        {
            cBLL.Nomecurso = txtCurso.Text;
            dgvConsultaCurso.DataSource = cDAL.ConsultarPorNome(cBLL);
        }

        private void txtMatricula_TextChanged(object sender, EventArgs e)
        {
            if (rdbCodMatricula.Checked)
            {
                mBLL.Matriculanumero = txtMatricula.Text;
                dgvConsultaMatricula.DataSource = mDAL.ConsultarPorNumeroMatricula(mBLL);
            }
            else if (rdbNomeAluno.Checked)
            {
                aBLL.Nome = txtMatricula.Text;
                dgvConsultaMatricula.DataSource = mDAL.ConsultarPorNomeAluno(mBLL);
            }
        }

        private void txtProfessor_TextChanged(object sender, EventArgs e)
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

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            uBLL.Nome = txtUsuario.Text;
            dgvConsultaUsuario.DataSource = uDAL.ConsultarPorNome(uBLL);
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

        // ------------------------------ MENSAGEM ------------------------------

        public string Mensagem(string mensagem, string foto)
        {
            UI.frmMensagem m = new UI.frmMensagem();
            m.mensagem = mensagem;
            m.foto = foto;
            m.ShowDialog();
            return m.sn;
        }

        // -------------------- EXCLUIR --------------------

        private void dgvConsultaAluno_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvConsultaAluno.RowCount > 0)
            {
                try
                {
                    if (Mensagem("Deseja realmente excluir este Aluno?", "question") == "sim")
                    {
                        aBLL.Codaluno = int.Parse(dgvConsultaAluno.SelectedCells[0].Value.ToString());
                        aDAL.Excluir(aBLL);
                        txtAluno.Clear();
                        txtAluno.Focus();
                        //atualizando consulta depois de excluir
                        dgvConsultaAluno.DataSource = aDAL.ConsultarTodos();
                    }
                }
                catch 
                {
                    Mensagem("Erro ao excluir, verifique o cadastro selecionado", "error");
                }
            }
        }

        private void dgvConsultaCurso_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvConsultaCurso.RowCount > 0)
            {
                try
                {
                    if (Mensagem("Deseja realmente excluir este Curso?", "question") == "sim")
                    {
                        cBLL.Codcurso = int.Parse(dgvConsultaCurso.SelectedCells[0].Value.ToString());
                        cDAL.Excluir(cBLL);
                        txtCurso.Clear();
                        txtCurso.Focus();
                        //atualizando consulta depois de excluir
                        dgvConsultaCurso.DataSource = cDAL.ConsultarTodos();
                    }
                }
                catch
                {
                    Mensagem("Erro ao excluir, verifique o cadastro selecionado", "error");
                }
            }
        }

        private void dgvConsultaMatricula_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvConsultaMatricula.RowCount > 0)
            {
                try
                {
                    if (Mensagem("Deseja realmente excluir esta Matricula?", "question") == "sim")
                    {
                        mBLL.Codmatricula = int.Parse(dgvConsultaMatricula.SelectedCells[0].Value.ToString());
                        mDAL.Excluir(mBLL);
                        txtMatricula.Clear();
                        txtMatricula.Focus();
                        //atualizando consulta depois de excluir
                        dgvConsultaMatricula.DataSource = mDAL.ConsultarTodos();
                    }
                }
                catch
                {
                    Mensagem("Erro ao excluir, verifique o cadastro selecionado", "error");
                }
            }
        }

        private void dgvConsultaProfessor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvConsultaProfessor.RowCount > 0)
            {
                try
                {
                    if (Mensagem("Deseja realmente excluir este Professor?", "question") == "sim")
                    {
                        pBLL.Codprofessor = int.Parse(dgvConsultaProfessor.SelectedCells[0].Value.ToString());
                        pDAL.Excluir(pBLL);
                        txtProfessor.Clear();
                        txtProfessor.Focus();
                        //atualizando consulta depois de excluir
                        dgvConsultaProfessor.DataSource = pDAL.ConsultarTodos();
                    }
                }
                catch
                {
                    Mensagem("Erro ao excluir, verifique o cadastro selecionado", "error");
                }
            }
        }

        private void dgvConsultaTurma_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvConsultaTurma.RowCount > 0)
            {
                try
                {
                    if (Mensagem("Deseja realmente excluir esta Turma?", "question") == "sim")
                    {
                        tBLL.Codturma = int.Parse(dgvConsultaTurma.SelectedCells[0].Value.ToString());
                        tDAL.Excluir(tBLL);
                        txtTurma.Clear();
                        txtTurma.Focus();
                        //atualizando consulta depois de excluir
                        dgvConsultaTurma.DataSource = tDAL.ConsultarTodos();
                    }
                }
                catch
                {
                    Mensagem("Erro ao excluir, verifique o cadastro selecionado", "error");
                }
            }
        }

        private void dgvConsultaUsuario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvConsultaUsuario.RowCount > 0)
            {
                try
                {
                    if (Mensagem("Deseja realmente excluir este Usuário?", "question") == "sim")
                    {
                        uBLL.Codusuario = int.Parse(dgvConsultaUsuario.SelectedCells[0].Value.ToString());
                        uDAL.Excluir(uBLL);
                        txtUsuario.Clear();
                        txtUsuario.Focus();
                        //atualizando consulta depois de excluir
                        dgvConsultaUsuario.DataSource = uDAL.ConsultarTodos();
                    }
                }
                catch
                {
                    Mensagem("Erro ao excluir, verifique o cadastro selecionado", "error");
                }
            }
        }

        // -------------------- FECHAR FORMULÁRIO --------------------

        private void lblSair_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}

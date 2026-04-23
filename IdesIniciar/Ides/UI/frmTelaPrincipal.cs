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
    public partial class frmTelaPrincipal : Form
    {
        public int codusuario { get; set; }
        public int mostrar { get; set; }

        public frmTelaPrincipal()
        {
            InitializeComponent();
            
        }

        // -------------------- BARRA DE TITULO --------------------

        private void lblSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // -------------------- MENSAGEM --------------------
        public string Mensagem(string mensagem, string foto)
        {
            UI.frmMensagem m = new UI.frmMensagem();
            m.mensagem = mensagem;
            m.foto = foto;
            m.ShowDialog();
            return m.sn;
        }

        // -------------------- TELA PRINCIPAL  --------------------------

        private void frmTelaPrincipal_Load(object sender, EventArgs e)
        {
            
            frmLogin login = new frmLogin();
            login.ShowDialog();

            if (BLL.UsuarioBLL.acessousu == "Usuário")
            {
                btnAdministrador.Enabled = false;
                btnConfiguracao.Enabled = false;
            }

            if (BLL.UsuarioBLL.sexousu == "M")
            {
                lblBemVindoUsuario.Text = "Bem vindo, " + BLL.UsuarioBLL.nomeusu;
            }
            else if (BLL.UsuarioBLL.sexousu == "F")
            {
                lblBemVindoUsuario.Text = "Bem vinda, " + BLL.UsuarioBLL.nomeusu;
            }

            lblBemVindoUsuario.Visible = true;
            lblRolagemLogin.Visible = true;
            lblDataHora.Text = DateTime.Now.ToShortTimeString() + "\n" + DateTime.Now.ToShortDateString();

            if (login.logado == false)
            {
                Close(); // fechar o formulário caso falso
            }
        }

        private void pnlTelaPrincipal_MouseHover(object sender, EventArgs e)
        {
            pnlLogin.Visible = false;
            pnlMenuIniciar.Visible = false;
            pnlCadastro.Visible = false;
            pnlConsulta.Visible = false;
            pnlAdministrador.Visible = false;
            pnlAdministradorItens.Visible = false;
        }

        // -------------------- BARRA DE LOGIN --------------------

        private void lblRolagemLogin_MouseHover(object sender, EventArgs e)
        {
            pnlLogin.Visible = true;
            lblNome.Text = BLL.UsuarioBLL.nomeusu;
            lblSobrenome.Text = BLL.UsuarioBLL.sobrenomeusu;

            
            //pctUsuario.Image = BLL.UsuarioBLL.fotousu.ToString();
        }

        private void lblEditarPerfil_Click(object sender, EventArgs e)
        {
            frmCadastroUsuario editusu = new frmCadastroUsuario();
            pnlLogin.Visible = false;
            editusu.codusuario = BLL.UsuarioBLL.codigousu;
            editusu.alterar = true;
            editusu.mostrar = 1;
            editusu.ShowDialog();
            
        }


        // -------------------- BARRA DE TAREFAS --------------------

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDataHora.Text = DateTime.Now.ToShortTimeString() + "\n" + DateTime.Now.ToShortDateString();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (pnlMenuIniciar.Visible == true)
            {
                pnlMenuIniciar.Visible = false;
            }
            else if (pnlMenuIniciar.Visible == false)
            {
                pnlMenuIniciar.Visible = true;
            }
        }

        private void btnInternetExpolorer_Click(object sender, EventArgs e)
        {
           System.Diagnostics.Process.Start(@"C:\Program Files\Internet Explorer\iexplore.exe");           
        }

        private void btnGoogleChrome_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe");
        }

        private void btnExploradorArquivos_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Windows\explorer.exe");
        }

        private void btnWindowsMediaPlayer_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Windows Media Player\wmplayer.exe");
        }

        private void btnDesktop_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // -------------------- PAINEL MENU INICIAR --------------------

        private void pnlMenuIniciar_MouseHover(object sender, EventArgs e)
        {
            pnlCadastro.Visible = false;
            pnlConsulta.Visible = false;
            pnlAdministrador.Visible = false;
            pnlAdministradorItens.Visible = false;
        }

        private void btnWord_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Program Files\Microsoft Office\Office15\WINWORD.exe");
            pnlMenuIniciar.Visible = false;
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Program Files\Microsoft Office\Office15\EXCEL.exe");
            pnlMenuIniciar.Visible = false;
        }

        private void btnPowerPoint_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Program Files\Microsoft Office\Office15\POWERPNT.exe");
            pnlMenuIniciar.Visible = false;
        }

        private void btnPaint_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Windows\system32\mspaint.exe");
            pnlMenuIniciar.Visible = false;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Windows\system32\calc.exe");
            pnlMenuIniciar.Visible = false;
        }

        // -------------------- PAINEL DE CADASTRO --------------------

        private void btnCadastro_MouseHover(object sender, EventArgs e)
        {
            pnlCadastro.Visible = true;
            pnlConsulta.Visible = false;
            pnlAdministrador.Visible = false;
            pnlAdministradorItens.Visible = false;
        }

        private void btnCadastroAluno_Click(object sender, EventArgs e)
        {
            UI.Aluno.frmCadastroSimplesAluno aluno = new Aluno.frmCadastroSimplesAluno();
            pnlMenuIniciar.Visible = false;
            pnlCadastro.Visible = false;
            aluno.ShowDialog();
        }

        private void btnCadastroMatricula_Click(object sender, EventArgs e)
        {
            UI.frmMatricula matricula = new frmMatricula();
            pnlMenuIniciar.Visible = false;
            pnlCadastro.Visible = false;
            matricula.ShowDialog();
        }

        // -------------------- PAINEL DE CONSULTA --------------------

        private void btnConsulta_MouseHover(object sender, EventArgs e)
        {
            pnlConsulta.Visible = true;
            pnlCadastro.Visible = false;
            pnlAdministrador.Visible = false;
            pnlAdministradorItens.Visible = false;
        }

        private void btnConsultaAluno_Click(object sender, EventArgs e)
        {
            UI.Consulta.frmConsultas consultaAluno = new Consulta.frmConsultas();
            pnlMenuIniciar.Visible = false;
            pnlConsulta.Visible = false;
            consultaAluno.ShowDialog();
        }

        private void btnConsultaCurso_Click(object sender, EventArgs e)
        {
            UI.Consulta.frmConsultas consultaCurso = new Consulta.frmConsultas();
            pnlMenuIniciar.Visible = false;
            pnlConsulta.Visible = false;
            consultaCurso.aba = 2;
            consultaCurso.ShowDialog();
        }

        private void btnConsultaMatricula_Click(object sender, EventArgs e)
        {
            UI.Consulta.frmConsultas consultaMatricula = new Consulta.frmConsultas();
            pnlMenuIniciar.Visible = false;
            pnlConsulta.Visible = false;
            consultaMatricula.aba = 3;
            consultaMatricula.ShowDialog();
        }

        private void btnConsultaProfessor_Click(object sender, EventArgs e)
        {
            UI.Consulta.frmConsultas consultaProfessor = new Consulta.frmConsultas();
            pnlMenuIniciar.Visible = false;
            pnlConsulta.Visible = false;
            consultaProfessor.aba = 4;
            consultaProfessor.ShowDialog();
        }

        private void btnConsultaTurma_Click(object sender, EventArgs e)
        {
            UI.Consulta.frmConsultas consultaTurma = new Consulta.frmConsultas();
            pnlMenuIniciar.Visible = false;
            pnlConsulta.Visible = false;
            consultaTurma.aba = 5;
            consultaTurma.ShowDialog();
        }

        // -------------------- PAINEL DE ADMINISTRADOR --------------------

        private void btnAdministrador_MouseHover(object sender, EventArgs e)
        {
           
            pnlAdministrador.Visible = true;
            pnlCadastro.Visible = false;
            pnlConsulta.Visible = false;
            if (pnlAdministradorItens.Visible == true)
            {
                pnlAdministradorItens.Visible = false;
            }
        }

        private void pnlAdministradorItens_MouseHover(object sender, EventArgs e)
        {
            pnlAdmCadastro.Visible = false;
            pnlAdmExcluir.Visible = false;
            pnlAdmRelatorios.Visible = false;
        }

        private void btnAdmCadastros_MouseHover(object sender, EventArgs e)
        {
            pnlAdministradorItens.Visible = true;
            pnlAdmCadastro.Visible = true;
            pnlAdmExcluir.Visible = false;
            pnlAdmRelatorios.Visible = false;
        }

        private void btnAdmExcluir_MouseHover(object sender, EventArgs e)
        {
            pnlAdministradorItens.Visible = true;
            pnlAdmExcluir.Visible = true;
            pnlAdmCadastro.Visible = false;
            pnlAdmRelatorios.Visible = false;
        }

        private void btnAdmRelatorios_MouseHover(object sender, EventArgs e)
        {
            pnlAdministradorItens.Visible = true;
            pnlAdmRelatorios.Visible = true;
            pnlAdmCadastro.Visible = false;
            pnlAdmExcluir.Visible = false;
        }

        // -------------------- PAINEL DE ADMINISTRADOR (CADASTROS) --------------------

        private void btnCadastroCurso_Click(object sender, EventArgs e)
        {
            UI.frmCurso curso = new frmCurso();
            pnlMenuIniciar.Visible = false;
            pnlAdministrador.Visible = false;
            pnlAdministradorItens.Visible = false;
            pnlAdmCadastro.Visible = false;
            curso.ShowDialog();
        }

        private void btnCadastroProfessores_Click(object sender, EventArgs e)
        {
            UI.frmProfessor professor = new frmProfessor();
            pnlMenuIniciar.Visible = false;
            pnlAdministrador.Visible = false;
            pnlAdministradorItens.Visible = false;
            pnlAdmCadastro.Visible = false;
            professor.ShowDialog();
        }

        private void btnCadastroTurma_Click(object sender, EventArgs e)
        {
            UI.frmTurma turma = new frmTurma();
            pnlMenuIniciar.Visible = false;
            pnlAdministrador.Visible = false;
            pnlAdministradorItens.Visible = false;
            pnlAdmCadastro.Visible = false;
            turma.ShowDialog();

        }

        private void btnCadastroUsuario_Click(object sender, EventArgs e)
        {
            UI.frmCadastroUsuario usu = new frmCadastroUsuario();
            pnlMenuIniciar.Visible = false;
            pnlAdministrador.Visible = false;
            pnlAdministradorItens.Visible = false;
            pnlAdmCadastro.Visible = false;
            usu.ShowDialog();
        }

        private void btnCadastroTurma_Click_1(object sender, EventArgs e)
        {
            frmTurma turma = new frmTurma();
            pnlMenuIniciar.Visible = false;
            pnlAdministrador.Visible = false;
            pnlAdministradorItens.Visible = false;
            pnlAdmCadastro.Visible = false;
            turma.ShowDialog();

        }

        // -------------------- PAINEL DE ADMINISTRADOR (EXCLUIR) --------------------
        
        private void btnExcluirAluno_Click(object sender, EventArgs e)
        {
            frmExcluir excluirAluno = new frmExcluir();
            pnlMenuIniciar.Visible = false;
            pnlAdministrador.Visible = false;
            pnlAdministradorItens.Visible = false;
            pnlAdmCadastro.Visible = false;
            excluirAluno.ShowDialog();
        }

        private void btnExcluirCurso_Click(object sender, EventArgs e)
        {
            frmExcluir excluirCurso = new frmExcluir();
            pnlMenuIniciar.Visible = false;
            pnlAdministrador.Visible = false;
            pnlAdministradorItens.Visible = false;
            pnlAdmCadastro.Visible = false;
            excluirCurso.aba = 2;
            excluirCurso.ShowDialog();
        }

        private void btnExcluirMatricula_Click(object sender, EventArgs e)
        {
            frmExcluir excluirMatricula = new frmExcluir();
            pnlMenuIniciar.Visible = false;
            pnlAdministrador.Visible = false;
            pnlAdministradorItens.Visible = false;
            pnlAdmCadastro.Visible = false;
            excluirMatricula.aba = 3;
            excluirMatricula.ShowDialog();
        }

        private void btnExcluirProfessor_Click(object sender, EventArgs e)
        {
            frmExcluir excluirProfessor = new frmExcluir();
            pnlMenuIniciar.Visible = false;
            pnlAdministrador.Visible = false;
            pnlAdministradorItens.Visible = false;
            pnlAdmCadastro.Visible = false;
            excluirProfessor.aba = 4;
            excluirProfessor.ShowDialog();
        }

        private void btnExcluirTurma_Click(object sender, EventArgs e)
        {
            frmExcluir excluirTurma = new frmExcluir();
            pnlMenuIniciar.Visible = false;
            pnlAdministrador.Visible = false;
            pnlAdministradorItens.Visible = false;
            pnlAdmCadastro.Visible = false;
            excluirTurma.aba = 5;
            excluirTurma.ShowDialog();
        }

        private void btnExcluirUsuario_Click(object sender, EventArgs e)
        {

        }


        // -------------------- LOGOUT --------------------

        private void lblLogout_Click(object sender, EventArgs e)
        {
            frmTelaPrincipal tela = new frmTelaPrincipal();
            tela.Show();
        }

        // -------------------- CONFIGURAÇÕES--------------------

        private void btnConfiguracao_Click(object sender, EventArgs e)
        {
            frmConfiguracao config = new frmConfiguracao();
            pnlMenuIniciar.Visible = false;
            config.ShowDialog();
        }

        

        // -------------------- PAINEL DE ADMINISTRADOR (RELATORIOS) --------------------

        private void btnRelAluno_Click(object sender, EventArgs e)
        {
            frmRelatorioAluno relAluno = new frmRelatorioAluno();
            pnlMenuIniciar.Visible = false;
            pnlAdministrador.Visible = false;
            pnlAdministradorItens.Visible = false;
            pnlAdmCadastro.Visible = false;
            relAluno.ShowDialog();
        }

        private void btnRelCurso_Click(object sender, EventArgs e)
        {
            frmRelatorioCurso relCuros = new frmRelatorioCurso();
            pnlMenuIniciar.Visible = false;
            pnlAdministrador.Visible = false;
            pnlAdministradorItens.Visible = false;
            pnlAdmCadastro.Visible = false;
            relCuros.ShowDialog();
        }

        private void btnRelProfessores_Click(object sender, EventArgs e)
        {
            frmRelatorioProfessor relProfessor = new frmRelatorioProfessor();
            pnlMenuIniciar.Visible = false;
            pnlAdministrador.Visible = false;
            pnlAdministradorItens.Visible = false;
            pnlAdmCadastro.Visible = false;
            relProfessor.ShowDialog();
        }

        private void btnRelTurmas_Click(object sender, EventArgs e)
        {
            frmRelatorioTurma relTurmas = new frmRelatorioTurma();
            pnlMenuIniciar.Visible = false;
            pnlAdministrador.Visible = false;
            pnlAdministradorItens.Visible = false;
            pnlAdmCadastro.Visible = false;
            relTurmas.ShowDialog();
        }

        private void btnRelUsuario_Click(object sender, EventArgs e)
        {
            frmRelatorioUsuario relUsuario = new frmRelatorioUsuario();
            pnlMenuIniciar.Visible = false;
            pnlAdministrador.Visible = false;
            pnlAdministradorItens.Visible = false;
            pnlAdmCadastro.Visible = false;
            relUsuario.ShowDialog();
        }

        private void btnRelMatricula_Click(object sender, EventArgs e)
        {
            frmRelatorioMatricula relMatricula = new frmRelatorioMatricula();
            pnlMenuIniciar.Visible = false;
            pnlAdministrador.Visible = false;
            pnlAdministradorItens.Visible = false;
            pnlAdmCadastro.Visible = false;
            relMatricula.ShowDialog();
        }

        private void btnConfiguracao_MouseHover(object sender, EventArgs e)
        {
            pnlCadastro.Visible = false;
            pnlAdministrador.Visible = false;
            pnlAdministradorItens.Visible = false;
            pnlCadastro.Visible = false;
            pnlConsulta.Visible = false;
            
        }

    }
}

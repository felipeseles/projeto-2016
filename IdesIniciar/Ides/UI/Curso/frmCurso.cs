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
    public partial class frmCurso : Form
    {
        //referencias para as classes
        BLL.CursoBLL cursoBLL = new BLL.CursoBLL();
        DAL.CursoDAL cursoDAL = new DAL.CursoDAL();

        // variaveis usadas para alteração
        public int atualizar { get; set; }
        public int codcurso { get; set; }
        public bool alterar { get; set; }
        public int mostrar { get; set; }
        
        //variaveis usadas para mover painel
        private bool mover;
        private int cX, cY;

        public frmCurso()
        {
            InitializeComponent();
        }

        // ------------------------------ LOAD DO FORMULÁRIO -----------------------------

        private void frmCurso_Load(object sender, EventArgs e)
        {
            if (mostrar == 1)
            {
                pnlFormulario.Enabled = false;
            }

            if (alterar == true)
            {
                cursoBLL.Codcurso = codcurso;
                cursoBLL = cursoDAL.RetornarDados(cursoBLL);

                txtNomeCurso.Text = cursoBLL.Nomecurso;
                
                
            }
        }

        // ------------------------------ MOVER PAINEL ------------------------------

        private void lblTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                //Este método também esta sendo utilizado no pnlTitulo
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
            if (mover)
            {
                //Este método também esta sendo utilizado no pnlTitulo
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

        // ---------------------------- MÉTODO GRAVAR -------------------------

        private void btnGravar_Click(object sender, EventArgs e)
        {
            
                    if (txtNomeCurso.Text.Trim() == "")
                    {
                        Mensagem("PREENCHA O CAMPO OBRIGATÓRIO!", "warning");
                        txtNomeCurso.Focus();
                        return;
                    }
                
                    //PASSAR VALORES PARA AS VARIÁVEIS

                    cursoBLL.Nomecurso = txtNomeCurso.Text;

                    if (alterar == false)
                    {
                        cursoDAL.Cadastrar(cursoBLL);
                    }
                    else
                    {
                        cursoDAL.Alterar(cursoBLL);
                        Close(); //fechar formulario
                    }

                    //exibir mensagem de confirmação
                    Mensagem("DADOS GRAVADOS COM SUCESSO!", "ok");
                    txtNomeCurso.Clear();
                    txtNomeCurso.Focus();
                    
            
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

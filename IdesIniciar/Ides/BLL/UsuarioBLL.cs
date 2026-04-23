using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ides.BLL
{
    class UsuarioBLL
    {
        private int codusuario;

        public int Codusuario
        {
            get { return codusuario; }
            set { codusuario = value; }
        }

        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private string sobrenome;

        public string Sobrenome
        {
            get { return sobrenome; }
            set { sobrenome = value; }
        }

        private string cpf;

        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }

        private string sexo;

        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private string nomeusuario;

        public string Nomeusuario
        {
            get { return nomeusuario; }
            set { nomeusuario = value; }
        }

        private string senha;

        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }

        private string acesso;

        public string Acesso
        {
            get { return acesso; }
            set { acesso = value; }
        }

        private string foto;

        public string Foto
        {
            get { return foto; }
            set { foto = value; }
        }


        public static string nomeusu;
        public static string sexousu;
        public static string sobrenomeusu;
        public static string acessousu;
        public static int codigousu;
    }
}


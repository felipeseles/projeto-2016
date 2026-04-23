using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ides.BLL
{
    class MatriculaBLL
    {
        private int codmatricula;

        public int Codmatricula
        {
            get { return codmatricula; }
            set { codmatricula = value; }
        }

        private string matriculanumero;

        public string Matriculanumero
        {
            get { return matriculanumero; }
            set { matriculanumero = value; }
        }

        private DateTime datamatricula;

        public DateTime Datamatricula
        {
            get { return datamatricula; }
            set { datamatricula = value; }
        }


        private int codaluno;

        public int Codaluno
        {
            get { return codaluno; }
            set { codaluno = value; }
        }

        private int codturma;

        public int Codturma
        {
            get { return codturma; }
            set { codturma = value; }
        }

        private int codusuario;

        public int Codusuario
        {
            get { return codusuario; }
            set { codusuario = value; }
        }
    }
}

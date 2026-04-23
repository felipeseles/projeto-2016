using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ides.BLL
{
    class CursoBLL
    {
        private int codcurso;

        public int Codcurso
        {
            get { return codcurso; }
            set { codcurso = value; }
        }

        private string nomecurso;

        public string Nomecurso
        {
            get { return nomecurso; }
            set { nomecurso = value; }
        }
    }
}

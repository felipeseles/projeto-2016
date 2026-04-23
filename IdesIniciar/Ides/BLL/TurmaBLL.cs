using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ides.BLL
{
    class TurmaBLL
    {
        private int codturma;

        public int Codturma
        {
            get { return codturma; }
            set { codturma = value; }
        }

        private string qtdvagas;

        public string Qtdvagas
        {
            get { return qtdvagas; }
            set { qtdvagas = value; }
        }

        private string diasemana;

        public string Diasemana
        {
            get { return diasemana; }
            set { diasemana = value; }
        }


        private DateTime horaentrada;

        public DateTime Horaentrada
        {
            get { return horaentrada; }
            set { horaentrada = value; }
        }

        private DateTime horasaida;

        public DateTime Horasaida
        {
            get { return horasaida; }
            set { horasaida = value; }
        }

        private DateTime datainicio;

        public DateTime Datainicio
        {
            get { return datainicio; }
            set { datainicio = value; }
        }

        private DateTime dataconclusao;

        public DateTime Dataconclusao
        {
            get { return dataconclusao; }
            set { dataconclusao = value; }
        }

        private int codprofessor;

        public int Codprofessor
        {
            get { return codprofessor; }
            set { codprofessor = value; }
        }

        private int codcurso;

        public int Codcurso
        {
            get { return codcurso; }
            set { codcurso = value; }
        }
    }
}

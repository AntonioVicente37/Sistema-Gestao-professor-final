using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloTurma
    {

        private int tucod;
        private int anocod;
        private int cucod;
        private string turma;
        private string periodo;
        public ModeloTurma()
        {
            this.tucod = 0;
            this.cucod = 0;
            this.anocod = 0;
            this.turma = "";
            this.periodo = "";
           
        }
        public ModeloTurma(int tucod, int cucod,int anocod, string turma, string periodo)
        {
            this.TuCod = tucod;
            this.CuCod = cucod;
            this.AnoCod = anocod;
            this.Turma = turma;
            this.Periodo = periodo;
           
        }
        public int TuCod
        {
            get { return tucod; }
            set { tucod = value; }
        }
        public int CuCod
        {
            get { return cucod; }
            set { cucod = value; }
        }
        public int AnoCod
        {
            get { return anocod; }
            set { anocod = value; }
        }

        public string Turma
        {
            get { return turma; }
            set { turma = value; }
        }
        public string Periodo
        {
            get { return periodo; }
            set { periodo = value; }
        }

    
    }
}

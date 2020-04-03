using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloTPTurma
    {
        private int tpcod;
        private int tucod;
        private int procod;
        private string tpdir;
       

        public ModeloTPTurma()
        {
            this.TpCod = 0;
            this.TuCod = 0;
            this.procod = 0;
            this.TpDir = "";
           
        }
        public ModeloTPTurma(int tpcod, int tucod, int procod, string tpdir)
        {
            this.TpCod = tpcod;
            this.TuCod = tucod;
            this.ProCod = procod;
            this.TpDir = tpdir;
           
        }

        public int TpCod
        {
            get{return tpcod;}
            set{tpcod = value;}
        }

        public int TuCod
        {
            get{return tucod;}
            set{tucod = value;}
        }

        public int ProCod
        {
            get{return procod;}
            set{procod = value;}
        }

        public string TpDir
        {
            get{return tpdir;}
            set{tpdir = value;}
        }

      
    }
}

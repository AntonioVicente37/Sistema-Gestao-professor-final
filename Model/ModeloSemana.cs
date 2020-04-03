using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloSemana
    {
        private int secod;
        private int tucod;
        private int procod;
        private int dicod;
        private int sacod;
        private int anocod;
        private string semana;
        private String hinicial;
        private String hfinal;
        private string tempo;

        public ModeloSemana()
        {
            this.SeCod = 0;
            this.TuCod = 0;
            this.ProCod = 0;
            this.DiCod = 0;
            this.SaCod = 0;
            this.Semana = "";
            this.HInicial = "";
            this.HFinal = "";
            this.Tempo = "";
            this.AnoCod = 0;
        }
        public ModeloSemana(int secod, int tucod,int sacod,int anocod ,int procod, int dicod, string semana, string hinicial, string hfinal, string tempo)
        {
            this.SeCod = secod;
            this.TuCod = tucod;
            this.ProCod = procod;
            this.DiCod = dicod;
            this.Semana = semana;
            this.HInicial = hinicial;
            this.HFinal = hfinal;
            this.Tempo = tempo;
            this.SaCod = sacod;
            this.AnoCod = anocod;
        }

        public int SeCod
        {
            get{return secod;}
            set{secod = value;}
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

        public int DiCod
        {
            get{return dicod;}
            set{dicod = value;}
        }

        public string Semana
        {
            get{return semana;}
            set{semana = value;}
        }

        public String HInicial
        {
            get{return hinicial;}
            set{hinicial = value;}
        }

        public String HFinal
        {
            get{return hfinal;}
            set{hfinal = value;}
        }

        public String Tempo
        {
            get{return tempo;}
            set{tempo = value;}
        }
        public int AnoCod
        {
            get { return anocod; }
            set { anocod = value; }
        }
        public int SaCod
        {
            get{ return sacod;}
            set{sacod = value;}
        }
    }
}

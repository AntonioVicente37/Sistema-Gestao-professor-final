using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloProva
    {
        private int pvcod;
        private int procod;
        private int coocod;       
        private int sacod;       
        private int tucod;
        private int dicod;
        private DateTime data;       
        private string tipo;
        private String hinicial;
        private String hfinal;
        private string periodo;
        public ModeloProva()
        {
            this.PvCod = 0;
            this.ProCod = 0;
            this.SaCod = 0;           
            this.CooCod = 0;
            this.TuCod = 0;
            this.Tipo = "";
            this.HInicial = "";
            this.HFinal =   "";
            this.Data = DateTime.Now;
            this.Periodo = "";
        }

        public ModeloProva(int pvcod,string periodo ,int tucod,int procod,DateTime date,int coocod ,int dicod, int sacod, string tipo, String hinicial, String hfinal)
        {
            this.PvCod = pvcod;
            this.ProCod = procod;
            this.SaCod = sacod;            
            this.TuCod = tucod;
            this.CooCod = coocod;                 
            this.Tipo = tipo;
            this.HInicial = hinicial;
            this.HFinal = hfinal;
            this.DiCod = dicod;
            this.Data = data;
            this.Periodo = periodo;
        }


        public int PvCod
        {
            get{ return pvcod;}
            set{pvcod = value;}
        }
        public int CooCod
        {
            get { return coocod; }
            set { coocod = value; }
        }
       

        public int ProCod
        {
            get{return procod;}
            set{procod = value;}
        }

        public int SaCod
        {
            get{return sacod;}
            set{sacod = value;}
        }

            

        public string Tipo
        {
            get{return tipo;}
            set{ tipo = value;}
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

        public int TuCod
        {
            get{return tucod;}
            set{tucod = value;}
        }

        public int DiCod
        {
            get{return dicod;}
            set{dicod = value;}
        }

        public DateTime Data
        {
            get{return data;}
            set{data = value;}
        }

        public String Periodo
        {
            get{return periodo;}
            set{periodo = value;}
        }
    }
}

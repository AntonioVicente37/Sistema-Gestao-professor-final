using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloCordenacao
    {
        private int cocod;
        private int procod;
        private int anocod;
        private String coordenacao;

        public ModeloCordenacao()
        {
            this.CoCod =0;
            this.AnoCod = 0;
            this.ProCod = 0;
            this.Coordenacao = "";
           
        }
        public ModeloCordenacao(int cocod,int procod,int anocod ,string coordenacao)
        {
            this.CoCod = cocod;
            this.ProCod = cocod;
            this.AnoCod = cocod;
            this.Coordenacao = coordenacao;
        }
        public int CoCod
        {
            get{return cocod;}
            set{cocod= value;}
        }
        public int AnoCod
        {
            get { return anocod; }
            set { anocod = value; }
        }

        public string Coordenacao
        {
            get{return coordenacao;}
            set{coordenacao = value;}
        }


        public int ProCod
        {
            get{return procod;}
            set{procod = value;}
        }
    }
}

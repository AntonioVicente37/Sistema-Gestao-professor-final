using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloSala
    {
        private int sacod;
        private string sanum;
        private string descricao;
        public ModeloSala()
        {
            this.sacod = 0;
            this.sanum = "";
            this.descricao = "";
        }
        public ModeloSala(int sacod, string sanum, string descricao)
        {
            this.SaCod = sacod;
            this.SaNum = sanum;
            this.Descricao = descricao;
        }
        public int SaCod
        {
            get{return sacod;}
            set{sacod = value;}
        }

        public string SaNum
        {
            get{return sanum;}
            set{sanum = value;}
        }

        public string Descricao
        {
            get{return descricao;}
            set{descricao = value;}
        }

       
    }
}

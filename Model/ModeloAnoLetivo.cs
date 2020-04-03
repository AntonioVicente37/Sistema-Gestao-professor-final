using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloAnoLetivo
    {
        private int anocod;
        private string ano;
        private string descricao;

        public ModeloAnoLetivo()
        {
            this.AnoCod = 0;
            this.Ano = "";
            this.Descricao = "";
        }
        public ModeloAnoLetivo(int anocod, string ano, string descricao)
        {
            this.anocod = anocod;
            this.ano = ano;
            this.descricao = descricao;
        }

        public int AnoCod
        {
            get{return anocod;}
            set{anocod = value;}
        }

        public string Ano
        {
            get{return ano;}
            set{ano = value;}
        }

        public string Descricao
        {
            get{return descricao;}
            set{descricao = value;}
        }
    }
}

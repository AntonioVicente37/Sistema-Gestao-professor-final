
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
     public class ModeloMunicipio
    {
        private int mucod;
        private string distritio;
        private string bairro;
        private string descricao;

        public ModeloMunicipio()
        {
            this.MuCod = 0;
            this.Distritio = "";
            this.Bairro = "";
            this.Descricao = "";
        }
        public ModeloMunicipio(int mucod, string distritio, string bairro, string descricao)
        {
            this.MuCod = mucod;
            this.Distritio = distritio;
            this.Bairro = bairro;
            this.Descricao = descricao;
        }

        public int MuCod
        {
            get{return mucod;}
            set{mucod = value;}
        }

        public string Distritio
        {
            get{return distritio;}
            set{distritio = value;}
        }

        public string Bairro
        {
            get{return bairro;}
            set{bairro = value;}
        }

        public String Descricao
        {
            get{return descricao;}
            set{descricao = value;}
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloTipoUtilizador
    {
        private int utcod;
        private string utilizador;
        private DateTime datacad;
        private DateTime dataatu;

        public ModeloTipoUtilizador()
        {
            this.UtCod = 0;
            this.utilizador = "";
            this.datacad = DateTime.Now;
            this.dataatu = DateTime.Now;
        }
        public ModeloTipoUtilizador(int utcod, string utilizador, DateTime datacad, DateTime dataatu)
        {
            this.UtCod = utcod;
            this.Utilizador = utilizador;
            this.Datacad = datacad;
            this.Dataatu = dataatu;
        }

        public int UtCod
        {
            get{return utcod;}
            set{utcod = value;}
        }

        public string Utilizador
        {
            get{return utilizador;}
            set{utilizador = value;}
        }

        public DateTime Datacad
        {
            get{return datacad;}
            set{datacad = value;}
        }

        public DateTime Dataatu
        {
            get{return dataatu;}
            set{dataatu = value;}
        }
    }
}

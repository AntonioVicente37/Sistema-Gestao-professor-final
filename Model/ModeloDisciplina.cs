using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloDisciplina
    {
        private int dicod;
        private int cucod;
        private int cocod;
        private string componente;
        private string carga;
        private string disciplina;

        public ModeloDisciplina()
        {
            this.DiCod = 0;
            this.CuCod = 0;
            this.CoCod = 0;
            this.Componente = "";
            this.Carga = "";
            this.Disciplina = "";
        }
        public ModeloDisciplina(int dicod, int cucod, int cocod, string componente, string carga, string disciplina)
        {
            this.DiCod = dicod;
            this.CuCod = cucod;
            this.CoCod = cocod;
            this.Componente = componente;
            this.Carga = carga;
            this.Disciplina = disciplina;
        }

        public int DiCod
        {
            get{return dicod;}
            set{dicod = value;}
        }

        public int CuCod
        {
            get{return cucod;}
            set{cucod = value;}
        }

        public int CoCod
        {
            get{return cocod;}
            set{cocod = value;}
        }

        public string Componente
        {
            get{return componente;}
            set{componente = value;}
        }

        public String Carga
        {
            get{return carga;}
            set{carga = value;}
        }

        public string Disciplina
        {
            get{return disciplina; }
            set{ disciplina = value;}
        }
    }
}

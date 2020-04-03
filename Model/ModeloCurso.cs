using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloCurso
    {
        private int cucod;
        private string curso;
        private string areaformacao;

        public ModeloCurso()
        {
            this.cucod = 0;
            this.Curso = "";
            this.AreFormacao = "";
        }
        public ModeloCurso(int cucod, string curso,string area)
        {
            this.CuCod = cucod;
            this.Curso = curso;
            this.AreFormacao = area;
           
        }
        public int CuCod
        {
            get { return cucod; }
            set { cucod = value; }
        }       

        public string Curso
        {
            get { return curso; }
            set { curso = value; }
        }
        public string AreFormacao
        {
            get { return areaformacao; }
            set { areaformacao = value; }
        }



    }
}

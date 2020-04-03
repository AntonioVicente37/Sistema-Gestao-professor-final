using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloDPLeciona
    {
            private int dpcod;
            private int dicod;
            private int procod;
            private string descricao;


            public ModeloDPLeciona()
            {
                this.DpCod = 0;
                this.DiCod = 0;
                this.procod = 0;
                this.Descricao = "";

            }
            public ModeloDPLeciona(int dpcod, int dicod, int procod, string tpdir)
            {
                this.DpCod = dpcod;
                this.DiCod = dicod;
                this.ProCod = procod;
                this.Descricao = tpdir;

            }

            public int DpCod
            {
                get { return dpcod; }
                set { dpcod = value; }
            }

            public int DiCod
            {
                get { return dicod; }
                set { dicod = value; }
            }

            public int ProCod
            {
                get { return procod; }
                set { procod = value; }
            }

            public string Descricao
            {
                get { return descricao; }
                set { descricao = value; }
            }
        }

   }


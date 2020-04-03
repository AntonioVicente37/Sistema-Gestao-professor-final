using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace BLL
{
    public class N_Dashboard
    {
        //private DALConexao conexao;

        //public N_Dashboard(DALConexao cx)
        //{
        //    this.conexao = cx;
        //}

        public void Dashboard(E_Dashboard obj)
        {
            D_Dashboard accesDB = new D_Dashboard();
            accesDB.SumarioDados(obj);
        }
    }
}

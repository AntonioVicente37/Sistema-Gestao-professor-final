using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Model;

namespace DAL
{
    public class D_Dashboard
    {
        //private DALConexao conexao;

        //public D_Dashboard(DALConexao cx)
        //{
        //    this.conexao = cx;
        //}
        SqlConnection Conexao = new SqlConnection("Data Source=LAPTOP-9OTDAJ5O\\SQLSERVER13;Initial Catalog=impalsgp; User iD=Tino;Password = 1234;");
        //SqlCommand cmd;
        public void SumarioDados(E_Dashboard obj)
        {
            SqlCommand cmd = new SqlCommand("DashboardDados",Conexao);         
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter nsala = new SqlParameter("@nsala",0);nsala.Direction = ParameterDirection.Output;
            SqlParameter ncurso = new SqlParameter("@ncurso", 0); ncurso.Direction = ParameterDirection.Output;
            SqlParameter ndisciplina = new SqlParameter("@ndisciplina", 0); ndisciplina.Direction = ParameterDirection.Output;
            SqlParameter nprofessor = new SqlParameter("@nprofessor", 0); nprofessor.Direction = ParameterDirection.Output;
            SqlParameter nturma = new SqlParameter("@nturma", 0); nturma.Direction = ParameterDirection.Output;
            SqlParameter ncoordenacao = new SqlParameter("@ncoordenacao", 0); ncoordenacao.Direction = ParameterDirection.Output;
            SqlParameter nprova = new SqlParameter("@nprova", 0); nprova.Direction = ParameterDirection.Output;

            cmd.Parameters.Add(nsala);
            cmd.Parameters.Add(ncurso);
            cmd.Parameters.Add(ndisciplina);
            cmd.Parameters.Add(nprofessor);
            cmd.Parameters.Add(nturma);
            cmd.Parameters.Add(ncoordenacao);
            cmd.Parameters.Add(nprova);

            Conexao.Open();
            cmd.ExecuteNonQuery();
            obj.CantSala1 = cmd.Parameters["@nsala"].Value.ToString();
            obj.CantCurso1 = cmd.Parameters["@ncurso"].Value.ToString();
            obj.CantDisciplina1 = cmd.Parameters["@ndisciplina"].Value.ToString();
            obj.CantProfessor1 = cmd.Parameters["@nprofessor"].Value.ToString();
            obj.CantTurma1 = cmd.Parameters["@nturma"].Value.ToString();
            obj.CantCoordenacao1 = cmd.Parameters["@ncoordenacao"].Value.ToString();
            obj.CantProva1 = cmd.Parameters["@nprova"].Value.ToString();

            Conexao.Close();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Modelo;

namespace DAL
{
    public  class DALPresenca
    {
        private DALConexao conexao;

        public DALPresenca(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloPresenca modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into t_preseProfessor (agente,presenca,professor,data,hora_entrada,hora_saida) values (@agente,@presenca,@prof,@data,@entra,@saida); select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@agente", modelo.Agente);
            cmd.Parameters.AddWithValue("@presenca", modelo.Presenca);    
            cmd.Parameters.AddWithValue("@prof", modelo.Professor);
            cmd.Parameters.AddWithValue("@data", modelo.Data);
            cmd.Parameters.AddWithValue("@entra", modelo.HEntrada);
            cmd.Parameters.AddWithValue("@saida", modelo.HSaida);
            conexao.Conectar();
            modelo.PreCod = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Deconectar();

        }
        public void Alterar(ModeloPresenca modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "Update t_preseProfessor set agente=@age,professor=@prof,presenca=@presenca,data=@data,hora_entrada=@entra,hora_saida=@saida where id_presenca = @codigo;";
            cmd.Parameters.AddWithValue("@codigo", modelo.PreCod);
            cmd.Parameters.AddWithValue("@age", modelo.Agente);
            cmd.Parameters.AddWithValue("@presenca", modelo.Presenca);
            cmd.Parameters.AddWithValue("@prof", modelo.Professor);
            cmd.Parameters.AddWithValue("@data", modelo.Data);
            cmd.Parameters.AddWithValue("@entra", modelo.HEntrada);
            cmd.Parameters.AddWithValue("@saida", modelo.HSaida);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Deconectar();          

        }
       
        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "Delete from t_preseProfessor where id_presenca=@codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Deconectar();
        }
        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from t_preseProfessor "+
            " where data like '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModeloPresenca CarregaModeloPresenca(int codigo)
        {

            ModeloPresenca modelo = new ModeloPresenca();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "Select * from t_preseProfessor where id_presenca=@codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.PreCod = Convert.ToInt32(registro["id_presenca"]);
                modelo.Presenca = Convert.ToString(registro["presenca"]);
                modelo.Agente = Convert.ToInt32(registro["agente"]);              
                modelo.Data = Convert.ToDateTime(registro["data"]);
                modelo.Professor = Convert.ToString(registro["professor"]);
                modelo.HEntrada = Convert.ToString(registro["hora_entrada"]);
                modelo.HSaida = Convert.ToString(registro["hora_saida"]);
              

            }
            conexao.Deconectar();
            return modelo;
        }
    }
}

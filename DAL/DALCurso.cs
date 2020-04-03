using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DALCurso
    {
        private DALConexao conexao;

        public DALCurso(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloCurso modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into t_curso (curso,area_formacao) values (@curso,@area); select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@area", modelo.AreFormacao);
            cmd.Parameters.AddWithValue("@curso", modelo.Curso);
         
            conexao.Conectar();
            modelo.CuCod = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Deconectar();

        }
        public void Alterar(ModeloCurso modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "Update t_curso set area_formacao=@area,curso=@curso where id_curso = @codigo;";
            cmd.Parameters.AddWithValue("@codigo", modelo.CuCod);
            cmd.Parameters.AddWithValue("@area", modelo.AreFormacao);
            cmd.Parameters.AddWithValue("@curso", modelo.Curso);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Deconectar();

        }
        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "Delete from t_curso where id_curso=@codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Deconectar();
        }
        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from t_curso where curso like '%" +
                valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        public int VerificaCurso(String valor)// 0 - não existe || numero > 0 existe
        {
            int r = 0;// 0 - não existe
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from t_curso where curso = @nome";
            cmd.Parameters.AddWithValue("@nome", valor);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                r = Convert.ToInt32(registro["id_curso"]);

            }
            conexao.Deconectar();
            return r;
        }
        public ModeloCurso CarregaModeloCurso(int codigo)
        {

            ModeloCurso modelo = new ModeloCurso();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "Select * from t_curso where id_curso=@codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.CuCod = Convert.ToInt32(registro["id_curso"]);
                modelo.AreFormacao = Convert.ToString(registro["area_formacao"]);
                modelo.Curso = Convert.ToString(registro["curso"]);
                

            }
            conexao.Deconectar();
            return modelo;
        }
    }
}

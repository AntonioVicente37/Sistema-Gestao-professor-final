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
    public class DALAnoletivo
    {
        private DALConexao conexao;

        public DALAnoletivo(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloAnoLetivo modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into t_ano_letivo (ano,descricao) values (@ano,@desc); select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@desc", modelo.Descricao);
            cmd.Parameters.AddWithValue("@ano", modelo.Ano);
            conexao.Conectar();
            modelo.AnoCod = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Deconectar();

        }
        
        public void Alterar(ModeloAnoLetivo modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "Update t_ano_letivo set ano=@ano,descricao=@desc where id_anoletivo = @codigo;";
            cmd.Parameters.AddWithValue("@codigo", modelo.AnoCod);
            cmd.Parameters.AddWithValue("@desc", modelo.Descricao);
            cmd.Parameters.AddWithValue("@ano", modelo.Ano);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Deconectar();

        }
        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "Delete from t_ano_letivo where id_anoletivo=@codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Deconectar();
        }
        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from t_ano_letivo where ano like '%" +
                valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        public int VerificaAno(String valor)// 0 - não existe || numero > 0 existe
        {
            int r = 0;// 0 - não existe
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from t_ano_letivo where ano = @nome";
            cmd.Parameters.AddWithValue("@nome", valor);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                r = Convert.ToInt32(registro["id_anoletivo"]);

            }
            conexao.Deconectar();
            return r;
        }
        public ModeloAnoLetivo CarregaModeloAnoLetivo(int codigo)
        {

            ModeloAnoLetivo modelo = new ModeloAnoLetivo();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "Select * from t_ano_letivo where id_anoletivo=@codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.AnoCod = Convert.ToInt32(registro["id_anoletivo"]);
                modelo.Ano = Convert.ToString(registro["ano"]);
                modelo.Descricao = Convert.ToString(registro["descricao"]);

            }
            conexao.Deconectar();
            return modelo;
        }
    }
}

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
    public class DALCordenacao
    {
        private DALConexao conexao;

        public DALCordenacao(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloCordenacao modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into t_cordenacao (num_agente,id_anoletivo,coordenacao) values (@agente,@ano,@coord); select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@agente", modelo.ProCod);
            cmd.Parameters.AddWithValue("@ano", modelo.AnoCod);
            cmd.Parameters.AddWithValue("@coord", modelo.Coordenacao);
            conexao.Conectar();
            modelo.CoCod = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Deconectar();

        }
        public void Alterar(ModeloCordenacao modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "Update t_cordenacao set  num_agente=@agente,id_anoletivo=@ano,coordenacao=@coord where id_coordenacao = @codigo;";
            cmd.Parameters.AddWithValue("@codigo", modelo.CoCod);
            cmd.Parameters.AddWithValue("@agente", modelo.ProCod);
            cmd.Parameters.AddWithValue("@ano", modelo.AnoCod);
            cmd.Parameters.AddWithValue("@coord", modelo.Coordenacao);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Deconectar();

        }
        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "Delete from t_cordenacao where id_coordenacao=@codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Deconectar();
        }
        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(" Select c.id_coordenacao,c.coordenacao,p.nome,a.ano"+ 
            " from t_cordenacao c inner join t_professor p on c.num_agente = p.num_agente inner join t_ano_letivo a on c.id_anoletivo = a.id_anoletivo"+
            " where coordenacao like '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        public int VerificaCoordenacao(String valor)// 0 - não existe || numero > 0 existe
        {
            int r = 0;// 0 - não existe
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from t_cordenacao where num_agente = @nome";
            cmd.Parameters.AddWithValue("@nome", valor);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                r = Convert.ToInt32(registro["id_coordenacao"]);

            }
            conexao.Deconectar();
            return r;
        }
        public ModeloCordenacao CarregaModeloCordenacao(int codigo)
        {

            ModeloCordenacao modelo = new ModeloCordenacao();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "Select * from t_cordenacao where id_coordenacao=@codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.CoCod = Convert.ToInt32(registro["id_coordenacao"]);
                modelo.Coordenacao = Convert.ToString(registro["coordenacao"]);
                modelo.ProCod = Convert.ToInt32(registro["num_agente"]);
                modelo.AnoCod = Convert.ToInt32(registro["id_anoletivo"]);

            }
            conexao.Deconectar();
            return modelo;
        }
    }
}

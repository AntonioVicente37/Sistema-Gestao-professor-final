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
    public  class DALMunicipio
    {
        private DALConexao conexao;

        public DALMunicipio(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloMunicipio modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into t_municipio (distrito,bairro,descricao) values (@dist,@bar,@desc); select @@IDENTITY;";        
            cmd.Parameters.AddWithValue("@dist", modelo.Distritio);
            cmd.Parameters.AddWithValue("@bar", modelo.Bairro);
            cmd.Parameters.AddWithValue("@desc", modelo.Descricao);
            conexao.Conectar();
            modelo.MuCod = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Deconectar();

        }
        public void Alterar(ModeloMunicipio modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "Update t_municipio set distrito=@dist,bairro=@bar,descricao=@desc where id_municipio = @codigo;";
            cmd.Parameters.AddWithValue("@codigo", modelo.MuCod);
            cmd.Parameters.AddWithValue("@desc", modelo.Descricao);
            cmd.Parameters.AddWithValue("@bar", modelo.Bairro);
            cmd.Parameters.AddWithValue("@dist", modelo.Distritio);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Deconectar();

        }
        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "Delete from t_municipio where id_municipio=@codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Deconectar();
        }
        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from t_municipio where distrito like '%" +
                valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        public ModeloMunicipio CarregaModeloMunicipio(int codigo)
        {

            ModeloMunicipio modelo = new ModeloMunicipio();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "Select * from t_municipio where id_municipio=@codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.MuCod = Convert.ToInt32(registro["id_municipio"]);
                modelo.Distritio = Convert.ToString(registro["distrito"]);
                modelo.Bairro = Convert.ToString(registro["bairro"]);
                modelo.Descricao = Convert.ToString(registro["descricao"]);

            }
            conexao.Deconectar();
            return modelo;
        }
    }
}

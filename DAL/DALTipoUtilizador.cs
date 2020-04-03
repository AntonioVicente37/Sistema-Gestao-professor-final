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
    public class DALTipoUtilizador
    {
        private DALConexao conexao;

        public DALTipoUtilizador(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloTipoUtilizador modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into t_tipoUtilizador (utilizador,dataCadastro,dataActulizacao) values (@util,@dataC,@dataA); select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@dataC", modelo.Datacad);
            cmd.Parameters.AddWithValue("@dataA", modelo.Dataatu);
            cmd.Parameters.AddWithValue("@util",modelo.Utilizador);
            conexao.Conectar();
            modelo.UtCod = Convert.ToInt32(cmd.ExecuteScalar()); 
            conexao.Deconectar();

        }
        public void Alterar(ModeloTipoUtilizador modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "Update t_tipoUtilizador set utilizador=@util,dataCadastro=@dataC,dataActulizacao=@dataA where id_tipoUtilizador = @codigo;";
            cmd.Parameters.AddWithValue("@codigo", modelo.UtCod);
            cmd.Parameters.AddWithValue("@dataC", modelo.Datacad);
            cmd.Parameters.AddWithValue("@dataA", modelo.Dataatu);
            cmd.Parameters.AddWithValue("@util", modelo.Utilizador);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Deconectar();

        }
        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "Delete from t_tipoUtilizador where id_tipoUtilizador=@codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Deconectar();
        }
        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from t_tipoUtilizador where utilizador like '%" +
                valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        public ModeloTipoUtilizador CarregaModeloTipoUtilizador(int codigo)
        {

            ModeloTipoUtilizador modelo = new ModeloTipoUtilizador();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "Select * from t_tipoUtilizador where id_tipoUtilizador=@codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.UtCod = Convert.ToInt32(registro["id_tipoUtilizador"]);
                modelo.Utilizador = Convert.ToString(registro["utilizador"]);
                modelo.Datacad = Convert.ToDateTime(registro["dataCadastro"]);
                modelo.Dataatu = Convert.ToDateTime(registro["dataActualizacao"]);

            }
            conexao.Deconectar();
            return modelo;
        }
    }
}

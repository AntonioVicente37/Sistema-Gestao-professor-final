using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Modelo;
using Modelo.Cache;

namespace DAL
{
    public class DALUtilizador
    {
        private DALConexao conexao;

        public DALUtilizador(DALConexao cx)
        {
            this.conexao = cx;
        }
        public bool EfectuarLogin(string user, string pass)
        {
            conexao.Conectar();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from t_Utilizador where username like @user and passworde like @pass ";
            cmd.Parameters.AddWithValue("@user", user);
            cmd.Parameters.AddWithValue("@pass", pass);
            cmd.CommandType = CommandType.Text;

            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                //receber dados do cargo
                while (registro.Read())
                {

                    UserLoginCache.Iduser = registro.GetInt32(0);
                    UserLoginCache.Cargo = registro.GetInt32(3);
                    UserLoginCache.Nome = registro.GetString(4);
                    UserLoginCache.Sobrenome = registro.GetString(5);
                    UserLoginCache.Email = registro.GetString(6);

                }
                return true;
            }
            else
                return false;

        }
        public void Incluir(ModeloUtilizador modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into t_Utilizador (username,passworde,id_tipoUtilizador,dataCadastro,dataActulizacao) values (@user,@pass,@util,@dataC,@dataA); select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@dataC", modelo.Datacad);
            cmd.Parameters.AddWithValue("@dataA", modelo.Dataatu);
            cmd.Parameters.AddWithValue("@util", modelo.TiCod);
            cmd.Parameters.AddWithValue("@user",modelo.Username);
            cmd.Parameters.AddWithValue("@pass",modelo.Password);
            conexao.Conectar();
            modelo.UtCod = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Deconectar();

        }
        public void Alterar(ModeloUtilizador modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "Update t_Utilizador set username=@user,passworde=pass,id_tipoUtilizador=@util,dataCadastro=@dataC,dataActulizacao=@dataA where id_Utilizador = @codigo;";
            cmd.Parameters.AddWithValue("@codigo", modelo.UtCod);
            cmd.Parameters.AddWithValue("@dataC", modelo.Datacad);
            cmd.Parameters.AddWithValue("@dataA", modelo.Dataatu);
            cmd.Parameters.AddWithValue("@util", modelo.TiCod);
            cmd.Parameters.AddWithValue("@user", modelo.Username);
            cmd.Parameters.AddWithValue("@pass", modelo.Password);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Deconectar();

        }
        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "Delete from t_Utilizador where id_Utilizador=@codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Deconectar();
        }
        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select u.id_Utilizador,u.username,u.passworde,u.nome,u.sobrenome,u.email,t.utilizador,u.dataCadastro,u.dataActualizacao "+
           " from t_Utilizador u inner join t_tipoUtilizador t on u.id_tipoUtilizador = t.id_tipoUtilizador "+
           " where username like '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        public ModeloUtilizador CarregaModeloUtilizador(int codigo)
        {

            ModeloUtilizador modelo = new ModeloUtilizador();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "Select * from t_Utilizador where id_Utilizador=@codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.UtCod = Convert.ToInt32(registro["id_Utilizador"]);
                modelo.TiCod = Convert.ToInt32(registro["id_tipoUtilizador"]);
                modelo.Username = Convert.ToString(registro["username"]);
                modelo.Password = Convert.ToString(registro["passworde"]);
                modelo.Datacad = Convert.ToDateTime(registro["dataCadastro"]);
                modelo.Dataatu = Convert.ToDateTime(registro["dataActualizacao"]);

            }
            conexao.Deconectar();
            return modelo;
        }
    }
}

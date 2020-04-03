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
    public class DALSala
    {
        public DALConexao conexao;

        public DALSala(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloSala modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into t_sala (sala,descricao) values (@numero,@desc); select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@desc", modelo.Descricao);
            cmd.Parameters.AddWithValue("@numero", modelo.SaNum);
            conexao.Conectar();
            modelo.SaCod = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Deconectar();

        }
        public void Alterar(ModeloSala modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "Update t_sala set sala=@numero,descricao=@desc where id_sala = @codigo;";
            cmd.Parameters.AddWithValue("@codigo", modelo.SaCod);
            cmd.Parameters.AddWithValue("@desc", modelo.Descricao);
            cmd.Parameters.AddWithValue("@numero", modelo.SaNum);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Deconectar();

        }
        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "Delete from t_sala where id_sala=@codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Deconectar();
        }
        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from t_sala where sala like '%" +
                valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        public int VerificaSala(String valor)// 0 - não existe || numero > 0 existe
        {
            int r = 0;// 0 - não existe
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from t_sala where sala = @nome";
            cmd.Parameters.AddWithValue("@nome", valor);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                r = Convert.ToInt32(registro["id_sala"]);

            }
            conexao.Deconectar();
            return r;
        }
        public ModeloSala CarregaModeloSala(int codigo)
        {

            ModeloSala modelo = new ModeloSala();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "Select * from t_sala where id_sala=@codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.SaCod = Convert.ToInt32(registro["id_sala"]);
                modelo.SaNum = Convert.ToString(registro["sala"]);
                modelo.Descricao = Convert.ToString(registro["descricao"]);

            }
            conexao.Deconectar();
            return modelo;
        }
    }
}

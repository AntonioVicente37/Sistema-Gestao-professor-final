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
    public class DALDPLeciona
    {
        private DALConexao conexao;

        public DALDPLeciona(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloDPLeciona modelo)
        {
            SqlCommand cmd = new SqlCommand(); 
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into t_dp_leciona (id_disciplina,num_agente,descricao) values (@disciplina,@agente,@desc); select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@agente", modelo.ProCod);
            cmd.Parameters.AddWithValue("@disciplina", modelo.DiCod);
            cmd.Parameters.AddWithValue("@desc", modelo.Descricao);
            conexao.Conectar();
            modelo.DpCod = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Deconectar();

        }
        public void Alterar(ModeloDPLeciona modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "Update t_dp_leciona set id_disciplina=@disciplina,num_agente=@agente,descricao=@desc where id_dp_leciona = @codigo;";
            cmd.Parameters.AddWithValue("@codigo", modelo.DpCod);
            cmd.Parameters.AddWithValue("@agente", modelo.ProCod);
            cmd.Parameters.AddWithValue("@disciplina", modelo.DiCod);
            cmd.Parameters.AddWithValue("@desc", modelo.Descricao);

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Deconectar();

        }
        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "Delete from t_dp_leciona where id_dp_leciona=@codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Deconectar();
        }
        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("  select t.id_dp_leciona,m.disciplina,p.nome,t.descricao "+
           " from t_dp_leciona t inner join t_professor p on t.num_agente = p.num_agente inner join t_disciplina m on t.id_disciplina = m.id_disciplina"+
           " where p.nome like '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        public int VerificaDisciplinaLec(String valor,String resto)// 0 - não existe || numero > 0 existe
        {
            int r = 0;// 0 - não existe
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from t_dp_leciona where id_disciplina = @nome and  num_agente=@professor";
            cmd.Parameters.AddWithValue("@nome", valor);
            cmd.Parameters.AddWithValue("@professor", resto);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                r = Convert.ToInt32(registro["id_dp_leciona"]);

            }
            conexao.Deconectar();
            return r;
        }
        public ModeloDPLeciona CarregaModeloDPLeciona(int codigo)
        {

            ModeloDPLeciona modelo = new ModeloDPLeciona();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "Select * from t_dp_leciona where id_dp_leciona=" + codigo.ToString();
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.DpCod = Convert.ToInt32(registro["id_dp_leciona"]);
                modelo.ProCod = Convert.ToInt32(registro["num_agente"]);
                modelo.DiCod = Convert.ToInt32(registro["id_disciplina"]);
                modelo.Descricao = Convert.ToString(registro["descricao"]);


            }
            conexao.Deconectar();
            return modelo;
        }
    }
}

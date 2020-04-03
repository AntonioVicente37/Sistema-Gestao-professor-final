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
    public class DALTPTurma
    {
        private DALConexao conexao;

        public DALTPTurma(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloTPTurma modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into t_p_aulas (id_turma,num_agente,director_turma) values (@turma,@agente,@dir); select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@agente", modelo.ProCod);
            cmd.Parameters.AddWithValue("@dir", modelo.TpDir);
            cmd.Parameters.AddWithValue("@turma", modelo.TuCod);
            conexao.Conectar();
            modelo.TpCod = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Deconectar();

        }
        public void Alterar(ModeloTPTurma modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "Update t_p_aulas set id_turma=@turma,num_agente=@agente,director_turma=@dir where id_aulas = @codigo;";
            cmd.Parameters.AddWithValue("@codigo", modelo.TpCod);
            cmd.Parameters.AddWithValue("@agente", modelo.ProCod);
            cmd.Parameters.AddWithValue("@dir", modelo.TpDir);
            cmd.Parameters.AddWithValue("@turma", modelo.TuCod);

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Deconectar();

        }
        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "Delete from t_p_aulas where id_aulas=@codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Deconectar();
        }
        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select t.id_aulas,m.turma,p.nome,t.director_turma "+
            " from t_p_aulas t inner join t_professor p on t.num_agente = p.num_agente inner join t_turma m on t.id_turma = m.id_turma "+
            " where p.nome like  '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        public int VerificaTurmaLec(String valor, String resto, String turma)// 0 - não existe || numero > 0 existe
        {
            int r = 0;// 0 - não existe
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from t_p_aulas where id_turma = @nome and  num_agente=@professor and director_turma =@turma";
            cmd.Parameters.AddWithValue("@nome", valor);
            cmd.Parameters.AddWithValue("@professor", resto);
            cmd.Parameters.AddWithValue("@turma", turma);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                r = Convert.ToInt32(registro["id_aulas"]);

            }
            conexao.Deconectar();
            return r;
        }
        public int VerificaDireitorTurma(String valor)// 0 - não existe || numero > 0 existe
        {
            int r = 0;// 0 - não existe
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from t_p_aulas where director_turma = @nome";
            cmd.Parameters.AddWithValue("@nome", valor);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                r = Convert.ToInt32(registro["id_aulas"]);

            }
            conexao.Deconectar();
            return r;
        }
        public ModeloTPTurma CarregaModeloTPTurma(int codigo)
        {

            ModeloTPTurma modelo = new ModeloTPTurma();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "Select * from t_p_aulas where id_aulas=" + codigo.ToString();
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.TpCod = Convert.ToInt32(registro["id_aulas"]);
                modelo.ProCod = Convert.ToInt32(registro["num_agente"]);
                modelo.TuCod = Convert.ToInt32(registro["id_turma"]);
                modelo.TpDir = Convert.ToString(registro["director_turma"]);
             

            }
            conexao.Deconectar();
            return modelo;
        }
    }
}

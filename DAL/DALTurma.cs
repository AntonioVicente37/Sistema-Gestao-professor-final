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
     public class DALTurma
    {
        private DALConexao conexao;

        public DALTurma(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloTurma modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into t_turma (turma,id_curso,id_anoletivo,periodo) values (@turma,@curso,@ano,@periodo); select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@turma", modelo.Turma);
            cmd.Parameters.AddWithValue("@curso", modelo.CuCod);
            cmd.Parameters.AddWithValue("@ano", modelo.AnoCod);       
            cmd.Parameters.AddWithValue("@periodo", modelo.Periodo);
            conexao.Conectar();
            modelo.TuCod = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Deconectar();

        }
        public void Alterar(ModeloTurma modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "Update t_turma set id_curso=(@curso),id_anoletivo=(@ano),turma=(@turma),periodo=(@periodo) where id_turma = @codigo;";
            cmd.Parameters.AddWithValue("@codigo", modelo.TuCod);
            cmd.Parameters.AddWithValue("@curso", modelo.CuCod);
            cmd.Parameters.AddWithValue("@ano", modelo.AnoCod);
            cmd.Parameters.AddWithValue("@turma", modelo.Turma);
            cmd.Parameters.AddWithValue("@periodo", modelo.Periodo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Deconectar();

        }
        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "Delete from t_turma where id_turma=(@codigo)";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Deconectar();
        }
        public DataTable Localizar(String valor)
        {

            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select n.id_turma, n.turma, c.curso, n.periodo, s.ano "+
                " from t_turma n inner join t_curso c on n.id_curso = c.id_curso inner join t_ano_letivo s on n.id_anoletivo = s.id_anoletivo "+
                " where n.turma like '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        public int VerificaTurma(String valor)// 0 - não existe || numero > 0 existe
        {
            int r = 0;// 0 - não existe
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from t_turma where turma = @nome ";
            cmd.Parameters.AddWithValue("@nome", valor);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                r = Convert.ToInt32(registro["id_turma"]);

            }
            conexao.Deconectar();
            return r;
        }
        public ModeloTurma CarregaModeloTurma(int codigo)
        {

            ModeloTurma modelo = new ModeloTurma();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "Select * from t_turma where id_turma=" + codigo.ToString();

            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.TuCod = Convert.ToInt32(registro["id_turma"]);
                modelo.CuCod = Convert.ToInt32(registro["id_curso"]);
                modelo.AnoCod = Convert.ToInt32(registro["id_anoletivo"]);
                modelo.Turma = Convert.ToString(registro["turma"]);
                modelo.Periodo = Convert.ToString(registro["periodo"]);
                

            }
            conexao.Deconectar();
            return modelo;
        }
    }
}

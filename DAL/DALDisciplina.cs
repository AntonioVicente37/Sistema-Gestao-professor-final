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
    public class DALDisciplina
    {
        private DALConexao conexao;

        public DALDisciplina(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloDisciplina modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into t_disciplina (disciplina,id_curso,id_coordenacao,componente,carga_horaria) values (@nome,@curso,@corde,@compo,@carga); select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@corde", modelo.CoCod);
            cmd.Parameters.AddWithValue("@curso", modelo.CuCod);
            cmd.Parameters.AddWithValue("@nome", modelo.Disciplina);
            cmd.Parameters.AddWithValue("@compo", modelo.Componente);
            cmd.Parameters.AddWithValue("@carga", modelo.Carga);
            conexao.Conectar();
            modelo.DiCod = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Deconectar();

        }
        public void Alterar(ModeloDisciplina modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "Update t_disciplina set id_coordenacao=@corde,disciplina=@nome,id_curso=@curso,carga_horaria=@carga,componente=@compo where id_disciplina = @codigo;";
            cmd.Parameters.AddWithValue("@codigo", modelo.DiCod);
            cmd.Parameters.AddWithValue("@corde", modelo.CoCod);
            cmd.Parameters.AddWithValue("@curso", modelo.CuCod);
            cmd.Parameters.AddWithValue("@nome", modelo.Disciplina);
            cmd.Parameters.AddWithValue("@compo", modelo.Componente);
            cmd.Parameters.AddWithValue("@carga", modelo.Carga);

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Deconectar();

        }
        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "Delete from t_disciplina where id_disciplina=@codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Deconectar();
        }
        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select d.id_disciplina, d.disciplina,p.curso ,c.coordenacao, d.componente, d.carga_horaria "+
             " from t_disciplina d inner join t_curso p on d.id_curso = p.id_curso inner join t_cordenacao c on d.id_coordenacao = c.id_coordenacao "+
            " where d.disciplina like   '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        public int VerificaDisciplina(String valor)// 0 - não existe || numero > 0 existe
        {
            int r = 0;// 0 - não existe
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from t_disciplina where disciplina = @nome";
            cmd.Parameters.AddWithValue("@nome", valor);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                r = Convert.ToInt32(registro["id_disciplina"]);

            }
            conexao.Deconectar();
            return r;
        }
        public ModeloDisciplina CarregaModeloDisciplina(int codigo)
        {

            ModeloDisciplina modelo = new ModeloDisciplina();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "Select * from t_disciplina where id_disciplina=@codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.DiCod = Convert.ToInt32(registro["id_disciplina"]);
                modelo.Disciplina = Convert.ToString(registro["disciplina"]);
                modelo.CuCod = Convert.ToInt32(registro["id_curso"]);
                modelo.CoCod = Convert.ToInt32(registro["id_coordenacao"]);
                modelo.Componente = Convert.ToString(registro["componente"]);
                modelo.Carga = Convert.ToString(registro["carga_horaria"]);


            }
            conexao.Deconectar();
            return modelo;
        }
    }
}

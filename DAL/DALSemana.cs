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
    public class DALSemana
    {
        private DALConexao conexao;

        public DALSemana(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloSemana modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into t_horario (id_turma,num_agente,id_sala,id_disciplina,id_anoletivo,semana,hora_inicial,hora_final,tempo) values" +
                              "(@turma,@professor,@sala,@disciplina,@ano,@semana,@inicial,@final,@tempo); select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@turma", modelo.TuCod);
            cmd.Parameters.AddWithValue("@sala", modelo.SaCod);
            cmd.Parameters.AddWithValue("@professor", modelo.ProCod);
            cmd.Parameters.AddWithValue("@disciplina", modelo.DiCod);
            cmd.Parameters.AddWithValue("@ano", modelo.AnoCod);
            cmd.Parameters.AddWithValue("@semana", modelo.Semana);
            cmd.Parameters.AddWithValue("@inicial", modelo.HInicial);
            cmd.Parameters.AddWithValue("@final", modelo.HFinal);
            cmd.Parameters.AddWithValue("@tempo", modelo.Tempo);
          
            conexao.Conectar();
            modelo.SeCod = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Deconectar();

        }
        public void Alterar(ModeloSemana modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "Update t_horario set id_turma=@turma,id_sala=@sala,num_agente=@professor,id_anoletivo=@ano,id_disciplina=@disciplina, " +
                "semana=@semana,hora_inicial=@inicial,hora_final=@final,tempo=@tempo where id_semana = @codigo;";
            cmd.Parameters.AddWithValue("@codigo", modelo.SeCod);
            cmd.Parameters.AddWithValue("@turma", modelo.TuCod);
            cmd.Parameters.AddWithValue("@sala", modelo.SaCod);
            cmd.Parameters.AddWithValue("@professor", modelo.ProCod);
            cmd.Parameters.AddWithValue("@disciplina", modelo.DiCod);
            cmd.Parameters.AddWithValue("@ano", modelo.AnoCod);
            cmd.Parameters.AddWithValue("@semana", modelo.Semana);
            cmd.Parameters.AddWithValue("@inicial", modelo.HInicial);
            cmd.Parameters.AddWithValue("@final", modelo.HFinal);
            cmd.Parameters.AddWithValue("@tempo", modelo.Tempo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Deconectar();

        }
        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "Delete from t_horario where id_semana=@codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Deconectar();
        }
        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select  s.id_semana, s.semana, p.nome,t.turma,l.sala ,d.disciplina,a.ano,s.tempo, s.hora_inicial,s.hora_final "+
            " from t_horario s inner join t_turma t on s.id_turma = t.id_turma inner join t_disciplina d on s.id_disciplina = d.id_disciplina inner join t_sala l on s.id_sala = l.id_sala inner "+
            " join t_professor p on s.num_agente = p.num_agente inner join t_ano_letivo a on s.id_anoletivo = a.id_anoletivo "+
            " where p.nome like '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        //public int VerificaSala(String valor)// 0 - não existe || numero > 0 existe
        //{
        //    int r = 0;// 0 - não existe
        //    SqlCommand cmd = new SqlCommand();
        //    cmd.Connection = conexao.ObjetoConexao;
        //    cmd.CommandText = "select * from t_horario where sala = @nome";
        //    cmd.Parameters.AddWithValue("@nome", valor);
        //    conexao.Conectar();
        //    SqlDataReader registro = cmd.ExecuteReader();
        //    if (registro.HasRows)
        //    {
        //        registro.Read();
        //        r = Convert.ToInt32(registro["id_semana"]);

        //    }
        //    conexao.Deconectar();
        //    return r;
        //}
        public ModeloSemana CarregaModeloSemana(int codigo)
        {

            ModeloSemana modelo = new ModeloSemana();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "Select * from t_horario where id_semana=" + codigo.ToString();
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.SeCod = Convert.ToInt32(registro["id_semana"]);
                modelo.TuCod = Convert.ToInt32(registro["id_turma"]);
                modelo.SaCod = Convert.ToInt32(registro["id_sala"]);
                modelo.ProCod = Convert.ToInt32(registro["num_agente"]);
                modelo.AnoCod = Convert.ToInt32(registro["id_anoletivo"]);
                modelo.DiCod = Convert.ToInt32(registro["id_disciplina"]);
                modelo.Semana = Convert.ToString(registro["semana"]);
                modelo.HInicial = Convert.ToString(registro["hora_inicial"]);
                modelo.HFinal = Convert.ToString(registro["hora_final"]);
                modelo.Tempo = Convert.ToString(registro["tempo"]);


            }
            conexao.Deconectar();
            return modelo;
        }
    }
}

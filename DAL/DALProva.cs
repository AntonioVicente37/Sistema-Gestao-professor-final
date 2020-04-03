using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DALProva
    {
        private DALConexao conexao;

        public DALProva(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloProva modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into t_Mprova (id_turma,num_agente,id_disciplina,id_sala,id_coordenacao,periodo,tipo_prova,data,hora_inicial,hora_final)"+
                               " values (@turma,@professor,@disciplina,@sala,@coord,@periodo,@tprova,@data,@inicial,@final); select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@turma", modelo.TuCod);
            cmd.Parameters.AddWithValue("@professor", modelo.ProCod);
            cmd.Parameters.AddWithValue("@disciplina", modelo.DiCod);          
            cmd.Parameters.AddWithValue("@coord",modelo.CooCod);
            cmd.Parameters.AddWithValue("@inicial", modelo.HInicial);
            cmd.Parameters.AddWithValue("@final", modelo.HFinal);
            cmd.Parameters.AddWithValue("@sala", modelo.SaCod);
            cmd.Parameters.AddWithValue("@tprova", modelo.Tipo);
            cmd.Parameters.AddWithValue("@data",modelo.Data);
            cmd.Parameters.AddWithValue("@periodo",modelo.Periodo);
            conexao.Conectar();
            modelo.PvCod = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Deconectar();

        }
        public void Alterar(ModeloProva modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "Update t_Mprova set id_turma=@turma,id_sala=@sala,num_agente=@professor,periodo=@periodo,id_disciplina=@disciplina,id_coordenacao=@coord,hora_inicial=@inicial,hora_final=@final,tipo_prova=@tprova,data=@data where id_prova = @codigo;";
            cmd.Parameters.AddWithValue("@codigo",modelo.PvCod);
            cmd.Parameters.AddWithValue("@turma", modelo.TuCod);
            cmd.Parameters.AddWithValue("@professor", modelo.ProCod);
            cmd.Parameters.AddWithValue("@disciplina", modelo.DiCod);            
            cmd.Parameters.AddWithValue("@coord", modelo.CooCod);
            cmd.Parameters.AddWithValue("@inicial", modelo.HInicial);
            cmd.Parameters.AddWithValue("@final", modelo.HFinal);
            cmd.Parameters.AddWithValue("@sala", modelo.SaCod);            
            cmd.Parameters.AddWithValue("@tprova", modelo.Tipo);
            cmd.Parameters.AddWithValue("@data", modelo.Data);
            cmd.Parameters.AddWithValue("@periodo", modelo.Periodo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Deconectar();

        }
        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "Delete from t_Mprova where id_prova=@codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Deconectar();
        }
        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select  v.id_prova, p.nome,t.turma, d.disciplina, l.sala,c.coordenacao,v.tipo_prova,v.periodo,v.data,v.hora_inicial,v.hora_final "+ 
            " from t_Mprova v inner join t_turma t on v.id_turma = t.id_turma inner join t_professor p on v.num_agente = p.num_agente inner join t_disciplina d on v.id_disciplina = d.id_disciplina inner "+
            " join t_cordenacao c on v.id_coordenacao = c.id_coordenacao inner join t_sala l on v.id_sala = l.id_sala"+
            " where p.nome like '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        public ModeloProva CarregaModeloProva(int codigo)
        {

            ModeloProva modelo = new ModeloProva();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "Select * from t_Mprova where id_prova=@codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.PvCod = Convert.ToInt32(registro["id_prova"]);
                modelo.SaCod = Convert.ToInt32(registro["id_sala"]);
                modelo.TuCod = Convert.ToInt32(registro["id_turma"]);
                modelo.CooCod = Convert.ToInt32(registro["id_coordenacao"]);               
                modelo.ProCod = Convert.ToInt32(registro["num_agente"]);
                modelo.DiCod = Convert.ToInt32(registro["id_disciplina"]);              
                modelo.HInicial = Convert.ToString(registro["hora_inicial"]);
                modelo.HFinal = Convert.ToString(registro["hora_final"]);
                modelo.Tipo = Convert.ToString(registro["tipo_prova"]);
                modelo.Periodo = Convert.ToString(registro["periodo"]);
                modelo.Data = Convert.ToDateTime(registro["data"]);


            }
            conexao.Deconectar();
            return modelo;
        }
    }
}

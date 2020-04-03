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
    public class DALProfessores
    {
        private DALConexao conexao;

        public DALProfessores(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloProfessor modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into t_professor (num_agente,id_municipio,nome,telefone,B_I,foto,email,sexo,dataCadastro,dataActualizacao) values (@agente,@municipio,@nome,@fone,@bi,@foto,@email,@sexo,@dataC,@dataA); select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@agente", modelo.NumAgente);
            cmd.Parameters.AddWithValue("@municipio", modelo.MuCod);
            cmd.Parameters.AddWithValue("@nome", modelo.Penome);
            cmd.Parameters.AddWithValue("@fone", modelo.Petelefone);
            cmd.Parameters.AddWithValue("@bi", modelo.PeBI);
            cmd.Parameters.Add("@foto", System.Data.SqlDbType.Image);
            if (modelo.Pefoto == null)
            {
                cmd.Parameters["@foto"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@foto"].Value = modelo.Pefoto;
            }
            cmd.Parameters.AddWithValue("@email", modelo.Peemail);
            cmd.Parameters.AddWithValue("@sexo", modelo.Pesexo);
            cmd.Parameters.AddWithValue("dataC", modelo.DataCadastro);
            cmd.Parameters.AddWithValue("@dataA", modelo.DataAtualizacao);
            conexao.Conectar();
            //modelo.PeCod = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.ExecuteNonQuery();
            conexao.Deconectar();

        }
        public void Alterar(ModeloProfessor modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "Update  t_professor set id_municipio=(@municipio),nome=(@nome),telefone=(@fone),B_I=(@bi),foto=(@foto),email=(@email),sexo=(@sexo),dataCadastro=(@dataC),dataActualizacao=(@dataA) Where num_agente=(@codigo);";
            cmd.Parameters.AddWithValue("@codigo", modelo.NumAgente);
            cmd.Parameters.AddWithValue("@municipio", modelo.MuCod);
            cmd.Parameters.AddWithValue("@nome", modelo.Penome);
            cmd.Parameters.AddWithValue("@fone", modelo.Petelefone);
            cmd.Parameters.AddWithValue("@bi", modelo.PeBI);
            cmd.Parameters.Add("@foto", System.Data.SqlDbType.Image);
            if (modelo.Pefoto == null)
            {
                cmd.Parameters["@foto"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@foto"].Value = modelo.Pefoto;
            }
            cmd.Parameters.AddWithValue("@email", modelo.Peemail);
            cmd.Parameters.AddWithValue("@sexo", modelo.Pesexo);
            cmd.Parameters.AddWithValue("dataC", modelo.DataCadastro);
            cmd.Parameters.AddWithValue("@dataA", modelo.DataAtualizacao);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Deconectar();

        }
        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "Delete from t_professor where num_agente=(@codigo)";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Deconectar();
        }
        public DataTable Localizar(String valor)
        {

            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(" select  p.num_agente,p.nome,p.telefone,p.B_I,m.bairro,p.foto,p.sexo,p.email,p.dataCadastro,p.dataActualizacao"+
           " from t_professor p inner join t_municipio m on p.id_municipio = m.id_municipio"+
           " where nome like '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        public DataTable LocalizarPorPresenca(int presenca)
        {     
            
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select t.id_presenca,t.agente,p.nome,t.presenca,t.data,t.hora_entrada,t.hora_saida " +
            " from t_preseProfessor t inner join t_professor p on t.num_agente = p.num_agente " +
            " where t.id_presenca like " + presenca.ToString(), conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        public ModeloProfessor CarregaModeloProfessor(int codigo)
        {

            ModeloProfessor modelo = new ModeloProfessor();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "Select * from t_professor where num_agente=" + codigo.ToString();
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.NumAgente = Convert.ToInt32(registro["num_agente"]);
                modelo.MuCod = Convert.ToInt32(registro["id_municipio"]);
                modelo.Penome = Convert.ToString(registro["nome"]);
                modelo.Petelefone = Convert.ToString(registro["telefone"]);
                modelo.PeBI = Convert.ToString(registro["B_I"]);
                modelo.Peemail = Convert.ToString(registro["email"]);
                modelo.Pesexo = Convert.ToString(registro["sexo"]);
                modelo.DataCadastro = Convert.ToDateTime(registro["dataCadastro"]);
                modelo.DataAtualizacao = Convert.ToDateTime(registro["dataActualizacao"]);
                try
                {
                    modelo.Pefoto = (byte[])registro["foto"];
                }
                catch { }

            }
            conexao.Deconectar();
            return modelo;
        }
    }
}

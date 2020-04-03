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
    public class DALSecretariado
    {
        private DALConexao conexao;

        public DALSecretariado(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloSecretariado modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into t_Secretariado (id_municipio,nome,telefone,B_I,foto,email,sexo,dataCadastro,dataActualizacao) values (@municipio,@nome,@fone,@bi,@foto,@email,@sexo,@dataC,@dataA); select @@IDENTITY;";
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
        public void Alterar(ModeloSecretariado modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "Update  t_Secretariado set id_municipio=(@municipio),nome=(@nome),telefone=(@fone),B_I=(@bi),foto=(@foto),email=(@email),sexo=(@sexo),dataCadastro=(@dataC),dataActualizacao=(@dataA) Where id_secretariado=(@codigo);";
            cmd.Parameters.AddWithValue("@codigo", modelo.SecCod);
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
            cmd.CommandText = "Delete from t_Secretariado where id_secretariado=(@codigo)";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Deconectar();
        }
        public DataTable Localizar(String valor)
        {

            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(" select  d.id_secretariado,d.nome,d.telefone,d.B_I,m.bairro,d.foto,d.sexo,d.email,d.dataCadastro,d.dataActualizacao" +
          " from t_Secretariado d inner join t_municipio m on d.id_municipio = m.id_municipio" +
          "  where nome like '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        public ModeloSecretariado CarregaModeloPSecretariado(int codigo)
        {

            ModeloSecretariado modelo = new ModeloSecretariado();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "Select * from t_Secretariado where id_secretariado=" + codigo.ToString();
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.SecCod = Convert.ToInt32(registro["id_secretariado"]);
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

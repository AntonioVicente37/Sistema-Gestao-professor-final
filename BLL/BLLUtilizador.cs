using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Modelo;
using DAL;

namespace BLL
{
    public class BLLUtilizador
    {
        private DALConexao conexao;

        public BLLUtilizador(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloUtilizador modelo)
        {
            if (modelo.Password.Trim().Length == 0)
            {
                throw new Exception("informe a password do usuário");
            }

            if (modelo.Username.Trim().Length == 0)
            {
                throw new Exception("O informe o nome do usuário");
            }

            if (modelo.TiCod <= 0)
            {
                throw new Exception("O nome do utilizador é obrigatório");
            }
            DALUtilizador obj = new DALUtilizador(conexao);
            obj.Incluir(modelo);
        }
        public void Alterar(ModeloUtilizador modelo)
        {
            if (modelo.UtCod <= 0)
            {
                throw new Exception("O código do utilizador é obrigatório");
            }
            if (modelo.Password.Trim().Length == 0)
            {
                throw new Exception("informe a password do usuário");
            }

            if (modelo.Username.Trim().Length == 0)
            {
                throw new Exception("O informe o nome do usuário");
            }

            if (modelo.TiCod <= 0)
            {
                throw new Exception("O nome do utilizador é obrigatório");
            }
            DALUtilizador obj = new DALUtilizador(conexao);
            obj.Alterar(modelo);
        }
        public void Excluir(int codigo)
        {
            DALUtilizador obj = new DALUtilizador(conexao);
            obj.Excluir(codigo);
        }
        public DataTable Localizar(String valor)
        {
            DALUtilizador obj = new DALUtilizador(conexao);
            return obj.Localizar(valor);
        }
        public ModeloUtilizador CarregaModeloUtilizador(int codigo)
        {
            DALUtilizador obj = new DALUtilizador(conexao);
            return obj.CarregaModeloUtilizador(codigo);
        }
        public bool LoginUser(string user, string pass)
        {
            DALUtilizador modelo = new DALUtilizador(conexao);
            return modelo.EfectuarLogin(user, pass);
        }
    }
}

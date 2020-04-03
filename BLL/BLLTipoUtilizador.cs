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
    public class BLLTipoUtilizador
    {
        private DALConexao conexao;
        public BLLTipoUtilizador(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloTipoUtilizador modelo)
        {
            
            if (modelo.Utilizador.Trim().Length == 0)
            {
                throw new Exception("O nome do utilizador é obrigatório");
            }
           
            DALTipoUtilizador obj = new DALTipoUtilizador(conexao);
            obj.Incluir(modelo);
        }
        public void Alterar(ModeloTipoUtilizador modelo)
        {
            if (modelo.UtCod <= 0)
            {
                throw new Exception("O código do utilizador é obrigatório");
            }

            if (modelo.Utilizador.Trim().Length == 0)
            {
                throw new Exception("O nome do utilizador é obrigatório");
            }
            DALTipoUtilizador obj = new DALTipoUtilizador(conexao);
            obj.Alterar(modelo);
        }
        public void Excluir(int codigo)
        {
            DALTipoUtilizador obj = new DALTipoUtilizador(conexao);
            obj.Excluir(codigo);
        }
        public DataTable Localizar(String valor)
        {
            DALTipoUtilizador obj = new DALTipoUtilizador(conexao);
            return obj.Localizar(valor);
        }
        public ModeloTipoUtilizador CarregaModeloTipoUtilizador(int codigo)
        {
            DALTipoUtilizador obj = new DALTipoUtilizador(conexao);
            return obj.CarregaModeloTipoUtilizador(codigo);
        }
    }
}

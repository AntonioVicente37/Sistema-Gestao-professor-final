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
   public class BLLSala
    {
        private DALConexao conexao;

        public BLLSala(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloSala modelo)
        {
            if (modelo.SaNum.Trim().Length == 0)
            {
                throw new Exception("O numero da sala é obrigatório");
            }
            DALSala obj = new DALSala(conexao);
            obj.Incluir(modelo);
        }
        public void Alterar(ModeloSala modelo)
        {
            if (modelo.SaCod <= 0)
            {
                throw new Exception("O código da sala é obrigatório");
            }
            if (modelo.SaNum.Trim().Length == 0)
            {
                throw new Exception("O numero da sala é obrigatório");
            }
            DALSala obj = new DALSala(conexao);
            obj.Alterar(modelo);
        }
        public void Excluir(int codigo)
        {
            DALSala obj = new DALSala(conexao);
            obj.Excluir(codigo);
        }
        public DataTable Localizar(String valor)
        {
            DALSala obj = new DALSala(conexao);
            return obj.Localizar(valor);
        }
        public int VerificarSala(String valor)
        {
            DALSala DALobj = new DALSala(conexao);
            return DALobj.VerificaSala(valor);
        }
        public ModeloSala CarregaModeloSala(int codigo)
        {
            DALSala obj = new DALSala(conexao);
            return obj.CarregaModeloSala(codigo);
        }

    }
}

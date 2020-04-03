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
    public class BLLAnoLetivo
    {
        private DALConexao conexao;
        /// <summary>
        /// / testando o primerio commit de atualização
        /// </summary>
        public BLLAnoLetivo(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloAnoLetivo modelo)
        {
            if (modelo.Ano.Trim().Length == 0)
            {
                throw new Exception("O ano letivo é obrigatório");
            }
            DALAnoletivo obj = new DALAnoletivo(conexao);
            obj.Incluir(modelo);
        }
        public void Alterar(ModeloAnoLetivo modelo)
        {
            if (modelo.AnoCod <= 0)
            {
                throw new Exception("O código do ano letivo é obrigatório");
            }
            if (modelo.Ano.Trim().Length == 0)
            {
                throw new Exception("O ano letivo é obrigatório");
            }
            DALAnoletivo obj = new DALAnoletivo(conexao);
            obj.Alterar(modelo);
        }
        public void Excluir(int codigo)
        {
            DALAnoletivo obj = new DALAnoletivo(conexao);
            obj.Excluir(codigo);
        }
        public DataTable Localizar(String valor)
        {
            DALAnoletivo obj = new DALAnoletivo(conexao);
            return obj.Localizar(valor);
        }
        public int VerificarAno(String valor)
        {
            DALAnoletivo DALobj = new DALAnoletivo(conexao);
            return DALobj.VerificaAno(valor);
        }
        public ModeloAnoLetivo CarregaModeloAnoletivo(int codigo)
        {
            DALAnoletivo obj = new DALAnoletivo(conexao);
            return obj.CarregaModeloAnoLetivo(codigo);
        }
    }
}

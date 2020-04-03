using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using DAL;
using System.Data;

namespace BLL
{
    
     public class BLLCordenacao
    {
        private DALConexao conexao;
        public BLLCordenacao(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloCordenacao modelo)
        {
            if (modelo.Coordenacao.Trim().Length == 0)
            {
                throw new Exception("O nome da coordenação é obrigatório");
            }
            if (modelo.AnoCod <= 0)
            {
                throw new Exception("O ano letivo é obrigatório");
            }
            if (modelo.ProCod <= 0)
            {
                throw new Exception("O nome do professor é obrigatório");
            }
            DALCordenacao obj = new DALCordenacao(conexao);
            obj.Incluir(modelo);
        }
        public void Alterar(ModeloCordenacao modelo)
        {
            if (modelo.CoCod <= 0)
            {
                throw new Exception("O código da sala é obrigatório");
            }
            if (modelo.Coordenacao.Trim().Length == 0)
            {
                throw new Exception("O nome da coordenação é obrigatório");
            }
            if (modelo.AnoCod <= 0)
            {
                throw new Exception("O ano letivo é obrigatório");
            }
            if (modelo.ProCod <= 0)
            {
                throw new Exception("O nome do professor é obrigatório");
            }
            DALCordenacao obj = new DALCordenacao(conexao);
            obj.Alterar(modelo);
        }
        public void Excluir(int codigo)
        {
            DALCordenacao obj = new DALCordenacao(conexao);
            obj.Excluir(codigo);
        }
        public DataTable Localizar(String valor)
        {
            DALCordenacao obj = new DALCordenacao(conexao);
            return obj.Localizar(valor);
        }
        public int VerificaCoordenacao(String valor)
        {
            DALCordenacao DALobj = new DALCordenacao(conexao);
            return DALobj.VerificaCoordenacao(valor);
        }
        public ModeloCordenacao CarregaModeloCodenacao(int codigo)
        {
            DALCordenacao obj = new DALCordenacao(conexao);
            return obj.CarregaModeloCordenacao(codigo);
        }
    }
}

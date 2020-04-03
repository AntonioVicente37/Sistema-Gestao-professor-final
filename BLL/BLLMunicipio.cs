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
    public class BLLMunicipio
    {
        private DALConexao conexao;

        public BLLMunicipio(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloMunicipio modelo)
        {
            if (modelo.Distritio.Trim().Length == 0)
            {
                throw new Exception("O nome do distrito é obrigatório");
            }
            if (modelo.Bairro.Trim().Length == 0)
            {
                throw new Exception("O nome do bairro é obrigatório");
            }
            DALMunicipio obj = new DALMunicipio(conexao);
            obj.Incluir(modelo);
        }
        public void Alterar(ModeloMunicipio modelo)
        {
            if (modelo.MuCod <= 0)
            {
                throw new Exception("O código do município é obrigatório");
            }
            if (modelo.Distritio.Trim().Length == 0)
            {
                throw new Exception("O nome do distrito é obrigatório");
            }
            if (modelo.Bairro.Trim().Length == 0)
            {
                throw new Exception("O nome do bairro é obrigatório");
            }
            DALMunicipio obj = new DALMunicipio(conexao);
            obj.Alterar(modelo);
        }
        public void Excluir(int codigo)
        {
            DALMunicipio obj = new DALMunicipio(conexao);
            obj.Excluir(codigo);
        }
        public DataTable Localizar(String valor)
        {
            DALMunicipio obj = new DALMunicipio(conexao);
            return obj.Localizar(valor);
        }
        public ModeloMunicipio CarregaModeloMunicipio(int codigo)
        {
            DALMunicipio obj = new DALMunicipio(conexao);
            return obj.CarregaModeloMunicipio(codigo);
        }
    }
}

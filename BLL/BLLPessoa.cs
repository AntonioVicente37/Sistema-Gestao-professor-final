using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Modelo;
using DAL;
using Ferramentas;
using System.Text.RegularExpressions;

namespace BLL
{
    public class BLLPessoa
    {
        private DALConexao conexao;

        public BLLPessoa(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloPessoa modelo)
        {
            if (modelo.MuCod <= 0)
            {
                throw new Exception("É obrigatório informar o municipio");
            }
            if (modelo.Penome.Trim().Length == 0)
            {
                throw new Exception("O nome do professor é Obrigatório");
            }
            if (modelo.PeBI.Trim().Length == 0)
            {
                throw new Exception("Informe o bilhete de identidade do professor");
            }
            string strRegex = "^([a-zA-Z0-9_\\-\\.]+)@((\\[[0-9]{1,3}"
                + "\\.[0-9]{1,3}\\.[0-9]{1,3}\\.)|(([a-zA-Z0-9\\-]+\\"
                + ".)+))([a-zA-Z]{2,4}|[0,9]{1,3})(\\]?)$";
            Regex re = new Regex(strRegex);
            if (!re.IsMatch(modelo.Peemail))
            {
                throw new Exception("informe um e-mail valido");
            }
            DALPessoa obj = new DALPessoa(conexao);
            obj.Incluir(modelo);
        }
        public void Alterar(ModeloPessoa modelo)
        {
            if (modelo.PeCod <= 0)
            {
                throw new Exception("O código é obrigatório");
            }
            if (modelo.MuCod <= 0)
            {
                throw new Exception("É obrigatório informar o municipio");
            }
            if (modelo.Penome.Trim().Length == 0)
            {
                throw new Exception("O nome do professor é Obrigatório");
            }           
            if (modelo.PeBI.Trim().Length == 0)
            {
                throw new Exception("Informe o bilhete de identidade do professor");
            }
            string strRegex = "^([a-zA-Z0-9_\\-\\.]+)@((\\[[0-9]{1,3}"
                + "\\.[0-9]{1,3}\\.[0-9]{1,3}\\.)|(([a-zA-Z0-9\\-]+\\"
                + ".)+))([a-zA-Z]{2,4}|[0,9]{1,3})(\\]?)$";
            Regex re = new Regex(strRegex);
            if (!re.IsMatch(modelo.Peemail))
            {
                throw new Exception("informe um e-mail valido");
            }
            DALPessoa obj = new DALPessoa(conexao);
            obj.Alterar(modelo);
        }
        public void Excluir(int codigo)
        {
            DALPessoa obj = new DALPessoa(conexao);
            obj.Excluir(codigo);
        }
        public DataTable Localizar(String valor)
        {
            DALPessoa obj = new DALPessoa(conexao);
            return obj.Localizar(valor);
        }
        public ModeloPessoa CarregaModeloPessoa(int codigo)
        {
            DALPessoa obj = new DALPessoa(conexao);
            return obj.CarregaModeloPessoa(codigo);
        }


    }
}

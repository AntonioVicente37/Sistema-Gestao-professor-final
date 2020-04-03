using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Modelo;
using DAL;
using System.Text.RegularExpressions;
namespace BLL
{
    public class BLLScretariado
    {
        private DALConexao conexao;

        public BLLScretariado(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloSecretariado modelo)
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
            DALSecretariado obj = new DALSecretariado(conexao);
            obj.Incluir(modelo);
        }
        public void Alterar(ModeloSecretariado modelo)
        {
            if (modelo.SecCod <= 0)
            {
                throw new Exception("O código  é obrigatório");
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
            DALSecretariado obj = new DALSecretariado(conexao);
            obj.Alterar(modelo);
        }
        public void Excluir(int codigo)
        {
            DALSecretariado obj = new DALSecretariado(conexao);
            obj.Excluir(codigo);
        }
        public DataTable Localizar(String valor)
        {
            DALSecretariado obj = new DALSecretariado(conexao);
            return obj.Localizar(valor);
        }
        public ModeloSecretariado CarregaModeloSecretariado(int codigo)
        {
            DALSecretariado obj = new DALSecretariado(conexao);
            return obj.CarregaModeloPSecretariado(codigo);
        }
    }
}

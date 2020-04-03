using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Modelo;
using Ferramentas;
using DAL;
using System.Data;

namespace DAL
{
    public class BLLProfessor
    {
        private DALConexao conexao;

        public BLLProfessor(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloProfessor modelo)
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
            DALProfessores obj = new DALProfessores(conexao);
            obj.Incluir(modelo);
        }
        public void Alterar(ModeloProfessor modelo)
        {
            if (modelo.NumAgente <= 0)
            {
                throw new Exception("O código do professor é obrigatório");
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
            DALProfessores obj = new DALProfessores(conexao);
            obj.Alterar(modelo);
        }
        public void Excluir(int codigo)
        {
            DALProfessores obj = new DALProfessores(conexao);
            obj.Excluir(codigo);
        }
        public DataTable Localizar(String valor)
        {
            DALProfessores obj = new DALProfessores(conexao);
            return obj.Localizar(valor);
        }
        public DataTable LocalizarPorPresenca(int presenca)
        {
            DALProfessores obj = new DALProfessores(conexao);
            return obj.LocalizarPorPresenca(presenca);
        }
        public ModeloProfessor CarregaModeloProfessor(int codigo)
        {
            DALProfessores obj = new DALProfessores(conexao);
            return obj.CarregaModeloProfessor(codigo);
        }

    }
}

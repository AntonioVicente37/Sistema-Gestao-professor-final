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
    public class BLLSemana
    {
        private DALConexao conexao;

        public BLLSemana(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloSemana modelo)
        {
            if (modelo.TuCod <= 0)
            {
                throw new Exception("O nome da turma é obrigatório");
            }
            if (modelo.ProCod <= 0)
            {
                throw new Exception("O nome do professor é obrigatório");
            }
            if (modelo.DiCod <= 0)
            {
                throw new Exception("O nome da disciplina é obrigatório");
            }
            if (modelo.SaCod <= 0)
            {
                throw new Exception("O número da sala é obrigatório");
            }
            if (modelo.Semana.Trim().Length == 0)
            {
                throw new Exception("O dia de semana é obrigatório");
            }
            if (modelo.AnoCod <= 0)
            {
                throw new Exception("É necessário informar o ano letivo");
            }
            DALSemana obj = new DALSemana(conexao);
            obj.Incluir(modelo);
        }
        public void Alterar(ModeloSemana modelo)
        {
            if (modelo.SeCod <= 0)
            {
                throw new Exception("O código da semana é obrigatório");
            }
            if (modelo.TuCod <= 0)
            {
                throw new Exception("O nome da turma é obrigatório");
            }
            if (modelo.ProCod <= 0)
            {
                throw new Exception("O nome do professor é obrigatório");
            }
            if (modelo.DiCod <= 0)
            {
                throw new Exception("O nome da disciplina é obrigatório");
            }
            if (modelo.SaCod <= 0)
            {
                throw new Exception("O número da sala é obrigatório");
            }
            if (modelo.Semana.Trim().Length == 0)
            {
                throw new Exception("O dia de semana é obrigatório");
            }
            if (modelo.AnoCod <= 0)
            {
                throw new Exception("É necessário informar o ano letivo");
            }
            DALSemana obj = new DALSemana(conexao);
            obj.Alterar(modelo);
        }
        public void Excluir(int codigo)
        {
            DALSemana obj = new DALSemana(conexao);
            obj.Excluir(codigo);
        }
        public DataTable Localizar(String valor)
        {
            DALSemana obj = new DALSemana(conexao);
            return obj.Localizar(valor);
        }
        public ModeloSemana CarregaModeloSemana(int codigo)
        {
            DALSemana obj = new DALSemana(conexao);
            return obj.CarregaModeloSemana(codigo);
        }
    }
}

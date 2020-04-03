using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Modelo;
using System.Data;

namespace BLL
{
    public class BLLTurma
    {
        private DALConexao conexao;

        public BLLTurma(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloTurma modelo)
        {
            if (modelo.CuCod <= 0)
            {
                throw new Exception("O nome do curso é obrigatório");
            }
            if (modelo.Turma.Trim().Length == 0)
            {
                throw new Exception("É necessário informar a turma");
            }
            if (modelo.Periodo.Trim().Length == 0)
            {
                throw new Exception("É necessário informar o periodo");
            }
            if (modelo.AnoCod <= 0)
            {
                throw new Exception("É necessário informar o ano letivo");
            }
            DALTurma obj = new DALTurma(conexao);
            obj.Incluir(modelo);
        }
        public void Alterar(ModeloTurma modelo)
        {
            if (modelo.TuCod == 0)
            {
                throw new Exception("O código da turma é obrigatório");
            }
            if (modelo.CuCod <= 0)
            {
                throw new Exception("O nome do curso é obrigatório");
            }
            if (modelo.Turma.Trim().Length == 0)
            {
                throw new Exception("É necessário informar a turma");
            }
            if (modelo.Periodo.Trim().Length == 0)
            {
                throw new Exception("É necessário informar o periodo");
            }
            if (modelo.AnoCod <= 0)
            {
                throw new Exception("É necessário informar o ano letivo");
            }
            DALTurma obj = new DALTurma(conexao);
            obj.Alterar(modelo);
        }
        public void Excluir(int codigo)
        {
            DALTurma obj = new DALTurma(conexao);
            obj.Excluir(codigo);
        }
        public DataTable Localizar(String valor)
        {
            DALTurma obj = new DALTurma(conexao);
            return obj.Localizar(valor);
        }
        public int VerificaTurma(String valor)
        {
            DALTurma DALobj = new DALTurma(conexao);
            return DALobj.VerificaTurma(valor);
        }
        public ModeloTurma CarregaModeloTurma(int codigo)
        {
            DALTurma obj = new DALTurma(conexao);
            return obj.CarregaModeloTurma(codigo);
        }

    }
}

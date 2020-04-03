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
    public class BLLTPTurma
    {
        private DALConexao conexao;

        public BLLTPTurma(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloTPTurma modelo)
        {
            if (modelo.TuCod <= 0)
            {
                throw new Exception("O código da turma é obrigatório");
            }
            if (modelo.ProCod <= 0)
            {
                throw new Exception("O código do professor é obrigatório");
            }
            DALTPTurma obj = new DALTPTurma(conexao);
            obj.Incluir(modelo);
        }
        public void Alterar(ModeloTPTurma modelo)
        {
            if (modelo.TpCod <= 0)
            {
                throw new Exception("O código da aula é obrigatório");
            }
            if (modelo.TuCod <= 0)
            {
                throw new Exception("O código da turma é obrigatório");
            }
            if (modelo.ProCod <= 0)
            {
                throw new Exception("O código do professor é obrigatório");
            }
            DALTPTurma obj = new DALTPTurma(conexao);
            obj.Alterar(modelo);
        }
        public void Excluir(int codigo)
        {
            DALTPTurma obj = new DALTPTurma(conexao);
            obj.Excluir(codigo);
        }
        public DataTable Localizar(String valor)
        {
            DALTPTurma obj = new DALTPTurma(conexao);
            return obj.Localizar(valor);
        }
        public int VerificaTurmaLec(String valor, String resto,String turma)
        {
            DALTPTurma DALobj = new DALTPTurma(conexao);
            return DALobj.VerificaTurmaLec(valor, resto,turma);
        }
        public int VerificaDireitorTurma(String valor)
        {
            DALTPTurma DALobj = new DALTPTurma(conexao);
            return DALobj.VerificaDireitorTurma(valor);
        }
        public ModeloTPTurma CarregaModeloTPTurma(int codigo)
        {
            DALTPTurma obj = new DALTPTurma(conexao);
            return obj.CarregaModeloTPTurma(codigo);
        }

    }
}

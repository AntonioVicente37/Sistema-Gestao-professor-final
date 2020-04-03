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
    public class BLLProva
    {
        private DALConexao conexao;

        public BLLProva(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloProva modelo)
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
            if (modelo.Tipo.Trim().Length == 0)
            {
                throw new Exception("O tipo da prova é obrigatório");
            }
            if (modelo.Periodo.Trim().Length == 0)
            {
                throw new Exception("O periodo da prova é obrigatório");
            }

            DALProva obj = new DALProva(conexao);
            obj.Incluir(modelo);
        }
        public void Alterar(ModeloProva modelo)
        {

            if (modelo.PvCod <= 0)
            {
                throw new Exception("O código da prova é obrigatório");
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

            if (modelo.Tipo.Trim().Length == 0)
            {
                throw new Exception("O tipo da prova é obrigatório");
            }
            if (modelo.Periodo.Trim().Length == 0)
            {
                throw new Exception("O periodo da prova é obrigatório");
            }

            DALProva obj = new DALProva(conexao);
            obj.Alterar(modelo);
        }
        public void Excluir(int codigo)
        {
            DALProva obj = new DALProva(conexao);
            obj.Excluir(codigo);
        }
        public DataTable Localizar(String valor)
        {
            DALProva obj = new DALProva(conexao);
            return obj.Localizar(valor);
        }
        public ModeloProva CarregaModeloProva(int codigo)
        {
            DALProva obj = new DALProva(conexao);
            return obj.CarregaModeloProva(codigo);
        }
    }
}

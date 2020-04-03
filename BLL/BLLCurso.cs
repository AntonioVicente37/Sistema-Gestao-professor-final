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
    public class BLLCurso
    {
        private DALConexao conexao;

        public BLLCurso(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloCurso modelo)
        {
            if (modelo.Curso.Trim().Length == 0)
            {
                throw new Exception("O numero do curso é obrigatório");
            }
            if (modelo.AreFormacao.Trim().Length == 0)
            {
                throw new Exception("A área de formação do curso é obrigatório");
            }
            DALCurso obj = new DALCurso(conexao);
            obj.Incluir(modelo);
        }
        public void Alterar(ModeloCurso modelo)
        {
            if (modelo.CuCod <= 0)
            {
                throw new Exception("O código do curso é obrigatório");
            }
            if (modelo.Curso.Trim().Length == 0)
            {
                throw new Exception("O numero do curso é obrigatório");
            }
            if (modelo.AreFormacao.Trim().Length == 0)
            {
                throw new Exception("A área de formação do curso é obrigatório");
            }
            DALCurso obj = new DALCurso(conexao);
            obj.Alterar(modelo);
        }
        public void Excluir(int codigo)
        {
            DALCurso obj = new DALCurso(conexao);
            obj.Excluir(codigo);
        }
        public DataTable Localizar(String valor)
        {
            DALCurso obj = new DALCurso(conexao);
            return obj.Localizar(valor);
        }
        public int VerificarCurso(String valor)
        {
            DALCurso DALobj = new DALCurso(conexao);
            return DALobj.VerificaCurso(valor);
        }
        public ModeloCurso CarregaModeloCurso(int codigo)
        {
            DALCurso obj = new DALCurso(conexao);
            return obj.CarregaModeloCurso(codigo);
        }
    }
}

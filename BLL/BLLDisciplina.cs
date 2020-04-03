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
    public class BLLDisciplina
    {
        private DALConexao conexao;

        public BLLDisciplina(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloDisciplina modelo)
        {
            if (modelo.CoCod <= 0)
            {
                throw new Exception("O nome da coordenacao é obrigatório");
            }
            if (modelo.CuCod <= 0)
            {
                throw new Exception("O curso é obrigatório");
            }
            if (modelo.Disciplina.Trim().Length == 0)
            {
                throw new Exception("O nome da discíplina é obrigatório");
            }
            if (modelo.Componente.Trim().Length == 0)
            {
                throw new Exception("O nome da componente é obrigatório");
            }
            if (modelo.Carga.Trim().Length ==  0)
            {
                throw new Exception("Informe a carga horária da discíplina");
            }
            DALDisciplina obj = new DALDisciplina(conexao);
            obj.Incluir(modelo);
        }
        public void Alterar(ModeloDisciplina modelo)
        {
            if (modelo.DiCod == 0)
            {
                throw new Exception("O código da Disciplina é obrigatório");
            }
            if (modelo.CoCod <= 0)
            {
                throw new Exception("O nome da coordenacao é obrigatório");
            }
            if (modelo.CuCod <= 0)
            {
                throw new Exception("O curso é obrigatório");
            }
            if (modelo.Disciplina.Trim().Length == 0)
            {
                throw new Exception("O nome da discíplina é obrigatório");
            }
            if (modelo.Componente.Trim().Length == 0)
            {
                throw new Exception("O nome da componente é obrigatório");
            }
            if (modelo.Carga.Trim().Length == 0)
            {
                throw new Exception("Informe a carga horária da discíplina");
            }
            DALDisciplina obj = new DALDisciplina(conexao);
            obj.Alterar(modelo);
        }
        public void Excluir(int codigo)
        {
            DALDisciplina obj = new DALDisciplina(conexao);
            obj.Excluir(codigo);
        }
        public DataTable Localizar(String valor)
        {
            DALDisciplina obj = new DALDisciplina(conexao);
            return obj.Localizar(valor);
        }
        public int VerificarDisciplina(String valor)
        {
            DALDisciplina DALobj = new DALDisciplina(conexao);
            return DALobj.VerificaDisciplina(valor);
        }
        public ModeloDisciplina CarregaModeloDisciplina(int codigo)
        {
            DALDisciplina obj = new DALDisciplina(conexao);
            return obj.CarregaModeloDisciplina(codigo);
        }
    }
}

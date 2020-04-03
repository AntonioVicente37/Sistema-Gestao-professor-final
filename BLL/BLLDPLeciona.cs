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
    public class BLLDPLeciona
    {
        private DALConexao conexao;

        public BLLDPLeciona(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloDPLeciona modelo)
        {
            if (modelo.ProCod <= 0)
            {
                throw new Exception("O nome do professor é obrigatório");
            }
            if (modelo.DiCod <= 0)
            {
                throw new Exception("O nome da disciplina é obrigatório");
            }

            DALDPLeciona obj = new DALDPLeciona(conexao);
            obj.Incluir(modelo);
        }
        public void Alterar(ModeloDPLeciona modelo)
        {
            if (modelo.DpCod <= 0)
            {
                throw new Exception("O código da discip´lina lecionada é obrigatório");
            }
            if (modelo.ProCod <= 0)
            {
                throw new Exception("O nome do professor é obrigatório");
            }
            if (modelo.DiCod <= 0)
            {
                throw new Exception("O nome da disciplina é obrigatório");
            }
            DALDPLeciona obj = new DALDPLeciona(conexao);
            obj.Alterar(modelo);
        }
        public void Excluir(int codigo)
        {
            DALDPLeciona obj = new DALDPLeciona(conexao);
            obj.Excluir(codigo);
        }
        public DataTable Localizar(String valor)
        {
            DALDPLeciona obj = new DALDPLeciona(conexao);
            return obj.Localizar(valor);
        }
        public int VerificaDisciplinaLec(String valor, String resto)
        {
            DALDPLeciona DALobj = new DALDPLeciona(conexao);
            return DALobj.VerificaDisciplinaLec(valor,resto);
        }
        public ModeloDPLeciona CarregaModeloDPLeciona(int codigo)
        {
            DALDPLeciona obj = new DALDPLeciona(conexao);
            return obj.CarregaModeloDPLeciona(codigo);
        }
    }
}

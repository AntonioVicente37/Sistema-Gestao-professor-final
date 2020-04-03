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
    public class BLLPresenca
    {
        private DALConexao conexao;

        public BLLPresenca(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloPresenca modelo)
        {
            if (modelo.Agente <= 0)
            {
                throw new Exception("Número de agente obrigatório");
            }
            if (modelo.Professor.Trim().Length == 0)
            {
                throw new Exception("Nome do professor é obrigatório");
            }
            if (modelo.Presenca.Trim().Length == 0)
            {
                throw new Exception("A presença é obrigatória");
            }
            if (modelo.HEntrada.Trim().Length == 0)
            {
                throw new Exception("A hora de entrada é obrigatória");
            }
            DALPresenca obj = new DALPresenca(conexao);
            obj.Incluir(modelo);
        }
        public void Alterar(ModeloPresenca modelo)
        {
            if (modelo.PreCod <= 0)
            {
                throw new Exception("O código da presençã é obrigatório");
            }
            if (modelo.Agente <= 0)
            {
                throw new Exception("Número de agente obrigatório");
            }
            if (modelo.Professor.Trim().Length == 0)
            {
                throw new Exception("Nome do professor é obrigatório");
            }
            if (modelo.Presenca.Trim().Length == 0)
            {
                throw new Exception("A presença é obrigatória");
            }
            if (modelo.HEntrada.Trim().Length == 0)
            {
                throw new Exception("A hora de entrada é obrigatória");
            }
            if (modelo.HSaida.Trim().Length == 0)
            {
                throw new Exception("A hora de saida é obrigatória");
            }

            DALPresenca obj = new DALPresenca(conexao);
            obj.Alterar(modelo);
        }
        public void Excluir(int codigo)
        {
            DALPresenca obj = new DALPresenca(conexao);
            obj.Excluir(codigo);
        }
        public DataTable Localizar(String valor)
        {
            DALPresenca obj = new DALPresenca(conexao);
            return obj.Localizar(valor);
        }
        public ModeloPresenca CarregaModeloPresenca(int codigo)
        {
            DALPresenca obj = new DALPresenca(conexao);
            return obj.CarregaModeloPresenca(codigo);
        }
       
    }
}

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloPresenca
    {
        private int precod;
        //private int procod;
        private int agente;
        private string presenca;
        private  DateTime data;
        private string hentrada;
        private string hsaida;
        //private Byte[] foto;
        private string professor;

        public ModeloPresenca()
        {
            this.PreCod = 0;
            //this.ProCod = 0;
            this.presenca = "";
            this.hentrada = "";
            this.HSaida = "";
            this.Data = DateTime.Now;
            this.Agente = 0;
            this.Professor = "";
        }
        public ModeloPresenca(int precod,int procod ,string professor,int agente, byte[] pe_foto, string presenca, DateTime data, string he, string hs)
        {
            this.PreCod = precod;
            //this.ProCod = procod;
            this.Presenca = presenca;
            this.HEntrada = he;
            this.HSaida = hs;
            this.Data = data;
            this.Agente = agente;
          //  this.Foto = foto;
            this.Professor = professor;
        }

        public int PreCod
        {
            get { return precod; }
            set { precod = value; }
        }
        //public int ProCod
        //{
        //    get { return procod;}
        //    set { procod = value;}
        //}

        public string Presenca
        {
            get { return presenca; }
            set { presenca = value; }
        }
        //public void CarregaImagem(String imgCaminho)
        //{
        //    try
        //    {
        //        if (string.IsNullOrEmpty(imgCaminho))//Se a String ImgCaminho estiver vazia ou for nula

        //            return;//Ele vai executar o retorno e vai voltar para o nosso caminho
        //                   //Caso contrario ele vai fazer o seguinte
        //                   //fornece a propriedade métodos de instância para criar,copia,
        //                   //excluir, mover,e abrir arquivo, e ajuda na criação do objecto fileStream
        //        FileInfo arqImagem = new FileInfo(imgCaminho);
        //        //Expôe um stream ao redor de um arquivo de suporte
        //        //síncrono e assícrono operações de leitura e gravar
        //        FileStream fs = new FileStream(imgCaminho, FileMode.Open, FileAccess.Read, FileShare.Read);
        //        //alocar memoria para o vector
        //        this.foto = new byte[Convert.ToInt32(arqImagem.Length)];
        //        //Lê um bloco bytes do fluxo e gravar os dados em um buffer fornecido
        //        int IBytesteRead = fs.Read(this.foto, 0, Convert.ToInt32(arqImagem.Length));
        //        fs.Close();
        //    }
        //    catch (Exception ex)
        //    {

        //        throw new Exception(ex.Message.ToString());
        //    }
        //}
        //public byte[] Foto
        //{
        //    get { return foto; }
        //    set { foto = value; }
        //}

        public String HEntrada
        {
            get { return hentrada; }
            set { hentrada = value; }
        }
        public  DateTime Data
        {
            get { return data; }
            set { data = value; }
        }
        public String HSaida
        {
            get { return hsaida; }
            set { hsaida = value; }
        }

        public int Agente
        {
            get{return agente;}
            set{agente = value;}
        }

        public string Professor
        {
            get
            {
                return professor;
            }

            set
            {
                professor = value;
            }
        }
    }
}

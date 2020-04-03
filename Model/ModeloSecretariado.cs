using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloSecretariado
    {
        private int seccod;
        private int mucod;
        private String pe_nome;
        private String pe_telefone;
        private String pe_BI;
        private Byte[] pe_foto;
        private String pe_email;
        private String pe_sexo;
        private DateTime dataCadastro;
        private DateTime dataAtualizacao;


        public ModeloSecretariado()
        {
            this.SecCod = 0;
            this.MuCod = 0;
            this.Penome = "";
            this.Petelefone = "";
            this.PeBI = "";
            ///this.Pefoto = ""; vai manter a foto como nula a foto não existe 
            this.Peemail = "";
            this.Pesexo = "";
            this.DataCadastro = DateTime.Now;
            this.DataCadastro = DateTime.Now;
        }
        public ModeloSecretariado(int seccod, int mucod, string pe_nome, string pe_telefone, string pe_BI, byte[] pe_foto, string pe_email, string pe_sexo, DateTime datac, DateTime dataa)
        {
            this.SecCod = seccod;
            this.MuCod = mucod;
            this.Penome = pe_nome;
            this.Petelefone = pe_telefone;
            this.PeBI = pe_BI;
            this.Pefoto = pe_foto;
            this.Peemail = pe_email;
            this.Pesexo = pe_sexo;
            this.DataCadastro = datac;
            this.DataCadastro = dataa;
        }
        public int SecCod
        {
            get { return seccod; }
            set { seccod = value; }
        }
        public int MuCod
        {
            get { return mucod; }
            set { mucod = value; }
        }


        public string Penome
        {
            get { return pe_nome; }
            set { pe_nome = value; }
        }

        public string Petelefone
        {
            get { return pe_telefone; }
            set { pe_telefone = value; }
        }
        public string PeBI
        {
            get { return pe_BI; }
            set { pe_BI = value; }
        }

        public byte[] Pefoto
        {
            get { return pe_foto; }
            set { pe_foto = value; }
        }
        public void CarregaImagem(String imgCaminho)
        {
            try
            {
                if (string.IsNullOrEmpty(imgCaminho))//Se a String ImgCaminho estiver vazia ou for nula

                    return;//Ele vai executar o retorno e vai voltar para o nosso caminho
                           //Caso contrario ele vai fazer o seguinte
                           //fornece a propriedade métodos de instância para criar,copia,
                           //excluir, mover,e abrir arquivo, e ajuda na criação do objecto fileStream
                FileInfo arqImagem = new FileInfo(imgCaminho);
                //Expôe um stream ao redor de um arquivo de suporte
                //síncrono e assícrono operações de leitura e gravar
                FileStream fs = new FileStream(imgCaminho, FileMode.Open, FileAccess.Read, FileShare.Read);
                //alocar memoria para o vector
                this.Pefoto = new byte[Convert.ToInt32(arqImagem.Length)];
                //Lê um bloco bytes do fluxo e gravar os dados em um buffer fornecido
                int IBytesteRead = fs.Read(this.Pefoto, 0, Convert.ToInt32(arqImagem.Length));
                fs.Close();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }
        public string Peemail
        {
            get { return pe_email; }
            set { pe_email = value; }
        }

        public string Pesexo
        {
            get { return pe_sexo; }
            set { pe_sexo = value; }
        }

        public DateTime DataCadastro
        {
            get { return dataCadastro; }
            set { dataCadastro = value; }
        }

        public DateTime DataAtualizacao
        {
            get { return dataAtualizacao; }
            set { dataAtualizacao = value; }
        }

    }
}


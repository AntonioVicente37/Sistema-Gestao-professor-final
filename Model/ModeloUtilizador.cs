using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloUtilizador
    {
        private int utcod;
        private int ticod;
        private string username;
        private string passworde;
        private string nome;
        private string sobrenome;
        private string email;
        private DateTime datacad;
        private DateTime dataatu;

        public ModeloUtilizador()
        {
            this.UtCod = 0;
            this.TiCod = 0;
            this.Username = "";
            this.passworde = "";
            this.datacad = DateTime.Now;
            this.dataatu = DateTime.Now;
            this.Nome = "";
            this.Sobrenome = "";
            this.Email = "";
        }
        public ModeloUtilizador(int utcod, int ticod,string username, string nome, string sobre, string email, string password, DateTime datacad, DateTime dataatu)
        {
            this.UtCod = utcod;
            this.TiCod = ticod;
            this.Username = username;
            this.passworde = password;
            this.Datacad = datacad;
            this.Dataatu = dataatu;
            this.Nome = nome;
            this.Sobrenome = sobre;
            this.Email = email;
        }

        public int UtCod
        {
            get { return utcod; }
            set { utcod = value; }
        }
        public int TiCod
        {
            get { return ticod; }
            set { ticod = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        public string Password
        {
            get { return passworde; }
            set { passworde = value; }
        }

        public DateTime Datacad
        {
            get { return datacad; }
            set { datacad = value; }
        }

        public DateTime Dataatu
        {
            get { return dataatu; }
            set { dataatu = value; }
        }

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public string Sobrenome
        {
            get
            {
                return sobrenome;
            }

            set
            {
                sobrenome = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }
    }
}

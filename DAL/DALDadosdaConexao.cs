using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
    public class DALDadosdaConexao
    {
       
        public static String servidor = @"LAPTOP-9OTDAJ5O\SQLSERVER13";
        public static String banco = "impalsgp";
        public static String usuario = "Tino";
        public static String senha = "1234";
        public static string StringDeConexao
        {
            // este get foi modificado por causa do formulario de ferramentas
            //se estiver ainda na faze de desenvolvimento inicial do nosso projecto 
            //podemos utilizar o primeiro get 
            get
            {
                return "Data Source=" + servidor + ";Initial Catalog=" + banco + ";User ID=" + usuario + ";Password= " + senha;

            }


            /*get
            {
                return "Data Source=LAPTOP-9OTDAJ5O\\SQLSERVER13;Initial Catalog=ControleDeEstoque;User ID=Tino;Password=1234";
            }*/
        }
        //get
        //{                   
        //return "Data Source=LAPTOP-9OTDAJ5O\\SQLSERVER13;Initial Catalog=impalsgp; User iD=Tino;Password = 1234;";           
        //}
      
    }
}

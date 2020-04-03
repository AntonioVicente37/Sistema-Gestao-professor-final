using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using Ferramentas;

namespace GUE
{
    public partial class frmBackupDados : Form
    {
        public frmBackupDados()
        {
            InitializeComponent();
        }

        private void btnBackp_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog d = new SaveFileDialog();
                d.Filter = "Backup Files |*.bak";
                d.ShowDialog();
                if (d.FileName != "")
                {
                    String nomeBanco = DALDadosdaConexao.banco;
                    String localBackup = d.FileName;
                    String conexao = @"Data Source=" + DALDadosdaConexao.servidor + ";Initial Catalog=master;User=" +
                        DALDadosdaConexao.usuario + ";Password=" + DALDadosdaConexao.senha;
                    SQLServerBackup.BackupDataBase(conexao, nomeBanco, d.FileName);
                    MessageBox.Show("Backup realizado com sucesso !!!!");
                }
            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog d = new OpenFileDialog();
                d.Filter = "Backup Files |*.bak";
                d.ShowDialog();
                if (d.FileName != "")
                {
                    String nomeBanco = DALDadosdaConexao.banco;
                    String localBackup = d.FileName;
                    String conexao = @"Data Source=" + DALDadosdaConexao.servidor + ";Initial Catalog=master;User=" +
                        DALDadosdaConexao.usuario + ";Password=" + DALDadosdaConexao.senha;
                    SQLServerBackup.RestauraDatabase(conexao, nomeBanco, d.FileName);
                    MessageBox.Show("Backup restaurado com sucesso !!!!");
                }
            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }
        }

        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

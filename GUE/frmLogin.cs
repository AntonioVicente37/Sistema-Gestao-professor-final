using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;
using Modelo.Cache;
using DAL;
using BLL;


namespace GUE
{
    public partial class frmLogin : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-9OTDAJ5O\\SQLSERVER13;Initial Catalog=impalsgp; User iD=Tino;Password = 1234;");
        public frmLogin()
        {
            InitializeComponent();
        }



        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        public void EfectuarLogin(ModeloUtilizador modelo)
        {


            string sql = "select username,passworde,id_tipoUtilizador " +
                              " from t_Utilizador where username like @user and passworde like @pass ";

            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@user", modelo.Username);
            cmd.Parameters.AddWithValue("@pass", modelo.Password);

            con.Open();

            SqlDataReader da = cmd.ExecuteReader();
            if (da.Read())
            {
                //receber dados do cargo
                int cargo = da.GetInt32(3);
                string username = modelo.Username;

                MessageBox.Show("Ben vindo ao sistema");

                //if (cargo == 4)
                //{
                //    frmM f = new frmM();
                //    f.administradorToolStripMenuItem.Enabled = false;
                //    f.ShowDialog();
                //}
                //if (cargo == 5)
                //{
                //    frmMenu f = new frmMenu();
                //    f.administradorToolStripMenuItem.Enabled = false;
                //    f.ShowDialog();
                //}
                //if (cargo == 2)
                //{
                //    frmMenu f = new frmMenu();
                //    f.administradorToolStripMenuItem.Enabled = false;
                //    f.ShowDialog();
                //}
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (txtUser.Text != "USERNAME")
            {
                if (txtPass.Text != "PASSWORD")
                {
                    DALConexao cx = new DALConexao(DALDadosdaConexao.StringDeConexao);
                    BLLUtilizador modelo = new BLLUtilizador(cx);
                    ModeloUtilizador da = new ModeloUtilizador();
                    var validaLogin = modelo.LoginUser(txtUser.Text, txtPass.Text);
                    if (validaLogin == true)
                    {
                        this.Hide();
                        frmAnimacao Welcome = new frmAnimacao();
                        Welcome.ShowDialog();
                        frmMenu f = new frmMenu();
                        //MessageBox.Show("Welcome " + UserLoginCache.Nome + ", " + UserLoginCache.Sobrenome);
                        f.Show();
                        f.FormClosed += Logout;
                       // this.Hide();
                    }
                    else
                    {
                        msgError("Senha ou nome de utilizador incorreta. \n por favor tente novamente");
                        txtPass.Text = "*";
                        txtUser.Focus();
                    }
                }
                else msgError("Palavra pass incorreta");
            }
            else msgError("Nome de usuário incorreta");
        }
        public void msgError(string msg)
        {
            lblErro.Text = "  " + msg;
            lblErro.Visible = true;
        }
        private void Logout(object sender, FormClosedEventArgs e)
        {
            txtPass.Text = "PASSWORD";
            txtUser.Text = "USERNAME";
            txtPass.UseSystemPasswordChar = false;
            lblErro.Visible = false;
            this.Show();
            txtUser.Focus();
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "USERNAME")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.Gray;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "PASSWORD";
                txtPass.ForeColor = Color.DarkGray;
                txtPass.UseSystemPasswordChar = false;
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "USERNAME";
                txtUser.ForeColor = Color.DarkGray;
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "PASSWORD")
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.Gray;
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            frmRecuperarSenha frm = new frmRecuperarSenha();
            frm.ShowDialog();
            frm.Dispose();
        }
    }
}

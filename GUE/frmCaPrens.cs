using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;
using Modelo;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using Modelo.Cache;

namespace GUE
{
    public partial class frmCaPrens : Form
    {
        public String operacao = "";
        SqlConnection cn = new SqlConnection("Data Source=LAPTOP-9OTDAJ5O\\SQLSERVER13;Initial Catalog=impalsgp; User iD=Tino;Password = 1234;");
        public frmCaPrens()
        {
            InitializeComponent();
        }

        public void LimpaTela()
        {
            txtId.Clear();
            txtAgente.Clear();
            txtProfessor.Clear();
            cmbAgente.Text = "";
            dtpda.Value = DateTime.Now;
            mkbfinal.Clear();
            if (ckdPresenca.Checked == true)
            {
                ckdPresenca.Text = "Ausente";
                ckdPresenca.Checked = false;
            }
            mkbinicial.Clear();
            pbFoto.Image = null;
        }
        public void CarregarLogin()
        {
            if (UserLoginCache.Cargo == Cargo.Professor)
            {
                btnNo.Enabled = false;
            }
            if (UserLoginCache.Cargo == Cargo.D_Administrador)
            {
                
            }
            if (UserLoginCache.Cargo == Cargo.D_Pedagogico)
            {
                btnNo.Enabled = false;
            }
            if (UserLoginCache.Cargo == Cargo.Secretaria)
            {

            }
            if (UserLoginCache.Cargo == Cargo.Secretaria_Admin)
            {

            }
            if (UserLoginCache.Cargo == Cargo.Secretaria_pedago)
            {

            }
        }
        private void frmCaPrens_Load(object sender, EventArgs e)
        {
            //Carregando os combobox
             Combo();
            //Ocultar a hora de saida
            entrada();
            //Carregando o data gridViews
            btnLocalizar_Click(sender, e);
            dvgDados.Columns[0].HeaderText = "Código";
            dvgDados.Columns[0].Width = 60;
            dvgDados.Columns[1].HeaderText = "Numero de agente";
            dvgDados.Columns[1].Width = 150;
            dvgDados.Columns[2].HeaderText = "Professor";
            dvgDados.Columns[2].Width = 150;
            dvgDados.Columns[3].HeaderText = "Presença";
            dvgDados.Columns[3].Width = 150;
            dvgDados.Columns[4].HeaderText = "Data";
            dvgDados.Columns[4].Width = 150;
            dvgDados.Columns[5].HeaderText = "Hora de entrada";
            dvgDados.Columns[5].Width = 150;
            dvgDados.Columns[6].HeaderText = "Hora de saída";
            dvgDados.Columns[6].Width = 150;

            ///
            dvgDados.Columns[0].Visible = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            frmMessageBox f = new frmMessageBox();
            try
            {
                //Leitura de Dados
                ModeloPresenca modelo = new ModeloPresenca();
                modelo.Presenca = ckdPresenca.Text;
                modelo.HEntrada = Convert.ToString(mkbinicial.Text);
                modelo.HSaida = Convert.ToString(mkbfinal.Text);
                modelo.Agente = Convert.ToInt32(txtAgente.Text);
                modelo.Data = Convert.ToDateTime(dtpda.Value);
                modelo.Professor = txtProfessor.Text;


                //objecto para gravar os dados
                DALConexao cx = new DALConexao(DALDadosdaConexao.StringDeConexao);
                BLLPresenca bll = new BLLPresenca(cx);

                if (this.operacao == "inserir")
                {
                    //cadastrar as salas
                    bll.Incluir(modelo);
                    f.Show();
                    btnLocalizar_Click(sender, e);
                }
                else
                {
                    modelo.PreCod = Convert.ToInt32(txtId.Text);
                    bll.Alterar(modelo);
                    f.Show();
                    tabControlSala.SelectTab(tabSConsu);
                    btnLocalizar_Click(sender, e);
                }
                this.LimpaTela();
                //this.alterabotoes(1);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DALDadosdaConexao.StringDeConexao);
            BLLPresenca bll = new BLLPresenca(cx);
            dvgDados.DataSource = bll.Localizar(txtPesquisar.Text);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo);
                if (true)
                {
                    DALConexao cx = new DALConexao(DALDadosdaConexao.StringDeConexao);
                    BLLPresenca bll = new BLLPresenca(cx);
                    bll.Excluir(Convert.ToInt32(txtId.Text));
                    this.LimpaTela();
                    tabControlSala.SelectTab(tabSConsu);
                    btnLocalizar_Click(sender, e);
                }
            }
            catch
            {
                MessageBox.Show("impossível excluir o registro. \n O registro esta sendo utilizado em outro local.");
                //this.alterabotoes(3);

            }
        }

        private void ckdPresenca_CheckedChanged(object sender, EventArgs e)
        {
            if (ckdPresenca.Checked == true)
            {

                ckdPresenca.Text = "Presente";
            }
            else if (ckdPresenca.Checked == false)
            {
                ckdPresenca.Text = "Ausente";
            }
        }

        private void cmbAgente_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-9OTDAJ5O\\SQLSERVER13;Initial Catalog=impalsgp; User iD=Tino;Password = 1234;");
            string sql = "select * from t_professor where nome = '" + cmbAgente.Text + "';";
            SqlCommand cmd = new SqlCommand(sql, con);


            SqlDataReader registro;
            try
            {
                con.Open();
                registro = cmd.ExecuteReader();
                while (registro.Read())
                {
                    string nome = registro.GetInt32(0).ToString();
                    string snome = registro.GetString(2);
                    txtProfessor.Text = snome;
                    byte[] foto = (byte[])registro["foto"];
                    txtAgente.Text = nome;
                    MemoryStream ms = new MemoryStream(foto);
                    pbFoto.Image = new Bitmap(ms);

                }
            }
            catch (Exception sx)
            {
                MessageBox.Show(sx.Message);
            }
        }
        public void Combo()
        {

            string sql = "select * from t_professor order by nome";
            SqlCommand cmd = new SqlCommand(sql, cn);


            SqlDataReader registro;
            try
            {
                cn.Open();
                registro = cmd.ExecuteReader();
                while (registro.Read())
                {
                    string numAgente = registro.GetString(2);
                    cmbAgente.Items.Add(numAgente);
                }
            }
            catch (Exception sx)
            {
                MessageBox.Show(sx.Message);

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (this.operacao == "inserir")
            {
                mkbinicial.Text = DateTime.Now.ToString("HH:mm:ss");

            }
            else //if (this.operacao == "alterar")
            {
                mkbfinal.Text = DateTime.Now.ToString("HH:mm:ss");
            }


        }

        private void dvgDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                operacao = "alterar";
                txtId.Text = dvgDados.CurrentRow.Cells["id_presenca"].Value.ToString();
                txtAgente.Text = dvgDados.CurrentRow.Cells["agente"].Value.ToString();
                txtProfessor.Text = dvgDados.CurrentRow.Cells["professor"].Value.ToString();
                dtpda.Text = dvgDados.CurrentRow.Cells["data"].Value.ToString();
                mkbinicial.Text = dvgDados.CurrentRow.Cells["hora_entrada"].Value.ToString();
                mkbfinal.Text = dvgDados.CurrentRow.Cells["hora_saida"].Value.ToString();
                tabControlSala.SelectTab(tabSCad);
                Saida();
            }
            else
                MessageBox.Show("Selecine uma linha");
        }
        public void Saida()
        {
            pnFoto.Visible = false;
            lblFoto.Visible = false;
            mkbfinal.Visible = true;
            lblNome.Visible = true;
            lblAgente.Visible = false;
            lblData.Visible = false;
            lblEntrada.Visible = false;
            lblProfessor.Visible = false;
            txtAgente.Visible = false;
            txtProfessor.Visible = false;
            ckdPresenca.Visible = false;
            mkbinicial.Visible = false;
            dtpda.Visible = false;
            label8.Visible = false;
            cmbAgente.Visible = false;
        }
        private void btnNo_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            tabControlSala.SelectTab(tabSCad);
        }

        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void entrada()
        {
            mkbfinal.Visible = false;
            lblNome.Visible = false;
            ///

            lblAgente.Visible = true;
            pnFoto.Visible = true;
            lblData.Visible = true;
            lblEntrada.Visible = true;
            lblProfessor.Visible = true;
            txtAgente.Visible = true;
            txtProfessor.Visible = true;
            ckdPresenca.Visible = true;
            mkbinicial.Visible = true;
            dtpda.Visible = true;
            label8.Visible = true;
            cmbAgente.Visible = true;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.LimpaTela();
            tabControlSala.SelectTab(tabSConsu);
            entrada();
        }

        private void txtPesquisar_KeyUp(object sender, KeyEventArgs e)
        {
            DALConexao cx = new DALConexao(DALDadosdaConexao.StringDeConexao);
            BLLPresenca bll = new BLLPresenca(cx);
            dvgDados.DataSource = bll.Localizar(txtPesquisar.Text);
        }
    }
  
}

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

namespace GUE
{
    public partial class frmCaUtilizador : Form
    {
        public String operacao = "";
        public frmCaUtilizador()
        {
            InitializeComponent();
        }
        public void LimpaTela()
        {
            txtId.Clear();
            txtEmail.Clear();
            txtPasswoed.Clear();
            txtUsername.Clear();
            txtSobrenome.Clear();
            txtNome.Clear();
            cmbCargo.SelectedValue = false;
            dtpAtualizacao.Value = DateTime.Now;
            dtpCadastro.Value = DateTime.Now;
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DALDadosdaConexao.StringDeConexao);
            BLLUtilizador bll = new BLLUtilizador(cx);
            dvgDados.DataSource = bll.Localizar(txtPesquisar.Text);
        }

        private void txtPesquisar_KeyUp(object sender, KeyEventArgs e)
        {
            DALConexao cx = new DALConexao(DALDadosdaConexao.StringDeConexao);
            BLLUtilizador bll = new BLLUtilizador(cx);
            dvgDados.DataSource = bll.Localizar(txtPesquisar.Text);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                frmMessageBox f = new frmMessageBox();
                //Leitura de Dados
                ModeloUtilizador modelo = new ModeloUtilizador();
                modelo.Dataatu = dtpAtualizacao.Value;
                modelo.Datacad = dtpCadastro.Value;
                modelo.Nome = txtNome.Text;
                modelo.Sobrenome = txtSobrenome.Text;
                modelo.Email = txtEmail.Text;
                modelo.Username = txtUsername.Text;
                modelo.Password = txtPasswoed.Text;
                modelo.TiCod = Convert.ToInt32(cmbCargo.SelectedValue);
                //objecto para gravar os dados
                DALConexao cx = new DALConexao(DALDadosdaConexao.StringDeConexao);
                BLLUtilizador bll = new BLLUtilizador(cx);
                if (this.operacao == "inserir")
                {
                    //cadastrar as salas
                    bll.Incluir(modelo);
                    f.Show();
                    btnLocalizar_Click(sender, e);
                    //tabControlSala.SelectTab(tabSConsu);
                }
                else
                {
                    //Alterar a sala
                    modelo.UtCod = Convert.ToInt32(txtId.Text);
                    bll.Alterar(modelo);
                    f.Show();
                    btnLocalizar_Click(sender, e);

                }
                this.LimpaTela();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void frmCaUtilizador_Load(object sender, EventArgs e)
        {
            btnLocalizar_Click(sender, e);
            dvgDados.Columns[0].HeaderText = "Código";
            dvgDados.Columns[0].Width = 60;
            dvgDados.Columns[1].HeaderText = "Username";
            dvgDados.Columns[1].Width = 200;
            dvgDados.Columns[2].HeaderText = "Password";
            dvgDados.Columns[2].Width = 100;
            dvgDados.Columns[3].HeaderText = "Nome";
            dvgDados.Columns[3].Width = 100;
            dvgDados.Columns[4].HeaderText = "Sobrenome";
            dvgDados.Columns[4].Width = 100;
            dvgDados.Columns[5].HeaderText = "E-mail";
            dvgDados.Columns[5].Width = 200;
            dvgDados.Columns[6].HeaderText = "Cargo";
            dvgDados.Columns[6].Width = 150;
            dvgDados.Columns[7].HeaderText = "Data de cadastro";
            dvgDados.Columns[7].Width = 130;
            dvgDados.Columns[8].HeaderText = "Data de atualização";
            dvgDados.Columns[8].Width = 130;
            ///
            dvgDados.Columns[0].Visible = false;
            lblAtualizacao.Visible = false;
            dtpAtualizacao.Visible = false;
            ///Carregando o combobox do tipo de utilizador
            DALConexao cx = new DALConexao(DALDadosdaConexao.StringDeConexao);
            BLLTipoUtilizador bll = new BLLTipoUtilizador(cx);
            cmbCargo.DataSource = bll.Localizar("");
            cmbCargo.DisplayMember = "utilizador";
            cmbCargo.ValueMember = "id_tipoUtilizador";
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo);
                if (true)
                {
                    DALConexao cx = new DALConexao(DALDadosdaConexao.StringDeConexao);
                    BLLUtilizador bll = new BLLUtilizador(cx);
                    bll.Excluir(Convert.ToInt32(txtId.Text));
                    btnLocalizar_Click(sender, e);
                    this.LimpaTela();

                }
            }
            catch
            {
                MessageBox.Show("impossível excluir o registro. \n O registro esta sendo utilizado em outro local.");

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.LimpaTela();
            tabControlSala.SelectTab(tabSConsu);
        }

        private void dvgDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                operacao = "alterar";
                txtId.Text = dvgDados.CurrentRow.Cells["id_Utilizador"].Value.ToString();
                txtNome.Text = dvgDados.CurrentRow.Cells["nome"].Value.ToString();
                cmbCargo.Text = dvgDados.CurrentRow.Cells[5].Value.ToString();
                txtPasswoed.Text = dvgDados.CurrentRow.Cells["passworde"].Value.ToString();
                txtSobrenome.Text = dvgDados.CurrentRow.Cells["sobrenome"].Value.ToString();
                txtUsername.Text = dvgDados.CurrentRow.Cells["username"].Value.ToString();
                txtEmail.Text = dvgDados.CurrentRow.Cells["email"].Value.ToString();
                dtpCadastro.Text = dvgDados.CurrentRow.Cells["dataCadastro"].Value.ToString();
                dtpAtualizacao.Text = dvgDados.CurrentRow.Cells["dataActualizacao"].Value.ToString();
                tabControlSala.SelectTab(tabSCad);
                lblAtualizacao.Visible = true;
                dtpAtualizacao.Visible = true;
            }
            else
                MessageBox.Show("Selecine uma linha");
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            tabControlSala.SelectTab(tabSCad);
            lblAtualizacao.Visible = false;
            dtpAtualizacao.Visible = false;
        }

        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

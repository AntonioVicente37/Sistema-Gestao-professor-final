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
    public partial class frmTipoUtilizador : Form
    {
        public String operacao = "";
        public frmTipoUtilizador()
        {
            InitializeComponent();
        }
        public void LimpaTela()
        {
            txtId.Clear();
            txtCargo.Clear();
            dtpAtualizacao.Value = DateTime.Now;
            dtpCadastro.Value = DateTime.Now;
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DALDadosdaConexao.StringDeConexao);
            BLLTipoUtilizador bll = new BLLTipoUtilizador(cx);
            dvgDados.DataSource = bll.Localizar(txtPesquisar.Text);
        }

        private void txtPesquisar_KeyUp(object sender, KeyEventArgs e)
        {
            DALConexao cx = new DALConexao(DALDadosdaConexao.StringDeConexao);
            BLLTipoUtilizador bll = new BLLTipoUtilizador(cx);
            dvgDados.DataSource = bll.Localizar(txtPesquisar.Text);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                frmMessageBox f = new frmMessageBox();
                //Leitura de Dados
                ModeloTipoUtilizador modelo = new ModeloTipoUtilizador();
                modelo.Dataatu = dtpAtualizacao.Value;
                modelo.Datacad = dtpCadastro.Value;
                modelo.Utilizador = txtCargo.Text;
                //objecto para gravar os dados
                DALConexao cx = new DALConexao(DALDadosdaConexao.StringDeConexao);
                BLLTipoUtilizador bll = new BLLTipoUtilizador(cx);
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

        private void frmTipoUtilizador_Load(object sender, EventArgs e)
        {
            btnLocalizar_Click(sender, e);
            dvgDados.Columns[0].HeaderText = "Código";
            dvgDados.Columns[0].Width = 60;
            dvgDados.Columns[1].HeaderText = "Cargo";
            dvgDados.Columns[1].Width = 200;
            dvgDados.Columns[2].HeaderText = "Data de cadastro";
            dvgDados.Columns[2].Width = 250;
            dvgDados.Columns[3].HeaderText = "Data de atualização";
            dvgDados.Columns[3].Width = 250;
            ///
            dvgDados.Columns[0].Visible = false;
            lblAtualizacao.Visible = false;
            dtpAtualizacao.Visible = false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo);
                if (true)
                {
                    DALConexao cx = new DALConexao(DALDadosdaConexao.StringDeConexao);
                    BLLTipoUtilizador bll = new BLLTipoUtilizador(cx);
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
            lblAtualizacao.Visible = false;
            dtpAtualizacao.Visible = false;
        }

        private void dvgDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                operacao = "alterar";
                txtId.Text = dvgDados.CurrentRow.Cells["id_tipoUtilizador"].Value.ToString();
                txtCargo.Text = dvgDados.CurrentRow.Cells["utilizador"].Value.ToString();
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
        }

        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

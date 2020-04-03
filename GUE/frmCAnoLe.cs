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
    public partial class frmCAnoLe : Form
    {
        public String operacao = "";
        public frmCAnoLe()
        {
            InitializeComponent();
        }
        public void LimpaTela()
        {
            txtId.Clear();
            txtDesc.Clear();
            txtAnoL.Clear();
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DALDadosdaConexao.StringDeConexao);
            BLLAnoLetivo bll = new BLLAnoLetivo(cx);
            dvgDados.DataSource = bll.Localizar(txtPesquisar.Text);
        }

        private void txtPesquisar_KeyUp(object sender, KeyEventArgs e)
        {
            DALConexao cx = new DALConexao(DALDadosdaConexao.StringDeConexao);
            BLLAnoLetivo bll = new BLLAnoLetivo(cx);
            dvgDados.DataSource = bll.Localizar(txtPesquisar.Text);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                frmMessageBox f = new frmMessageBox();
                //Leitura de Dados
                ModeloAnoLetivo modelo = new ModeloAnoLetivo();
                modelo.Descricao = txtDesc.Text;
                modelo.Ano = txtAnoL.Text;
                //objecto para gravar os dados
                DALConexao cx = new DALConexao(DALDadosdaConexao.StringDeConexao);
                BLLAnoLetivo bll = new BLLAnoLetivo(cx);
                if (this.operacao == "inserir")
                {
                    int r = 0;
                    r = bll.VerificarAno(txtAnoL.Text);
                    if (r > 0)
                    {
                        MessageBox.Show("O registro já se encontra no sistema");
                    }
                    else
                    {
                        //cadastrar as salas
                        bll.Incluir(modelo);
                        f.Show();
                        btnLocalizar_Click(sender, e);
                        //tabControlSala.SelectTab(tabSConsu);
                    }

                }
                else
                {
                    //Alterar a sala
                    modelo.AnoCod = Convert.ToInt32(txtId.Text);
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

        private void frmCAnoLe_Load(object sender, EventArgs e)
        {
            btnLocalizar_Click(sender, e);
            dvgDados.Columns[0].HeaderText = "Código";
            dvgDados.Columns[0].Width = 60;
            dvgDados.Columns[1].HeaderText = "Ano letivo";
            dvgDados.Columns[1].Width = 150;
            dvgDados.Columns[2].HeaderText = "Descrição";
            dvgDados.Columns[2].Width = 500;
            ///
            dvgDados.Columns[0].Visible = false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo);
                if (true)
                {
                    DALConexao cx = new DALConexao(DALDadosdaConexao.StringDeConexao);
                    BLLAnoLetivo bll = new BLLAnoLetivo(cx);
                    bll.Excluir(Convert.ToInt32(txtId.Text));
                    this.LimpaTela();
                    tabControlSala.SelectTab(tabSConsu);
                    btnLocalizar_Click(sender, e);
               

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
                txtId.Text = dvgDados.CurrentRow.Cells["id_anoletivo"].Value.ToString();
                txtAnoL.Text = dvgDados.CurrentRow.Cells["ano"].Value.ToString();
                txtDesc.Text = dvgDados.CurrentRow.Cells["descricao"].Value.ToString();                
                tabControlSala.SelectTab(tabSCad);
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

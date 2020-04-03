using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using BLL;
using DAL;
using Modelo;
using Modelo.Cache;

namespace GUE
{
    public partial class frmCaSala : Form
    {
        public String operacao = "";
        public int codigo = 0;
        public frmCaSala()
        {
            InitializeComponent();
        }
        public void LimpaTela()
        {
            txtId.Clear();
            txtDesc.Clear();
            txtSala.Clear();
        }
        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DALDadosdaConexao.StringDeConexao);
            BLLSala bll = new BLLSala(cx);
            dvgDados.DataSource = bll.Localizar(txtPesquisar.Text);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                frmMessageBox f = new frmMessageBox();
                //Leitura de Dados
                ModeloSala modelo = new ModeloSala();
                modelo.Descricao = txtDesc.Text;
                modelo.SaNum = txtSala.Text;
                //objecto para gravar os dados
                DALConexao cx = new DALConexao(DALDadosdaConexao.StringDeConexao);
                BLLSala bll = new BLLSala(cx);

                if (this.operacao == "inserir")
                {
                    int r = 0;
                    r = bll.VerificarSala(txtSala.Text);
                    if (r > 0)
                    {
                        MessageBox.Show("O registro já se encontra no sistema");
                    }
                    else
                    {
                        //cadastrar as salas
                        bll.Incluir(modelo);
                        f.Show();
                        btnNovo_Click(sender, e);
                        //tabControlSala.SelectTab(tabSConsu);
                    }
                }
                else 
                {
                    //Alterar a sala
                    modelo.SaCod = Convert.ToInt32(txtId.Text);
                    bll.Alterar(modelo);
                    f.Show();                    
                    btnNovo_Click(sender, e);
                   
                }
                this.LimpaTela();
                
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        public void CarregarLogin()
        {
            if (UserLoginCache.Cargo == Cargo.Professor)
            {
                btnNo.Enabled = false;
            }
            if (UserLoginCache.Cargo == Cargo.D_Administrador)
            {
                btnNo.Enabled = false;
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
        private void frmCaSala_Load(object sender, EventArgs e)
        {
            this.operacao = "inserir";
           
            btnNovo_Click(sender, e);
            dvgDados.Columns[0].HeaderText = "Código";
            dvgDados.Columns[0].Width = 60;
            dvgDados.Columns[1].HeaderText = "Sala";
            dvgDados.Columns[1].Width = 150;
            dvgDados.Columns[2].HeaderText = "Descrição";
            dvgDados.Columns[2].Width = 650;
            
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
                    BLLSala bll = new BLLSala(cx);
                    bll.Excluir(Convert.ToInt32(txtId.Text));
                    btnNovo_Click(sender, e);                   
                    this.LimpaTela();
                    tabControlSala.SelectTab(tabSConsu);

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

        private void txtPesquisar_KeyUp(object sender, KeyEventArgs e)
        {
            DALConexao cx = new DALConexao(DALDadosdaConexao.StringDeConexao);
            BLLSala bll = new BLLSala(cx);
            dvgDados.DataSource = bll.Localizar(txtPesquisar.Text);
        }

        private void dvgDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                operacao = "alterar";
                txtId.Text = dvgDados.CurrentRow.Cells["id_sala"].Value.ToString();
                txtSala.Text = dvgDados.CurrentRow.Cells["sala"].Value.ToString();
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
    }
}

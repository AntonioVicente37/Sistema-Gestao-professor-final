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
using Modelo.Cache;

namespace GUE
{
    public partial class frmCaCo : Form
    {
        public String operacao = "";
        public int codigo = 0;
        public frmCaCo()
        {
            InitializeComponent();
        }
        public void LimpaTela()
        {
            txtId.Clear();
            txtCoordenacao.Clear();
            cmbCoord.SelectedValue = false;
            cmbAno.SelectedValue = false;

        }
        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DALDadosdaConexao.StringDeConexao);
            BLLCordenacao bll = new BLLCordenacao(cx);
            dvgDados.DataSource = bll.Localizar(txtPesquisar.Text);
        }

        private void txtPesquisar_KeyUp(object sender, KeyEventArgs e)
        {
            DALConexao cx = new DALConexao(DALDadosdaConexao.StringDeConexao);
            BLLCordenacao bll = new BLLCordenacao(cx);
            dvgDados.DataSource = bll.Localizar(txtPesquisar.Text);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                frmMessageBox f = new frmMessageBox();
                //Leitura de Dados
                ModeloCordenacao modelo = new ModeloCordenacao();
                modelo.Coordenacao = txtCoordenacao.Text;
                modelo.ProCod = Convert.ToInt32(cmbCoord.SelectedValue);
                modelo.AnoCod = Convert.ToInt32(cmbAno.SelectedValue);
                //objecto para gravar os dados
                DALConexao cx = new DALConexao(DALDadosdaConexao.StringDeConexao);
                BLLCordenacao bll = new BLLCordenacao(cx);

                if (this.operacao == "inserir")
                {
                    int r = 0;
                    r = bll.VerificaCoordenacao(Convert.ToString(cmbCoord.SelectedValue));
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
                    modelo.CoCod = Convert.ToInt32(txtId.Text);
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
        public void Permicoes()
        {
            if (UserLoginCache.Cargo == Cargo.Professor)
            {

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
        private void frmCaCo_Load(object sender, EventArgs e)
        {
            Permicoes();
            ///Carregando os dados para o gridView
            btnLocalizar_Click(sender, e);
            dvgDados.Columns[0].HeaderText = "Código";
            dvgDados.Columns[0].Width = 60;
            dvgDados.Columns[1].HeaderText = "Coordenação";
            dvgDados.Columns[1].Width = 150;
            dvgDados.Columns[2].HeaderText = "Coordenador do curso";
            dvgDados.Columns[2].Width = 150;
            dvgDados.Columns[3].HeaderText = "Ano letivo";
            dvgDados.Columns[3].Width = 400;
            //
            dvgDados.Columns[0].Visible = false;
            ///Carregando os dados para serem apresentados nos Combobox
            /// ///Carrega curso          
            DALConexao cx = new DALConexao(DALDadosdaConexao.StringDeConexao);
            BLLProfessor cbll = new BLLProfessor(cx);
            cmbCoord.DataSource = cbll.Localizar("");
            cmbCoord.DisplayMember = "nome";
            cmbCoord.ValueMember = "num_agente";

            ///*********************************************/

            // //carrega sala
            BLLAnoLetivo sbll = new BLLAnoLetivo(cx);
            cmbAno.DataSource = sbll.Localizar("");
            cmbAno.DisplayMember = "ano";
            cmbAno.ValueMember = "id_anoletivo";
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo);
                if (true)
                {
                    DALConexao cx = new DALConexao(DALDadosdaConexao.StringDeConexao);
                    BLLCordenacao bll = new BLLCordenacao(cx);
                    bll.Excluir(Convert.ToInt32(txtId.Text));
                    btnLocalizar_Click(sender, e);
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

        private void dvgDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                operacao = "alterar";
                txtId.Text = dvgDados.CurrentRow.Cells["id_coordenacao"].Value.ToString();
                txtCoordenacao.Text = dvgDados.CurrentRow.Cells["coordenacao"].Value.ToString();
                cmbCoord.Text = dvgDados.CurrentRow.Cells[2].Value.ToString();
                cmbAno.Text = dvgDados.CurrentRow.Cells[3].Value.ToString();
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

        private void tabSConsu_Click(object sender, EventArgs e)
        {

        }
    }
}

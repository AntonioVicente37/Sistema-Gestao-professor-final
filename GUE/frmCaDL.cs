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
    public partial class frmCaDL : Form
    {
        public String operacao = "";
        public frmCaDL()
        {
            InitializeComponent();
        }
        public void LimpaTela()
        {
            txtId.Clear();
            txtDescricao.Clear();
            cmbProfessor.SelectedValue = false;
            cmbDisciplina.SelectedValue = false;

        }
        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DALDadosdaConexao.StringDeConexao);
            BLLDPLeciona bll = new BLLDPLeciona(cx);
            dvgDados.DataSource = bll.Localizar(txtPesquisar.Text);
        }

        private void txtPesquisar_KeyUp(object sender, KeyEventArgs e)
        {
            DALConexao cx = new DALConexao(DALDadosdaConexao.StringDeConexao);
            BLLDPLeciona bll = new BLLDPLeciona(cx);
            dvgDados.DataSource = bll.Localizar(txtPesquisar.Text);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                frmMessageBox f = new frmMessageBox();
                //Leitura de Dados
                ModeloDPLeciona modelo = new ModeloDPLeciona();
                modelo.DiCod = Convert.ToInt32(cmbDisciplina.SelectedValue);
                modelo.ProCod = Convert.ToInt32(cmbProfessor.SelectedValue);
                modelo.Descricao = txtDescricao.Text;
                //objecto para gravar os dados
                DALConexao cx = new DALConexao(DALDadosdaConexao.StringDeConexao);
                BLLDPLeciona bll = new BLLDPLeciona(cx);
                if (this.operacao == "inserir")
                {
                    int r = 0;
                    r = bll.VerificaDisciplinaLec(Convert.ToString(cmbDisciplina.SelectedValue), Convert.ToString(cmbProfessor.SelectedValue));
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
                    modelo.DpCod = Convert.ToInt32(txtId.Text);
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

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo);
                if (true)
                {
                    DALConexao cx = new DALConexao(DALDadosdaConexao.StringDeConexao);
                    BLLDPLeciona bll = new BLLDPLeciona(cx);
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
        private void frmCaDL_Load(object sender, EventArgs e)
        {
            CarregarLogin();
            btnLocalizar_Click(sender, e);
            dvgDados.Columns[0].HeaderText = "Código";
            dvgDados.Columns[0].Width = 60;
            dvgDados.Columns[1].HeaderText = "Disciplina";
            dvgDados.Columns[1].Width = 150;
            dvgDados.Columns[2].HeaderText = "Professor";
            dvgDados.Columns[2].Width = 150;
            dvgDados.Columns[3].HeaderText = "Descrição";
            dvgDados.Columns[3].Width = 150;           
            ///
            dvgDados.Columns[0].Visible = false;
            ///Carregando os dados para serem apresentados nos Combobox
            ///Carrega Professor
            DALConexao cx = new DALConexao(DALDadosdaConexao.StringDeConexao);
            BLLProfessor cbll = new BLLProfessor(cx);
            cmbProfessor.DataSource = cbll.Localizar("");
            cmbProfessor.DisplayMember = "nome";
            cmbProfessor.ValueMember = "num_agente";

            /*********************************************/

            //carrega Turma
            BLLDisciplina sbll = new BLLDisciplina(cx);
            cmbDisciplina.DataSource = sbll.Localizar("");
            cmbDisciplina.DisplayMember = "disciplina";
            cmbDisciplina.ValueMember = "id_disciplina";
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
                txtId.Text = dvgDados.CurrentRow.Cells["id_dp_leciona"].Value.ToString();
                txtDescricao.Text = dvgDados.CurrentRow.Cells["descricao"].Value.ToString();
                cmbProfessor.Text = dvgDados.CurrentRow.Cells[2].Value.ToString();
                cmbDisciplina.Text = dvgDados.CurrentRow.Cells[1].Value.ToString();
                
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

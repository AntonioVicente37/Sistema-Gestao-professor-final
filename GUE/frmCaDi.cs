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
    public partial class frmCaDi : Form
    {
        public String operacao = "";
        public frmCaDi()
        {
            InitializeComponent();
        }
        public void LimpaTela()
        {
            txtId.Clear();
            txtCarga.Clear();
            txtDisciplina.Clear();
            cmbComponente.Text = "";
            cmbCoordenacao.SelectedValue = false;
            cmbCurso.SelectedValue = false;
        }
        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DALDadosdaConexao.StringDeConexao);
            BLLDisciplina bll = new BLLDisciplina(cx);
            dvgDados.DataSource = bll.Localizar(txtPesquisar.Text);
        }

        private void txtPesquisar_KeyUp(object sender, KeyEventArgs e)
        {
            DALConexao cx = new DALConexao(DALDadosdaConexao.StringDeConexao);
            BLLDisciplina bll = new BLLDisciplina(cx);
            dvgDados.DataSource = bll.Localizar(txtPesquisar.Text);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                frmMessageBox f = new frmMessageBox();
                //Leitura de Dados
                ModeloDisciplina modelo = new ModeloDisciplina();
                modelo.CoCod = Convert.ToInt32(cmbCoordenacao.SelectedValue);
                modelo.CuCod = Convert.ToInt32(cmbCurso.SelectedValue);
                modelo.Componente = cmbComponente.Text;
                modelo.Disciplina = txtDisciplina.Text;
                modelo.Carga = txtCarga.Text;
                //objecto para gravar os dados
                DALConexao cx = new DALConexao(DALDadosdaConexao.StringDeConexao);
                BLLDisciplina bll = new BLLDisciplina(cx);
                if (this.operacao == "inserir")
                {
                    int r = 0;
                    r = bll.VerificarDisciplina(txtDisciplina.Text);
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
                    modelo.DiCod = Convert.ToInt32(txtId.Text);
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
        private void frmCaDi_Load(object sender, EventArgs e)
        {
            CarregarLogin();
            ///Carregando os dados para o gridView
            btnLocalizar_Click(sender, e);
            dvgDados.Columns[0].HeaderText = "Código";
            dvgDados.Columns[0].Width = 60;
            dvgDados.Columns[1].HeaderText = "Discíplina";
            dvgDados.Columns[1].Width = 200;
            dvgDados.Columns[2].HeaderText = "Curso";
            dvgDados.Columns[2].Width = 150;
            dvgDados.Columns[3].HeaderText = "Coordenação";
            dvgDados.Columns[3].Width = 150;
            dvgDados.Columns[4].HeaderText = "Componente";
            dvgDados.Columns[4].Width = 200;
            dvgDados.Columns[5].HeaderText = "Carga horária";
            dvgDados.Columns[5].Width = 100;
            //Codigo para ocultar campo
            dvgDados.Columns["id_disciplina"].Visible = false;
            ///Carregando os dados para serem apresentados nos Combobox
            DALConexao cx = new DALConexao(DALDadosdaConexao.StringDeConexao);
            BLLCurso cbll = new BLLCurso(cx);
            cmbCurso.DataSource = cbll.Localizar("");
            cmbCurso.DisplayMember = "curso";
            cmbCurso.ValueMember = "id_curso";

            /*********************************************/

            //carrega Turma
            BLLCordenacao sbll = new BLLCordenacao(cx);
            cmbCoordenacao.DataSource = sbll.Localizar("");
            cmbCoordenacao.DisplayMember = "coordenacao";
            cmbCoordenacao.ValueMember = "id_coordenacao";
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo);
                if (true)
                {
                    DALConexao cx = new DALConexao(DALDadosdaConexao.StringDeConexao);
                    BLLDisciplina bll = new BLLDisciplina(cx);
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
                txtId.Text = dvgDados.CurrentRow.Cells["id_disciplina"].Value.ToString();
                txtDisciplina.Text = dvgDados.CurrentRow.Cells["disciplina"].Value.ToString();
                txtCarga.Text = dvgDados.CurrentRow.Cells["carga_horaria"].Value.ToString();
                cmbCurso.Text = dvgDados.CurrentRow.Cells[2].Value.ToString();
                cmbCoordenacao.Text = dvgDados.CurrentRow.Cells[3].Value.ToString();
                cmbComponente.Text = dvgDados.CurrentRow.Cells[4].Value.ToString();
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

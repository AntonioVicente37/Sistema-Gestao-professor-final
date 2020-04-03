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
    public partial class frmTL : Form
    {
        public String operacao = "";
        public frmTL()
        {
            InitializeComponent();
        }
        public void LimpaTela()
        {
            txtId.Clear();
            //txtDesc.Clear();
            if (ckdTurma.Checked == true)
            {
                ckdTurma.Text = "Normal";
                ckdTurma.Checked = false;
            }
            cmbProfessor.SelectedValue = false;
            cmbTurma.SelectedValue = false;

        }
        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DALDadosdaConexao.StringDeConexao);
            BLLTPTurma bll = new BLLTPTurma(cx);
            dvgDados.DataSource = bll.Localizar(txtPesquisar.Text);
        }

        private void txtPesquisar_KeyUp(object sender, KeyEventArgs e)
        {
            DALConexao cx = new DALConexao(DALDadosdaConexao.StringDeConexao);
            BLLTPTurma bll = new BLLTPTurma(cx);
            dvgDados.DataSource = bll.Localizar(txtPesquisar.Text);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int t = 0;
            try
            {
                frmMessageBox f = new frmMessageBox();
                //Leitura de Dados
                ModeloTPTurma modelo = new ModeloTPTurma();
                modelo.TuCod = Convert.ToInt32(cmbTurma.SelectedValue);
                modelo.ProCod = Convert.ToInt32(cmbProfessor.SelectedValue);
                modelo.TpDir = ckdTurma.Text;
                //objecto para gravar os dados
                DALConexao cx = new DALConexao(DALDadosdaConexao.StringDeConexao);
                BLLTPTurma bll = new BLLTPTurma(cx);
                if (this.operacao == "inserir")
                {
                   // t = bll.VerificaDireitorTurma(ckdTurma.Text);
                    //if (true)
                    //{
                    //    MessageBox.Show("Esta turma ja tem um direitor de turma","O professor já é uma direitor de turma");
                    //}
                    //int r= 0;
                    //r = bll.VerificaTurmaLec(Convert.ToString(cmbTurma.SelectedValue), Convert.ToString(cmbProfessor.SelectedValue), ckdTurma.Text);
                    //if (t > 0)
                    //{
                    //    MessageBox.Show("A turma ja tem um direitor de turma");                    
                                           
                    //}
                  
                        //cadastrar as salas
                        bll.Incluir(modelo);
                        f.Show();
                        btnLocalizar_Click(sender, e);
                        //tabControlSala.SelectTab(tabSConsu);
                    
                    
                }
                else
                {
                    //Alterar a sala
                    modelo.TpCod = Convert.ToInt32(txtId.Text);
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
                    BLLTPTurma bll = new BLLTPTurma(cx);
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
        
        private void frmTL_Load(object sender, EventArgs e)
        {
            CarregarLogin();
            btnLocalizar_Click(sender, e);
            dvgDados.Columns[0].HeaderText = "Código";
            dvgDados.Columns[0].Width = 60;
            dvgDados.Columns[1].HeaderText = "Turma";
            dvgDados.Columns[1].Width = 150;
            dvgDados.Columns[2].HeaderText = "Professor";
            dvgDados.Columns[2].Width = 150;
            dvgDados.Columns[3].HeaderText = "Status";
            dvgDados.Columns[3].Width = 150;           
            ///
            dvgDados.Columns[0].Visible = false;
            ///Carregando os dados para serem apresentados nos Combobox
            DALConexao cx = new DALConexao(DALDadosdaConexao.StringDeConexao);
            BLLProfessor cbll = new BLLProfessor(cx);
            cmbProfessor.DataSource = cbll.Localizar("");
            cmbProfessor.DisplayMember = "nome";
            cmbProfessor.ValueMember = "num_agente";

            /*********************************************/

            //carrega Turma
            BLLTurma sbll = new BLLTurma(cx);
            cmbTurma.DataSource = sbll.Localizar("");
            cmbTurma.DisplayMember = "turma";
            cmbTurma.ValueMember = "id_turma";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.LimpaTela();
            tabControlSala.SelectTab(tabSConsu);
        }

        private void dvgDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ModeloTPTurma modelo = new ModeloTPTurma();
            if (e.RowIndex >= 0)
            {
                operacao = "alterar";
                txtId.Text = dvgDados.CurrentRow.Cells["id_aulas"].Value.ToString();
                ckdTurma.Text = dvgDados.CurrentRow.Cells["director_turma"].Value.ToString();
                cmbProfessor.Text = dvgDados.CurrentRow.Cells[2].Value.ToString();
                cmbTurma.Text = dvgDados.CurrentRow.Cells[1].Value.ToString();
                if (ckdTurma.Checked.ToString() == modelo.TpDir)
                {//"Director de turma"
                    ckdTurma.Checked = true;
                }
                //else
                //{
                //    ckdTurma.Checked = false;
                //}
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

        private void ckdTurma_CheckedChanged(object sender, EventArgs e)
        {
            if (ckdTurma.Checked == true)
            {

                ckdTurma.Text = "Director de turma";
            }
            else if (ckdTurma.Checked == false)
            {
                ckdTurma.Text = "Normal";
            }
        }
    }
}

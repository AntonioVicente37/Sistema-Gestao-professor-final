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
    public partial class frmCaPro : Form
    {
        public String operacao = "";
        public frmCaPro()
        {
            InitializeComponent();
        }
        public void LimpaTela()
        {
            txtId.Clear();
            txtTipoProva.Clear();
            mkbfinal.Clear();
            mkbinicial.Clear();
            txtPeriodo.Clear();
            cmbCoordenacao.SelectedValue = false;
            cmbDisciplina.SelectedValue = false;
            cmbprofessor.SelectedValue = false;
            cmbSala.SelectedValue = false;
            cmbTurma.SelectedValue = false;
            dtkprova.Value = DateTime.Now;

        }
        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DALDadosdaConexao.StringDeConexao);
            BLLProva bll = new BLLProva(cx);
            dvgDados.DataSource = bll.Localizar(txtPesquisar.Text);
        }

        private void txtPesquisar_KeyUp(object sender, KeyEventArgs e)
        {
            DALConexao cx = new DALConexao(DALDadosdaConexao.StringDeConexao);
            BLLProva bll = new BLLProva(cx);
            dvgDados.DataSource = bll.Localizar(txtPesquisar.Text);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                frmMessageBox f = new frmMessageBox();
                //Leitura de Dados
                ModeloProva modelo = new ModeloProva();
                modelo.TuCod = Convert.ToInt32(cmbTurma.SelectedValue);
                modelo.ProCod = Convert.ToInt32(cmbprofessor.SelectedValue);
                modelo.SaCod = Convert.ToInt32(cmbSala.SelectedValue);
                modelo.DiCod = Convert.ToInt32(cmbDisciplina.SelectedValue);
                modelo.CooCod = Convert.ToInt32(cmbCoordenacao.SelectedValue);
                modelo.Data = Convert.ToDateTime(dtkprova.Value);
                modelo.Periodo = txtPeriodo.Text;
                modelo.Tipo = txtTipoProva.Text;
                modelo.HInicial = Convert.ToString(mkbinicial.Text);
                modelo.HFinal = Convert.ToString(mkbfinal.Text);
                //objecto para gravar os dados
                DALConexao cx = new DALConexao(DALDadosdaConexao.StringDeConexao);
                BLLProva bll = new BLLProva(cx);
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
                    modelo.PvCod = Convert.ToInt32(txtId.Text);
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
                    BLLProva bll = new BLLProva(cx);
                    bll.Excluir(Convert.ToInt32(txtId.Text));
                    this.LimpaTela();
                    btnLocalizar_Click(sender, e);
                }
            }
            catch
            {
                MessageBox.Show("impossível excluir o registro. \n O registro esta sendo utilizado em outro local.");

            }
        }
        public void Permicao()
        {
            if (UserLoginCache.Cargo == 1)
            {
                //lblCargo.Text = "Administrador";
            }
            if (UserLoginCache.Cargo == 2)
            {
                //lblCargo.Text = "Secretaria";
            }
            if (UserLoginCache.Cargo == 3)
            {
                //lblCargo.Text = "D.Pedagógico";
                //btnNo.Enabled = false;
            }
            if (UserLoginCache.Cargo == 4)
            {
                //lblCargo.Text = "D.Administrativo";
                btnNo.Enabled = false;
            }
            if (UserLoginCache.Cargo == 5)
            {
                //lblCargo.Text = "Professor";
                btnNo.Enabled = false;
            }
            if (UserLoginCache.Cargo == 6)
            {
                //lblCargo.Text = "Secretária Admin";
            }
            if (UserLoginCache.Cargo == 7)
            {
                //lblCargo.Text = "Secretária Pedagógica";
            }
        }
        private void frmCaPro_Load(object sender, EventArgs e)
        {
            Permicao();
            btnLocalizar_Click(sender, e);
            dvgDados.Columns[0].HeaderText = "Código";
            dvgDados.Columns[0].Width = 60;
            dvgDados.Columns[1].HeaderText = "Professor";
            dvgDados.Columns[1].Width = 200;
            dvgDados.Columns[2].HeaderText = "Turma";
            dvgDados.Columns[2].Width = 100;
            dvgDados.Columns[3].HeaderText = "Disciplina";
            dvgDados.Columns[3].Width = 100;
            dvgDados.Columns[4].HeaderText = "Sala";
            dvgDados.Columns[4].Width = 80;
            dvgDados.Columns[5].HeaderText = "Coordenação";
            dvgDados.Columns[5].Width = 150;
            dvgDados.Columns[6].HeaderText = "Tipo de prova";
            dvgDados.Columns[6].Width = 100;
            dvgDados.Columns[7].HeaderText = "Periodo";
            dvgDados.Columns[7].Width = 100;
            dvgDados.Columns[8].HeaderText = "Data da prova";
            dvgDados.Columns[8].Width = 150;
            dvgDados.Columns[9].HeaderText = "Hora inicial";
            dvgDados.Columns[9].Width = 80;
            dvgDados.Columns[10].HeaderText = "Hora fina";
            dvgDados.Columns[10].Width = 80;
            //Codigo para ocultar campo
            dvgDados.Columns[0].Visible = false;
            ///Carregando os dados para serem apresentados nos Combobox
            /// this.alterabotoes(1);
            DALConexao cx = new DALConexao(DALDadosdaConexao.StringDeConexao);
            BLLProfessor cbll = new BLLProfessor(cx);
            cmbprofessor.DataSource = cbll.Localizar("");
            cmbprofessor.DisplayMember = "nome";
            cmbprofessor.ValueMember = "num_agente";

            /*********************************************/

            //carrega Turma
            BLLTurma sbll = new BLLTurma(cx);
            cmbTurma.DataSource = sbll.Localizar("");
            cmbTurma.DisplayMember = "turma";
            cmbTurma.ValueMember = "id_turma";
            //carrega Disciplina
            BLLDisciplina dbll = new BLLDisciplina(cx);
            cmbDisciplina.DataSource = dbll.Localizar("");
            cmbDisciplina.DisplayMember = "disciplina";
            cmbDisciplina.ValueMember = "id_disciplina";

            //carrega Sala
            BLLSala bll = new BLLSala(cx);
            cmbSala.DataSource = bll.Localizar("");
            cmbSala.DisplayMember = "sala";
            cmbSala.ValueMember = "id_sala";
            
            BLLCordenacao cobll = new BLLCordenacao(cx);
            cmbCoordenacao.DataSource = cobll.Localizar("");
            cmbCoordenacao.DisplayMember = "coordenacao";
            cmbCoordenacao.ValueMember = "id_coordenacao";
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
                txtId.Text = dvgDados.CurrentRow.Cells["id_prova"].Value.ToString();
                txtPeriodo.Text = dvgDados.CurrentRow.Cells["periodo"].Value.ToString();
                dtkprova.Text = dvgDados.CurrentRow.Cells["data"].Value.ToString();
                txtTipoProva.Text = dvgDados.CurrentRow.Cells["tipo_prova"].Value.ToString();
                mkbinicial.Text = dvgDados.CurrentRow.Cells["hora_inicial"].Value.ToString();
                mkbfinal.Text = dvgDados.CurrentRow.Cells["hora_final"].Value.ToString();
                cmbprofessor.Text = dvgDados.CurrentRow.Cells[1].Value.ToString();
                cmbDisciplina.Text = dvgDados.CurrentRow.Cells[3].Value.ToString();
                cmbSala.Text = dvgDados.CurrentRow.Cells[4].Value.ToString();
                cmbTurma.Text = dvgDados.CurrentRow.Cells[2].Value.ToString();
                cmbCoordenacao.Text = dvgDados.CurrentRow.Cells[5].Value.ToString();            

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

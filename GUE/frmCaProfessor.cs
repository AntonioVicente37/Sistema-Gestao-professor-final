using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Modelo;
using BLL;
using DAL;
using System.Drawing.Imaging;
using System.Data.SqlClient;
using Modelo.Cache;

namespace GUE
{
    public partial class frmCaProfessor : Form
    {
       

        DALConexao cx = new DALConexao(DALDadosdaConexao.StringDeConexao);
        private String operacao = "";
        private string foto = "";
        private int codigo = 0;
        public frmCaProfessor()
        {
            InitializeComponent();
        }
        public void LimpaTela()
        {
            txtId.Clear();
            txtBilhete.Clear();
            txtEmail.Clear();
            txtNome.Clear();
            mkdbFone.Clear();
            this.foto = "";
            dtpCada.Value = DateTime.Now;
            dtpActu.Value = DateTime.Now;
            cmbMunici.SelectedValue = false;
            cmbsexo.Text = "";
            pbeFoto.Image = null;
        }
        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DALDadosdaConexao.StringDeConexao);
            BLLProfessor bll = new BLLProfessor(cx);
            dvgDados.DataSource = bll.Localizar(txtPesquisar.Text);
        }

        private void txtPesquisar_KeyUp(object sender, KeyEventArgs e)
        {
            DALConexao cx = new DALConexao(DALDadosdaConexao.StringDeConexao);
            BLLProfessor bll = new BLLProfessor(cx);
            dvgDados.DataSource = bll.Localizar(txtPesquisar.Text);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                frmMessageBox f = new frmMessageBox();
                //Leitura de Dados
                ModeloProfessor modelo = new ModeloProfessor();
                modelo.NumAgente = Convert.ToInt32(txtId.Text);
                modelo.Penome = txtNome.Text;
                modelo.Peemail = txtEmail.Text;
                modelo.Pesexo = cmbsexo.Text;
                modelo.Petelefone = mkdbFone.Text;
                modelo.PeBI = txtBilhete.Text;
                modelo.MuCod = Convert.ToInt32(cmbMunici.SelectedValue);
                modelo.DataCadastro = Convert.ToDateTime(dtpCada.Value);
                modelo.DataAtualizacao = Convert.ToDateTime(dtpActu.Value);
                //objecto para gravar os dados
                DALConexao cx = new DALConexao(DALDadosdaConexao.StringDeConexao);
                BLLProfessor bll = new BLLProfessor(cx);
                if (this.operacao == "inserir")
                {
                    //cadastrar as salas
                    modelo.CarregaImagem(this.foto);
                    bll.Incluir(modelo);
                    f.Show();
                    btnLocalizar_Click(sender, e);
                    //tabControlSala.SelectTab(tabSConsu);
                }
                else
                {
                    //Alterar a sala
                    modelo.NumAgente = Convert.ToInt32(txtId.Text);
                    if (this.foto == "Foto Original")
                    {
                        ModeloProfessor mt = bll.CarregaModeloProfessor(modelo.NumAgente);
                        modelo.Pefoto = mt.Pefoto;
                    }
                    else
                    {
                        modelo.CarregaImagem(this.foto);
                    }
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
                    BLLProfessor bll = new BLLProfessor(cx);
                    bll.Excluir(Convert.ToInt32(txtId.Text));
                    this.LimpaTela();
                    btnLocalizar_Click(sender, e);
                    tabControlSala.SelectTab(tabSConsu);
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
        private void frmCaProfessor_Load(object sender, EventArgs e)
        {
            CarregarLogin();
            btnLocalizar_Click(sender, e);
            dvgDados.Columns[0].HeaderText = "Numero de agente";
            dvgDados.Columns[0].Width = 100;
            dvgDados.Columns[1].HeaderText = "Nome";
            dvgDados.Columns[1].Width = 150;
            dvgDados.Columns[2].HeaderText = "Número de Telefone";
            dvgDados.Columns[2].Width = 150;
            dvgDados.Columns[3].HeaderText = "Bilhete de identidade";
            dvgDados.Columns[3].Width = 200;
            dvgDados.Columns[4].HeaderText = "Bairro";
            dvgDados.Columns[4].Width = 90;
            dvgDados.Columns[5].HeaderText = "Fotografia";
            dvgDados.Columns[5].Width = 150;
            dvgDados.Columns[6].HeaderText = "Sexo";
            dvgDados.Columns[6].Width = 80;
            dvgDados.Columns[7].HeaderText = "E-mail";
            dvgDados.Columns[7].Width = 200;
            dvgDados.Columns[8].HeaderText = "Data de Cadastro";
            dvgDados.Columns[8].Width = 100;
            dvgDados.Columns[9].HeaderText = "Data de Actualização";
            dvgDados.Columns[9].Width = 100;
            ///
            //dvgDados.Columns[0].Visible = false;
            //dvgDados.Columns["id_pessoa"].Visible = false;
            dvgDados.Columns[9].Visible = false;
            dvgDados.Columns[5].Visible = false;
            ///Carregando os dados para serem apresentados nos Combobox
            DALConexao cx = new DALConexao(DALDadosdaConexao.StringDeConexao);
            BLLMunicipio bll = new BLLMunicipio(cx);
            cmbMunici.DataSource = bll.Localizar("");
            cmbMunici.DisplayMember = "bairro";
            cmbMunici.ValueMember = "id_municipio";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.LimpaTela();
            dtpActu.Visible = false;
            lblDataAc.Visible = false;
            tabControlSala.SelectTab(tabSConsu);
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.ShowDialog();
            if (!string.IsNullOrEmpty(od.FileName))
            {
                this.foto = od.FileName;
                pbeFoto.Load(this.foto);

            }
        }

        private void btnRM_Click(object sender, EventArgs e)
        {
            this.foto = "";
            pbeFoto.Image = null;
        }

        private void dvgDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           ModeloProfessor modelo = new ModeloProfessor();
            if (e.RowIndex >= 0)
            {
                operacao = "alterar";
                txtId.Text = dvgDados.CurrentRow.Cells["num_agente"].Value.ToString();
                txtNome.Text = dvgDados.CurrentRow.Cells["nome"].Value.ToString();
                mkdbFone.Text = dvgDados.CurrentRow.Cells["telefone"].Value.ToString();
                txtBilhete.Text = dvgDados.CurrentRow.Cells["B_I"].Value.ToString();
                txtEmail.Text = dvgDados.CurrentRow.Cells["email"].Value.ToString();
                cmbsexo.Text = dvgDados.CurrentRow.Cells[6].Value.ToString();
                dtpCada.Text = dvgDados.CurrentRow.Cells["dataCadastro"].Value.ToString();
                dtpActu.Text = dvgDados.CurrentRow.Cells["dataActualizacao"].Value.ToString();
                cmbMunici.Text = dvgDados.CurrentRow.Cells[4].Value.ToString();                   
                try
                {
                    MemoryStream ms = new MemoryStream(modelo.Pefoto);
                    //pbeFoto.Image = dvgDados.CurrentRow.Cells[].Value.ToString();
                    pbeFoto.Image = Image.FromStream(ms);
                    this.foto = "Foto Original";                    
                }
                catch { }
                
                   
              


                dtpActu.Visible = true;
                lblDataAc.Visible = true;
                tabControlSala.SelectTab(tabSCad);
            }
            else
                MessageBox.Show("Selecine uma linha");
        }

        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            tabControlSala.SelectTab(tabSCad);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pbeFoto_Click(object sender, EventArgs e)
        {

        }

        private void tabSCad_Click(object sender, EventArgs e)
        {

        }

        private void btnRM_Click_1(object sender, EventArgs e)
        {
            this.foto = "";
            pbeFoto.Image = null;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //ModeloProfessor modelo = new ModeloProfessor();
            //if (dvgDados.SelectedRows.Count > 0)
            //{
            //    operacao = "alterar";
            //    txtId.Text = dvgDados.CurrentRow.Cells["num_agente"].Value.ToString();
            //    txtNome.Text = dvgDados.CurrentRow.Cells["nome"].Value.ToString();
            //    mkdbFone.Text = dvgDados.CurrentRow.Cells["telefone"].Value.ToString();
            //    txtBilhete.Text = dvgDados.CurrentRow.Cells["B_I"].Value.ToString();
            //    txtEmail.Text = dvgDados.CurrentRow.Cells["email"].Value.ToString();
            //    cmbsexo.Text = dvgDados.CurrentRow.Cells[6].Value.ToString();
            //    dtpCada.Text = dvgDados.CurrentRow.Cells["dataCadastro"].Value.ToString();
            //    dtpActu.Text = dvgDados.CurrentRow.Cells["dataActualizacao"].Value.ToString();
            //    cmbMunici.Text = dvgDados.CurrentRow.Cells[4].Value.ToString();
            //    // Verimagem(pbeFoto);
            //    try
            //    {
            //        MemoryStream ms = new MemoryStream(modelo.Pefoto);
            //        //pbeFoto.Image = dvgDados.CurrentRow.Cells[].Value.ToString();
            //        pbeFoto.Image = Image.FromStream(ms);
            //        this.foto = "Foto Original";
            //    }
            //    catch { }





            //    dtpActu.Visible = true;
            //    lblDataAc.Visible = true;
            //    tabControlSala.SelectTab(tabSCad);
            //}
            //else
            //    MessageBox.Show("Selecine uma linha");
        }
        //public void Verimagem(PictureBox imagen)
        //{
        //    SqlCommand com = new SqlCommand("select t_professor from  where foto='"+5+"' ");

        //    SqlDataAdapter dp = new SqlDataAdapter(com);
        //    DataSet ds = new DataSet("foto");
        //    dp.Fill(ds,"foto");
        //    byte[] DAtos = new byte[0];
        //    DataRow DR = ds.Tables["foto"].Rows[0];

        //    DAtos = (byte[])DR["foto"];

        //    System.IO.MemoryStream ms = new System.IO.MemoryStream(DAtos);
        //    imagen.Image = System.Drawing.Bitmap.FromStream(ms);
        //}
    }
}

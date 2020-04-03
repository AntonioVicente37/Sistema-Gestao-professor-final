using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUE.Relatorio
{
    public partial class frmGeRelatorio : Form
    {
        public frmGeRelatorio()
        {
            InitializeComponent();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {

        }

        private void txtPesquisar_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void dvgDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmGeRelatorio_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'impalsgpDataSetProfessor1.t_professor' table. You can move, or remove it, as needed.
          
        }

        private void btnNovo_Click_1(object sender, EventArgs e)
        {
            tabControlSala.SelectTab(tabRelaProfessor);
        }

        private void btnNo_Click_1(object sender, EventArgs e)
        {
            frmRelatorioHorario frm = new frmRelatorioHorario();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmPresencaProfessor frm = new frmPresencaProfessor();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //tabControlSala.SelectTab(tabPresencaGeral);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //tabControlSala.SelectTab(tabProvaGeral);
        }

        private void btnPresenca_Click(object sender, EventArgs e)
        {
            //tabControlSala.SelectTab(tabProva);
            frmHoProva frm = new frmHoProva();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmHoProva frm = new frmHoProva();                  
             frm.ShowDialog();
            frm.Dispose();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            this.t_professorTableAdapter.Fill(this.impalsgpDataSetProfessor1.t_professor, txtProfessor.Text);
            // TODO: This line of code loads data into the 'GprofessimpalsgpDataSet.DataTable13Professor' table. You can move, or remove it, as needed.

            this.reportViewer1.RefreshReport();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            tabControlSala.SelectTab(tabGerarRelatorio);            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            tabControlSala.SelectTab(tabGerarRelatorio);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            tabControlSala.SelectTab(tabGerarRelatorio);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            tabControlSala.SelectTab(tabGerarRelatorio);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.DataTableHorarioTableAdapter.Fill(this.impalsgpDataSet.DataTableHorario,txtProfessor.Text);

            //this.reportViewer1.RefreshReport();
        }

        private void btnGeralProfessor_Click(object sender, EventArgs e)
        {
            frmRlatorioGeProfesso frm = new frmRlatorioGeProfesso();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void btnDl_Click(object sender, EventArgs e)
        {
            frmDiciplinaProfeLeciona frm = new frmDiciplinaProfeLeciona();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void btnTl_Click(object sender, EventArgs e)
        {
            frmTurmaProfessorLeciona frm = new frmTurmaProfessorLeciona();
            frm.ShowDialog();
            frm.Dispose();
        }
    }
}

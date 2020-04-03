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
    public partial class frmTurmaProfessorLeciona : Form
    {
        public frmTurmaProfessorLeciona()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmGeRelatorio frm = new frmGeRelatorio();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTurmaProfessorLeciona_Load(object sender, EventArgs e)
        {
            
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'impalsgpDataSetProfessor1.DataTable2TAulas' table. You can move, or remove it, as needed.
            this.DataTable2TAulasTableAdapter.Fill(this.impalsgpDataSetProfessor1.DataTable2TAulas,txtProfessor.Text);

            this.reportViewer1.RefreshReport();
        }
    }
}

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
    public partial class frmDiciplinaProfeLeciona : Form
    {
        public frmDiciplinaProfeLeciona()
        {
            InitializeComponent();
        }

        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmGeRelatorio frm = new frmGeRelatorio();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void frmDiciplinaProfeLeciona_Load(object sender, EventArgs e)
        {
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            this.DataTable1TableAdapter.Fill(this.impalsgpDataSetProfessor1.DataTable1,txtProfessor.Text);
            // TODO: This line of code loads data into the 'impalsgpDataSetProfessor1.DataTable1Dados' table. You can move, or remove it, as needed.

            this.reportViewer1.RefreshReport();
        }
    }
}

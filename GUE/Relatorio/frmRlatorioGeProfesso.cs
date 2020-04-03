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
    public partial class frmRlatorioGeProfesso : Form
    {
        public frmRlatorioGeProfesso()
        {
            InitializeComponent();
        }

        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRlatorioGeProfesso_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'GprofessimpalsgpDataSet.DataTable1GProfessor' table. You can move, or remove it, as needed.
            this.DataTable1GProfessorTableAdapter.Fill(this.GprofessimpalsgpDataSet.DataTable1GProfessor);

            this.reportViewer1.RefreshReport();
        }
    }
}

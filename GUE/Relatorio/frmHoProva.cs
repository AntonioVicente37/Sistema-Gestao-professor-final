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
    public partial class frmHoProva : Form
    {
        public frmHoProva()
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

        private void frmHoProva_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'impalsgpDataSetProfessor1.t_Mprova' table. You can move, or remove it, as needed.
           
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            this.t_MprovaTableAdapter.Fill(this.impalsgpDataSetProfessor1.t_Mprova,txtProfessor.Text);

            this.reportViewer1.RefreshReport();
        }
    }
}

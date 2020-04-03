using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GUE
{
    public partial class frmTesteFoto : Form
    {
        public string foto = "";
        public frmTesteFoto()
        {
            InitializeComponent();
        }

     

        private void frmTesteFoto_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.ShowDialog();
            if (!string.IsNullOrEmpty(od.FileName))
            {
                this.foto = od.FileName;
                pbeFoto.Load(this.foto);

            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.foto = "";
            pbeFoto.Image = null;
        }
    }
}

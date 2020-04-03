using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo.Cache;

namespace GUE
{
    public partial class frmAnimacao : Form
    {
        public frmAnimacao()
        {
            InitializeComponent();
        }
        int cont = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.05;
            progressBar1.Value += 1;
            lblcont.Text = progressBar1.Value.ToString() + "%";
            if (progressBar1.Value == 100)
            {
                
                timer1.Stop();
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            if (this.Opacity == 0)
            {
                //lblcont.Text = progressBar1.Value.ToString() + "%";
                timer2.Stop();
                this.Close();
            }
        }

        private void frmAnimacao_Load(object sender, EventArgs e)
        {
            lblUsername.Text = UserLoginCache.Nome + ", " + UserLoginCache.Sobrenome;
            this.Opacity = 0.0; 
            timer1.Start();
        }
    }
}

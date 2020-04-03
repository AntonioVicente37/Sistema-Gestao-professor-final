using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using BLL;


namespace GUE
{
    public partial class TrDashboard : UserControl
    {
        public TrDashboard()
        {
            InitializeComponent();
        }
        public void Dashboard()
        {
            N_Dashboard neg = new N_Dashboard();
            E_Dashboard obj = new E_Dashboard();
            neg.Dashboard(obj);
            lbCurso.Text = obj.CantCurso1;
            lblCoordencao.Text = obj.CantCoordenacao1;
            lblDisciplina.Text = obj.CantDisciplina1;
            lblProfessor.Text = obj.CantProfessor1;
            lblProva.Text = obj.CantProva1;
            lblSala.Text = obj.CantSala1;
            lblTurma.Text = obj.CantTurma1;

        }

        private void TrDashboard_Load(object sender, EventArgs e)
        {
            //dtdata.Value = data;
            Dashboard();
        }
    }
}

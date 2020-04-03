using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using BLL;
using DAL;

namespace GUE
{
    public partial class frmDashbord : Form
    {
        //private DALConexao conexao;
        private DateTime data = DateTime.Now;
        //public frmDashbord()
        //{
        //    InitializeComponent();
        //}

        //public frmDashbord(DALConexao conexao)
        //{
        //    this.conexao = conexao;
        //}

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
        private void frmDashbord_Load(object sender, EventArgs e)
        {
            dtdata.Value = data;
            Dashboard();
        }
    }
}

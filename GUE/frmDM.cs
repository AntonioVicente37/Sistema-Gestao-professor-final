using BLL;
using Model;
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
    public partial class frmDM : Form
    {
        private DateTime data = DateTime.Now;
        public frmDM()
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
        public void Permicoes()
        {
            if (UserLoginCache.Cargo == Cargo.Professor)
            {
                pnCoordenacao.Visible = false;
                pnCurso.Visible = false;
                pnProfessor.Visible = false;
                pnSala.Visible = false;
                pnTurma.Visible = false;                

            }
            if (UserLoginCache.Cargo == Cargo.D_Administrador)
            {

            }
            if (UserLoginCache.Cargo == Cargo.D_Pedagogico)
            {
            }
            if (UserLoginCache.Cargo == Cargo.Secretaria)
            {
                //pnCoordenacao.Visible = false;
                //pnCurso.Visible = false;
                //pnProfessor.Visible = false;
                //pnSala.Visible = false;
                //pnTurma.Visible = false;
            }
            if (UserLoginCache.Cargo == Cargo.Secretaria_Admin)
            {

            }
            if (UserLoginCache.Cargo == Cargo.Secretaria_pedago)
            {

            }
        }
        private void frmDM_Load(object sender, EventArgs e)
        {
            Permicoes();
            //dtdata.Value = data;
            lbldata.Text = DateTime.Now.ToLongDateString();
            Dashboard();
        }

        private void dataatual_Tick(object sender, EventArgs e)
        {
            lbldata.Text = DateTime.Now.ToLongDateString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo.Cache;
using DAL;
using BLL;

namespace GUE
{
    public partial class frmM : Form
    {
      
        public frmM()
        {
            InitializeComponent();
            pnSider.Height = btnHome.Height;
            pnSider.Top = btnHome.Top;
            lblOpcoes.Visible = true;
            lblOpcoes.Text = "Dashboard";
            Abrirformulario<frmDM>();
            pnTab.Visible = false;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hmd, int wmsg, int wparam, int lparam);
        public void CarregarLogin()
        {

            lblUser.Text = UserLoginCache.Nome + " " + UserLoginCache.Sobrenome;
            lblEmail.Text = UserLoginCache.Email;
            if (UserLoginCache.Cargo == 1)
            {
                lblCargo.Text = "Administrador";
            }
            if (UserLoginCache.Cargo == 2)
            {
                lblCargo.Text = "Secretaria";
            }
            if (UserLoginCache.Cargo == 3)
            {
                lblCargo.Text = "D.Pedagógico";
            }
            if (UserLoginCache.Cargo == 4)
            {
                lblCargo.Text = "D.Administrativo";
            }
            if (UserLoginCache.Cargo == 5)
            {
                lblCargo.Text = "Professor";
            }
            if (UserLoginCache.Cargo == 6)
            {
                lblCargo.Text = "Secretária Admin";
            }
            if (UserLoginCache.Cargo == 7)
            {
                lblCargo.Text = "Secretária Pedagógica";
            }
        }
        private void AbrirformularioTab<MiForm>() where MiForm : Form, new()
        {

            Form formulario;
            formulario = pnCentro.Controls.OfType<MiForm>().FirstOrDefault();//Busca uma coleção de formulario
            //se o formulario / instanciado não existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                pnTab.Controls.Add(formulario);
                pnTab.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                //formulario.FormClosed += new FormClosedEventHandler(CloseForm);
            }
            //se o formulario / instanciado existe
            else
            {
                formulario.BringToFront();
            }
        }
        private void Abrirformulario<MiForm>() where MiForm : Form, new()
        {

            Form formulario;
            formulario = pnCentro.Controls.OfType<MiForm>().FirstOrDefault();//Busca uma coleção de formulario
            //se o formulario / instanciado não existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                pnCentro.Controls.Add(formulario);
                pnCentro.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                //formulario.FormClosed += new FormClosedEventHandler(CloseForm);
            }
            //se o formulario / instanciado existe
            else
            {
                formulario.BringToFront();
            }
        }
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem a ceteza que quer encerrar o sistema", "Alerta", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {

            }
        }
        int LX, LY, SW, SH;
        private void btnmaximizar_Click(object sender, EventArgs e)
        {
            LX = this.Location.X;
            LY = this.Location.Y;
            SW = this.Size.Width;
            SH = this.Size.Height;

            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            btnrestaurar.Visible = true;
            btnmaximizar.Visible = false;
        }

        private void btnrestaurar_Click(object sender, EventArgs e)
        {

            this.Size = new Size(SW, SH);
            this.Location = new Point(LX, LY);
            btnmaximizar.Visible = true;
            btnrestaurar.Visible = false;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            pnSider.Height = btnHome.Height;
            pnSider.Top = btnHome.Top;
            lblOpcoes.Visible = true;
            lblOpcoes.Text = "Dashboard";
            pnMenu.Visible = false;
            Abrirformulario<frmDM>();
            pnCentro.Visible = true;
            pnTab.Visible = false;
            pnProfessor.Visible = false;
            pnAministrativa.Visible = false;

        }

        private void btnGAcade_Click(object sender, EventArgs e)
        {
            pnSider.Height = btnGAcade.Height;
            pnSider.Top = btnGAcade.Top;
            pnMenu.Visible = true;
            lblOpcoes.Visible = true;
            lblOpcoes.Text = "Opções Academicas";
            pnMenu.BringToFront();
            lblOpcoes.BringToFront();
            pnTab.Visible = false;
            pnProfessor.Visible = false;
            pnAministrativa.Visible = false;

        }

        private void btnGpross_Click(object sender, EventArgs e)
        {
            pnSider.Height = btnGpross.Height;
            pnSider.Top = btnGpross.Top;
            lblOpcoes.Visible = true;
            lblOpcoes.Text = "Opções do Professores";
            pnMenu.Visible = false;
            pnProfessor.Visible = true;
            lblOpcoes.BringToFront();
            pnProfessor.BringToFront();
            pnTab.Visible = false;       
            pnAministrativa.Visible = false;

        }

        private void btnOpco_Click(object sender, EventArgs e)
        {
            pnSider.Height = btnOpco.Height;
            pnSider.Top = btnOpco.Top;
            lblOpcoes.Visible = true;
            lblOpcoes.Text = "Opções do Administrador";
            pnMenu.Visible = false;
            pnProfessor.Visible = false;
            pnAministrativa.Visible = true;
            lblOpcoes.BringToFront();
            pnTab.Visible = false;
            ///         

        }

        private void btnCurso_Click(object sender, EventArgs e)
        {
            lblOpcoes.Visible = false;
            pnMenu.Visible = false;
            pnCentro.Visible = false;
            pnTab.Visible = true;
            AbrirformularioTab<frmCaCu>();
        }

        private void btnCoordenacao_Click(object sender, EventArgs e)
        {
            lblOpcoes.Visible = false;
            pnMenu.Visible = false;
            pnCentro.Visible = false;
            pnTab.Visible = true;
            AbrirformularioTab<frmCaCo>();
        }

        private void btnTurma_Click(object sender, EventArgs e)
        {
            lblOpcoes.Visible = false;
            pnMenu.Visible = false;
            pnCentro.Visible = false;
            pnTab.Visible = true;
            AbrirformularioTab<frmCaTu>();
        }

        private void btnDisciplina_Click(object sender, EventArgs e)
        {
            lblOpcoes.Visible = false;
            pnMenu.Visible = false;
            pnCentro.Visible = false;
            pnTab.Visible = true;
            AbrirformularioTab<frmCaDi>();
        }

        private void btnDL_Click(object sender, EventArgs e)
        {
            lblOpcoes.Visible = false;
            pnMenu.Visible = false;
            pnCentro.Visible = false;
            pnTab.Visible = true;
            pnProfessor.Visible = false;
            AbrirformularioTab<frmCaDL>();
        }

        private void btnTL_Click(object sender, EventArgs e)
        {
            lblOpcoes.Visible = false;
            pnMenu.Visible = false;
            pnCentro.Visible = false;
            pnTab.Visible = true;
            pnProfessor.Visible = false;
            AbrirformularioTab<frmTL>();
        }

        private void btnProva_Click(object sender, EventArgs e)
        {
            lblOpcoes.Visible = false;
            pnMenu.Visible = false;
            pnCentro.Visible = false;
            pnTab.Visible = true;
            pnProfessor.Visible = false;
            AbrirformularioTab<frmCaPro>();
        }

        private void btnProfessor_Click(object sender, EventArgs e)
        {
            lblOpcoes.Visible = false;
            pnMenu.Visible = false;
            pnCentro.Visible = false;
            pnTab.Visible = true;
            pnProfessor.Visible = false;
            AbrirformularioTab<frmCaProfessor>();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            lblOpcoes.Visible = false;
            pnMenu.Visible = false;
            pnCentro.Visible = false;
            pnTab.Visible = true;
            pnProfessor.Visible = false;
            AbrirformularioTab<frmHorario>();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            lblOpcoes.Visible = false;
            pnMenu.Visible = false;
            pnCentro.Visible = false;
            pnTab.Visible = true;
            pnProfessor.Visible = false;
            AbrirformularioTab<frmCaPrens>();
        }

        private void btnDAdmini_Click(object sender, EventArgs e)
        {
            lblOpcoes.Visible = false;
            pnMenu.Visible = false;
            pnCentro.Visible = false;
            pnTab.Visible = true;
           pnAministrativa.Visible = false;
            AbrirformularioTab<frmCDiAdministrativa>();
        }

        private void btnDPeda_Click(object sender, EventArgs e)
        {
            lblOpcoes.Visible = false;
            pnMenu.Visible = false;
            pnCentro.Visible = false;
            pnTab.Visible = true;
            pnAministrativa.Visible = false;
            AbrirformularioTab<frmDPedago>();
        }

        private void btnAnoL_Click(object sender, EventArgs e)
        {
            lblOpcoes.Visible = false;
            pnMenu.Visible = false;
            pnCentro.Visible = false;
            pnTab.Visible = true;
            pnAministrativa.Visible = false;
            AbrirformularioTab<frmCAnoLe>();
        }

        private void btnMuni_Click(object sender, EventArgs e)
        {
            lblOpcoes.Visible = false;
            pnMenu.Visible = false;
            pnCentro.Visible = false;
            pnTab.Visible = true;
            pnAministrativa.Visible = false;
            AbrirformularioTab<frmCMunicip>();
        }

        private void btnTiUt_Click(object sender, EventArgs e)
        {
            lblOpcoes.Visible = false;
            pnMenu.Visible = false;
            pnCentro.Visible = false;
            pnTab.Visible = true;
            pnAministrativa.Visible = false;
            AbrirformularioTab<frmTipoUtilizador>();
        }

        private void btnUtili_Click(object sender, EventArgs e)
        {
            lblOpcoes.Visible = false;
            pnMenu.Visible = false;
            pnCentro.Visible = false;
            pnTab.Visible = true;
            pnAministrativa.Visible = false;
            AbrirformularioTab<frmCaUtilizador>();
        }

        private void frmM_Load(object sender, EventArgs e)
        {
            CarregarLogin();
            if (UserLoginCache.Cargo == Cargo.Professor)
            {
                btnGAcade.Enabled = false;
                btnProfessor.Enabled = false;
                button10.Enabled = false;//presença
                btnOpco.Enabled = false;
            }
            if (UserLoginCache.Cargo == Cargo.D_Administrador)
            {
               
            }
            if (UserLoginCache.Cargo == Cargo.D_Pedagogico)
            {

            }
            if (UserLoginCache.Cargo == Cargo.Secretaria)
            {
                btnGAcade.Enabled = false;
                btnProfessor.Enabled = false;
                button10.Enabled = false;
                btnOpco.Enabled = false;
            }
            if (UserLoginCache.Cargo == Cargo.Secretaria_Admin)
            {

            }
            if (UserLoginCache.Cargo == Cargo.Secretaria_pedago)
            {

            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem a certeza que quer fazer logout?", "Warning",
           MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        private void btnSobre_Click(object sender, EventArgs e)
        {
            pnSider.Height = btnSobre.Height;
            pnSider.Top = btnSobre.Top;
            lblOpcoes.Visible = false;
            pnMenu.Visible = false;
            pnMenu.Visible = false;
            pnProfessor.Visible = false;
            pnAministrativa.Visible = false;


        }

     
        private void button1_Click_2(object sender, EventArgs e)
        {
            lblOpcoes.Visible = false;
            pnMenu.Visible = false;
            pnCentro.Visible = false;
            pnTab.Visible = true;
            AbrirformularioTab<frmCaSala>();
        }

        private void pnCima_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}

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
using GUE.Relatorio;

namespace GUE
{
    public partial class frmMenu : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hmd, int wmsg, int wparam, int lparam);
        public void AbrirFormCentro(object fornO)
        {
            if (pnCentro.Controls.Count > 0)
                this.pnCentro.Controls.RemoveAt(0);
            Form fr = fornO as Form;
            fr.TopLevel = false;
            fr.FormBorderStyle = FormBorderStyle.None;
            fr.Dock = DockStyle.Fill;
            this.pnCentro.Controls.Add(fr);
            this.pnCentro.Tag = fr;
            fr.Show();

        }
        private void mostrarlogoaofechar(object sender,FormClosedEventArgs e)
        {
            mostrarlogo();
        }
        private void mostrarlogo()
        {
            AbrirFormCentro(new frmDM());
        }
        public frmMenu()
        {
            InitializeComponent();
            OcultarPanel();
        }
        private void OcultarPanel()
        {
            pnAdministracao.Visible = false;
            pnProfessor.Visible = false;
            pnGestaoAcademica.Visible = false;
            ///**
        }
        private void hideSubMenu()
        {
            if (pnGestaoAcademica.Visible == true)
                pnGestaoAcademica.Visible = false;
            if (pnProfessor.Visible == true)
                pnProfessor.Visible = false;
            if (pnAdministracao.Visible == true)
                pnAdministracao.Visible = false;
        }

        private void showSubMenu(Panel SubMenu)
        {
            if (SubMenu.Visible == false)
            {
                hideSubMenu();
                SubMenu.Visible = true;
            }
            else
                SubMenu.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            showSubMenu(pnProfessor);
        }

        private void btnCoordenacao_Click(object sender, EventArgs e)
        {
            //..
            // you code
            frmCaCo frm = new frmCaCo();
            frm.FormClosed += new FormClosedEventHandler(mostrarlogoaofechar);
            AbrirFormCentro(frm);
            //..
            hideSubMenu();
        }

        private void btnDisciplina_Click(object sender, EventArgs e)
        {
            //..
            // you code
            frmCaDi frm = new frmCaDi();
            frm.FormClosed += new FormClosedEventHandler(mostrarlogoaofechar);
            AbrirFormCentro(frm);
            //..
            hideSubMenu();
        }

        private void btnTurma_Click(object sender, EventArgs e)
        {
            //..
            // you code
            frmCaTu frm = new frmCaTu();
            frm.FormClosed += new FormClosedEventHandler(mostrarlogoaofechar);
            AbrirFormCentro(frm);
            //..
            hideSubMenu();
        }

        private void btnCurso_Click(object sender, EventArgs e)
        {
            //..
            // you code
            frmCaCu frm = new frmCaCu();
            frm.FormClosed += new FormClosedEventHandler(mostrarlogoaofechar);
            AbrirFormCentro(frm);
            //..
            hideSubMenu();
        }

        private void btnSala_Click(object sender, EventArgs e)
        {
            //..
            // you code
            frmCaSala frm = new frmCaSala();
            frm.FormClosed += new FormClosedEventHandler(mostrarlogoaofechar);
            AbrirFormCentro(frm);
            //..
            hideSubMenu();
        }

        private void btnGestãoAcademica_Click(object sender, EventArgs e)
        {
            showSubMenu(pnGestaoAcademica);
        }

        private void btnProfessor_Click(object sender, EventArgs e)
        {
            //..
            // you code
            frmCaProfessor frm = new frmCaProfessor();
            frm.FormClosed += new FormClosedEventHandler(mostrarlogoaofechar);
            AbrirFormCentro(frm);
            //..
            hideSubMenu();
        }

        private void btnDiLecio_Click(object sender, EventArgs e)
        {
            //..
            // you code
            frmCaDL frm = new frmCaDL();
            frm.FormClosed += new FormClosedEventHandler(mostrarlogoaofechar);
            AbrirFormCentro(frm);
            //..
            hideSubMenu();
        }

        private void btnPresenca_Click(object sender, EventArgs e)
        {
            //..
            // you code
            frmCaPrens frm = new frmCaPrens();
            frm.FormClosed += new FormClosedEventHandler(mostrarlogoaofechar);
            AbrirFormCentro(frm);
            //..
            hideSubMenu();
        }

        private void btnHorario_Click(object sender, EventArgs e)
        {
            //..
            // you code
            frmHorario frm = new frmHorario();
            frm.FormClosed += new FormClosedEventHandler(mostrarlogoaofechar);
            AbrirFormCentro(frm);
            //..
            hideSubMenu();
        }

        private void btnTurmLecionadas_Click(object sender, EventArgs e)
        {
            //..
            // you code
            frmTL frm = new frmTL();
            frm.FormClosed += new FormClosedEventHandler(mostrarlogoaofechar);
            AbrirFormCentro(frm);
            //..
            hideSubMenu();
        }

        private void btnProva_Click(object sender, EventArgs e)
        {
            //..
            // you code
            frmCaPro frm = new frmCaPro();
            frm.FormClosed += new FormClosedEventHandler(mostrarlogoaofechar);
            AbrirFormCentro(frm);
            //..
            hideSubMenu();
        }

        private void btnGestaAdministrativa_Click(object sender, EventArgs e)
        {
            showSubMenu(pnAdministracao);
        }

        private void btnTipoUtilizador_Click(object sender, EventArgs e)
        {
            //..
            // you code
            frmTipoUtilizador frm = new frmTipoUtilizador();
            frm.FormClosed += new FormClosedEventHandler(mostrarlogoaofechar);
            AbrirFormCentro(frm);
            //..
            hideSubMenu();
        }

        private void btnAnoLe_Click(object sender, EventArgs e)
        {
            //..
            // you code
            frmCAnoLe frm = new frmCAnoLe();
            frm.FormClosed += new FormClosedEventHandler(mostrarlogoaofechar);
            AbrirFormCentro(frm);
            //..
            hideSubMenu();
        }

        private void btnMunicipio_Click(object sender, EventArgs e)
        {
            //..
            // you code
            frmCMunicip frm = new frmCMunicip();
            frm.FormClosed += new FormClosedEventHandler(mostrarlogoaofechar);
            AbrirFormCentro(frm);
            //..
            hideSubMenu();
        }

        private void btnUtilizador_Click(object sender, EventArgs e)
        {
            //..
            // you code
            frmCaUtilizador frm = new frmCaUtilizador();
            frm.FormClosed += new FormClosedEventHandler(mostrarlogoaofechar);
            AbrirFormCentro(frm);
            //..
            hideSubMenu();
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            //..
            // you code
            frmGeRelatorio frm = new frmGeRelatorio();
            frm.FormClosed += new FormClosedEventHandler(mostrarlogoaofechar);
            AbrirFormCentro(frm);
            //..
            hideSubMenu();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            //..
            // you code
            frmAjuda frm = new frmAjuda();
            frm.FormClosed += new FormClosedEventHandler(mostrarlogoaofechar);
            AbrirFormCentro(frm);
            //..
            hideSubMenu();
        }

        private void tmHora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
        }
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
                btnGestaAdministrativa.Enabled = false;
            }
            if (UserLoginCache.Cargo == 3)
            {
                lblCargo.Text = "D.Pedagógico";
                btnAnoLe.Enabled = false;
                btnBackup.Enabled = false;
                btnTipoUtilizador.Enabled = false;
                btnUtilizador.Enabled = false;
                btnMunicipio.Enabled = false;
            }
            if (UserLoginCache.Cargo == 4)
            {
                lblCargo.Text = "D.Administrativo";
                btnAnoLe.Enabled = false;
                btnBackup.Enabled = false;
                btnTipoUtilizador.Enabled = false;
                btnUtilizador.Enabled = false;
                btnMunicipio.Enabled = false;
            }
            if (UserLoginCache.Cargo == 5)
            {
                lblCargo.Text = "Professor";
                btnGestãoAcademica.Enabled = false;
                btnGestaAdministrativa.Enabled = false;
                btnProfessor.Enabled = false;
                btnPresenca.Enabled = false;
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
        private void frmMenu_Load(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            mostrarlogo();
            CarregarLogin();
            if (UserLoginCache.Cargo == Cargo.Professor)
            {
                //btnGAcade.Enabled = false;
                //btnProfessor.Enabled = false;
                //button10.Enabled = false;//presença
                //btnOpco.Enabled = false;
            }
            if (UserLoginCache.Cargo == Cargo.D_Administrador)
            {

            }
            if (UserLoginCache.Cargo == Cargo.D_Pedagogico)
            {

            }
            if (UserLoginCache.Cargo == Cargo.Secretaria)
            {
                //btnGAcade.Enabled = false;
                //btnProfessor.Enabled = false;
                //button10.Enabled = false;
                //btnOpco.Enabled = false;
            }
            if (UserLoginCache.Cargo == Cargo.Secretaria_Admin)
            {

            }
            if (UserLoginCache.Cargo == Cargo.Secretaria_pedago)
            {

            }
        }
        int LX, LY, SW, SH;

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.Size = new Size(SW, SH);
            this.Location = new Point(LX, LY);
            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;
        }

        private void pnCima_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem a certeza que quer fazer logout?", "Warning",
          MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            //..
            // you code
            frmBackupDados frm = new frmBackupDados();
            frm.FormClosed += new FormClosedEventHandler(mostrarlogoaofechar);
            AbrirFormCentro(frm);
            //..
            hideSubMenu();
        }

        private void btnmini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            LX = this.Location.X;
            LY = this.Location.Y;
            SW = this.Size.Width;
            SH = this.Size.Height;
          
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            btnRestaurar.Visible = true;
            btnMaximizar.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem a ceteza que quer encerrar o sistema", "Alerta", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {

            }
        }
    }
}

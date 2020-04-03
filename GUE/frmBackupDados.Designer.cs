namespace GUE
{
    partial class frmBackupDados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBackupDados));
            this.tabControlSala = new System.Windows.Forms.TabControl();
            this.tabRelaHorario = new System.Windows.Forms.TabPage();
            this.btnBackp = new System.Windows.Forms.Button();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEncerrar = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControlSala.SuspendLayout();
            this.tabRelaHorario.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEncerrar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlSala
            // 
            this.tabControlSala.Controls.Add(this.tabRelaHorario);
            this.tabControlSala.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlSala.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControlSala.Location = new System.Drawing.Point(17, 53);
            this.tabControlSala.Name = "tabControlSala";
            this.tabControlSala.SelectedIndex = 0;
            this.tabControlSala.Size = new System.Drawing.Size(777, 505);
            this.tabControlSala.TabIndex = 21;
            // 
            // tabRelaHorario
            // 
            this.tabRelaHorario.Controls.Add(this.groupBox1);
            this.tabRelaHorario.Location = new System.Drawing.Point(4, 26);
            this.tabRelaHorario.Name = "tabRelaHorario";
            this.tabRelaHorario.Padding = new System.Windows.Forms.Padding(3);
            this.tabRelaHorario.Size = new System.Drawing.Size(769, 475);
            this.tabRelaHorario.TabIndex = 2;
            this.tabRelaHorario.UseVisualStyleBackColor = true;
            // 
            // btnBackp
            // 
            this.btnBackp.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnBackp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackp.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackp.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBackp.Location = new System.Drawing.Point(59, 70);
            this.btnBackp.Name = "btnBackp";
            this.btnBackp.Size = new System.Drawing.Size(303, 64);
            this.btnBackp.TabIndex = 15;
            this.btnBackp.Text = "Backup dos dados";
            this.btnBackp.UseVisualStyleBackColor = false;
            this.btnBackp.Click += new System.EventHandler(this.btnBackp_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestaurar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestaurar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRestaurar.Location = new System.Drawing.Point(59, 208);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(303, 64);
            this.btnRestaurar.TabIndex = 4;
            this.btnRestaurar.Text = "Restaurar dados";
            this.btnRestaurar.UseVisualStyleBackColor = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(10, 564);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(790, 10);
            this.panel3.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(800, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 521);
            this.panel2.TabIndex = 19;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 53);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 521);
            this.panel5.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.btnEncerrar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(810, 53);
            this.panel1.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Backup dos dados do sistema";
            // 
            // btnEncerrar
            // 
            this.btnEncerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEncerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEncerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnEncerrar.Image")));
            this.btnEncerrar.Location = new System.Drawing.Point(770, 15);
            this.btnEncerrar.Name = "btnEncerrar";
            this.btnEncerrar.Size = new System.Drawing.Size(17, 15);
            this.btnEncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEncerrar.TabIndex = 3;
            this.btnEncerrar.TabStop = false;
            this.btnEncerrar.Click += new System.EventHandler(this.btnEncerrar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRestaurar);
            this.groupBox1.Controls.Add(this.btnBackp);
            this.groupBox1.Location = new System.Drawing.Point(143, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(430, 340);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opções de backup";
            // 
            // frmBackupDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 574);
            this.Controls.Add(this.tabControlSala);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBackupDados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBackupDados";
            this.tabControlSala.ResumeLayout(false);
            this.tabRelaHorario.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEncerrar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TabControl tabControlSala;
        private System.Windows.Forms.TabPage tabRelaHorario;
        private System.Windows.Forms.Button btnBackp;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnEncerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
namespace GUE.Relatorio
{
    partial class frmGeRelatorio
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGeRelatorio));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.t_professorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.impalsgpDataSetProfessor1 = new GUE.Relatorio.impalsgpDataSetProfessor1();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEncerrar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabControlSala = new System.Windows.Forms.TabControl();
            this.tabGerarRelatorio = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTl = new System.Windows.Forms.Button();
            this.btnDl = new System.Windows.Forms.Button();
            this.btnGeralProfessor = new System.Windows.Forms.Button();
            this.btnProva = new System.Windows.Forms.Button();
            this.btnPresencaPro = new System.Windows.Forms.Button();
            this.btnNHorario = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.tabRelaProfessor = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnHome = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnGerar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProfessor = new System.Windows.Forms.TextBox();
            this.t_professorTableAdapter = new GUE.Relatorio.impalsgpDataSetProfessor1TableAdapters.t_professorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.t_professorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.impalsgpDataSetProfessor1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEncerrar)).BeginInit();
            this.tabControlSala.SuspendLayout();
            this.tabGerarRelatorio.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabRelaProfessor.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // t_professorBindingSource
            // 
            this.t_professorBindingSource.DataMember = "t_professor";
            this.t_professorBindingSource.DataSource = this.impalsgpDataSetProfessor1;
            // 
            // impalsgpDataSetProfessor1
            // 
            this.impalsgpDataSetProfessor1.DataSetName = "impalsgpDataSetProfessor1";
            this.impalsgpDataSetProfessor1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.panel1.TabIndex = 2;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gerar Relatórios";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 53);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 521);
            this.panel5.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(800, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 521);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(10, 564);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(790, 10);
            this.panel3.TabIndex = 5;
            // 
            // tabControlSala
            // 
            this.tabControlSala.Controls.Add(this.tabGerarRelatorio);
            this.tabControlSala.Controls.Add(this.tabRelaProfessor);
            this.tabControlSala.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlSala.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControlSala.Location = new System.Drawing.Point(17, 53);
            this.tabControlSala.Name = "tabControlSala";
            this.tabControlSala.SelectedIndex = 0;
            this.tabControlSala.Size = new System.Drawing.Size(777, 505);
            this.tabControlSala.TabIndex = 6;
            // 
            // tabGerarRelatorio
            // 
            this.tabGerarRelatorio.BackColor = System.Drawing.Color.Transparent;
            this.tabGerarRelatorio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabGerarRelatorio.Controls.Add(this.groupBox2);
            this.tabGerarRelatorio.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabGerarRelatorio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabGerarRelatorio.Location = new System.Drawing.Point(4, 26);
            this.tabGerarRelatorio.Name = "tabGerarRelatorio";
            this.tabGerarRelatorio.Padding = new System.Windows.Forms.Padding(3);
            this.tabGerarRelatorio.Size = new System.Drawing.Size(769, 475);
            this.tabGerarRelatorio.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTl);
            this.groupBox2.Controls.Add(this.btnDl);
            this.groupBox2.Controls.Add(this.btnGeralProfessor);
            this.groupBox2.Controls.Add(this.btnProva);
            this.groupBox2.Controls.Add(this.btnPresencaPro);
            this.groupBox2.Controls.Add(this.btnNHorario);
            this.groupBox2.Controls.Add(this.btnNovo);
            this.groupBox2.Location = new System.Drawing.Point(262, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(267, 351);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opção de realatórios";
            // 
            // btnTl
            // 
            this.btnTl.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnTl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTl.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTl.Location = new System.Drawing.Point(46, 252);
            this.btnTl.Name = "btnTl";
            this.btnTl.Size = new System.Drawing.Size(175, 36);
            this.btnTl.TabIndex = 16;
            this.btnTl.Text = "Turmas leccionadas";
            this.btnTl.UseVisualStyleBackColor = false;
            this.btnTl.Click += new System.EventHandler(this.btnTl_Click);
            // 
            // btnDl
            // 
            this.btnDl.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnDl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDl.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDl.Location = new System.Drawing.Point(46, 161);
            this.btnDl.Name = "btnDl";
            this.btnDl.Size = new System.Drawing.Size(175, 36);
            this.btnDl.TabIndex = 15;
            this.btnDl.Text = "Disciplina leccionadas ";
            this.btnDl.UseVisualStyleBackColor = false;
            this.btnDl.Click += new System.EventHandler(this.btnDl_Click);
            // 
            // btnGeralProfessor
            // 
            this.btnGeralProfessor.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnGeralProfessor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeralProfessor.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGeralProfessor.Location = new System.Drawing.Point(46, 77);
            this.btnGeralProfessor.Name = "btnGeralProfessor";
            this.btnGeralProfessor.Size = new System.Drawing.Size(175, 36);
            this.btnGeralProfessor.TabIndex = 14;
            this.btnGeralProfessor.Text = "Todos os professores";
            this.btnGeralProfessor.UseVisualStyleBackColor = false;
            this.btnGeralProfessor.Click += new System.EventHandler(this.btnGeralProfessor_Click);
            // 
            // btnProva
            // 
            this.btnProva.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnProva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProva.ForeColor = System.Drawing.SystemColors.Control;
            this.btnProva.Location = new System.Drawing.Point(84, 26);
            this.btnProva.Name = "btnProva";
            this.btnProva.Size = new System.Drawing.Size(98, 36);
            this.btnProva.TabIndex = 4;
            this.btnProva.Text = "Prova";
            this.btnProva.UseVisualStyleBackColor = false;
            this.btnProva.Click += new System.EventHandler(this.btnPresenca_Click);
            // 
            // btnPresencaPro
            // 
            this.btnPresencaPro.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnPresencaPro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPresencaPro.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPresencaPro.Location = new System.Drawing.Point(84, 210);
            this.btnPresencaPro.Name = "btnPresencaPro";
            this.btnPresencaPro.Size = new System.Drawing.Size(98, 36);
            this.btnPresencaPro.TabIndex = 3;
            this.btnPresencaPro.Text = "Presença";
            this.btnPresencaPro.UseVisualStyleBackColor = false;
            this.btnPresencaPro.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnNHorario
            // 
            this.btnNHorario.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnNHorario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNHorario.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNHorario.Location = new System.Drawing.Point(84, 294);
            this.btnNHorario.Name = "btnNHorario";
            this.btnNHorario.Size = new System.Drawing.Size(98, 36);
            this.btnNHorario.TabIndex = 2;
            this.btnNHorario.Text = "Horário";
            this.btnNHorario.UseVisualStyleBackColor = false;
            this.btnNHorario.Click += new System.EventHandler(this.btnNo_Click_1);
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNovo.Location = new System.Drawing.Point(84, 119);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(98, 36);
            this.btnNovo.TabIndex = 1;
            this.btnNovo.Text = "Professor";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click_1);
            // 
            // tabRelaProfessor
            // 
            this.tabRelaProfessor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabRelaProfessor.Controls.Add(this.reportViewer1);
            this.tabRelaProfessor.Controls.Add(this.btnHome);
            this.tabRelaProfessor.Controls.Add(this.groupBox3);
            this.tabRelaProfessor.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabRelaProfessor.Location = new System.Drawing.Point(4, 26);
            this.tabRelaProfessor.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.tabRelaProfessor.Name = "tabRelaProfessor";
            this.tabRelaProfessor.Padding = new System.Windows.Forms.Padding(3);
            this.tabRelaProfessor.Size = new System.Drawing.Size(769, 475);
            this.tabRelaProfessor.TabIndex = 1;
            this.tabRelaProfessor.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.t_professorBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUE.Relatorio.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(6, 110);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(740, 346);
            this.reportViewer1.TabIndex = 15;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.ForeColor = System.Drawing.SystemColors.Control;
            this.btnHome.Location = new System.Drawing.Point(586, 31);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(104, 36);
            this.btnHome.TabIndex = 14;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnGerar);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtProfessor);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(430, 82);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informáções do professor";
            // 
            // btnGerar
            // 
            this.btnGerar.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnGerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGerar.Location = new System.Drawing.Point(319, 29);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(99, 29);
            this.btnGerar.TabIndex = 4;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = false;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Professor:";
            // 
            // txtProfessor
            // 
            this.txtProfessor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProfessor.Location = new System.Drawing.Point(20, 49);
            this.txtProfessor.Name = "txtProfessor";
            this.txtProfessor.Size = new System.Drawing.Size(216, 23);
            this.txtProfessor.TabIndex = 0;
            // 
            // t_professorTableAdapter
            // 
            this.t_professorTableAdapter.ClearBeforeFill = true;
            // 
            // frmGeRelatorio
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
            this.Name = "frmGeRelatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGeRelatorio";
            this.Load += new System.EventHandler(this.frmGeRelatorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.t_professorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.impalsgpDataSetProfessor1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEncerrar)).EndInit();
            this.tabControlSala.ResumeLayout(false);
            this.tabGerarRelatorio.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tabRelaProfessor.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnEncerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.TabControl tabControlSala;
        public System.Windows.Forms.TabPage tabGerarRelatorio;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnNHorario;
        private System.Windows.Forms.Button btnNovo;
        public System.Windows.Forms.TabPage tabRelaProfessor;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProfessor;
        private System.Windows.Forms.Button btnPresencaPro;
        private System.Windows.Forms.Button btnProva;
        //private impalsgpDataSet impalsgpDataSet;
        //private impalsgpDataSetTableAdapters.t_professorTableAdapter t_professorTableAdapter;
        private System.Windows.Forms.Button btnHome;
       // private impalsgpDataSetTableAdapters.DataTableHorarioTableAdapter DataTableHorarioTableAdapter;
        private System.Windows.Forms.Button btnGeralProfessor;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource t_professorBindingSource;
        private impalsgpDataSetProfessor1 impalsgpDataSetProfessor1;
        private impalsgpDataSetProfessor1TableAdapters.t_professorTableAdapter t_professorTableAdapter;
        private System.Windows.Forms.Button btnTl;
        private System.Windows.Forms.Button btnDl;
    }
}
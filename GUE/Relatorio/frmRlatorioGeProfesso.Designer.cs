namespace GUE.Relatorio
{
    partial class frmRlatorioGeProfesso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRlatorioGeProfesso));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.t_professorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEncerrar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabGerarRelatorio = new System.Windows.Forms.TabPage();
            this.tabControlSala = new System.Windows.Forms.TabControl();
            this.DataTable1GProfessorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GprofessimpalsgpDataSet = new GUE.Relatorio.GprofessimpalsgpDataSet();
            this.DataTable1GProfessorTableAdapter = new GUE.Relatorio.GprofessimpalsgpDataSetTableAdapters.DataTable1GProfessorTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.t_professorBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEncerrar)).BeginInit();
            this.tabGerarRelatorio.SuspendLayout();
            this.tabControlSala.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1GProfessorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GprofessimpalsgpDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // t_professorBindingSource
            // 
            this.t_professorBindingSource.DataMember = "t_professor";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(10, 564);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(790, 10);
            this.panel3.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(800, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 521);
            this.panel2.TabIndex = 9;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 53);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 521);
            this.panel5.TabIndex = 8;
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
            this.panel1.TabIndex = 7;
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
            this.label1.Size = new System.Drawing.Size(272, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Relatório geral dos professores";
            // 
            // tabGerarRelatorio
            // 
            this.tabGerarRelatorio.BackColor = System.Drawing.Color.Transparent;
            this.tabGerarRelatorio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabGerarRelatorio.Controls.Add(this.reportViewer1);
            this.tabGerarRelatorio.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabGerarRelatorio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabGerarRelatorio.Location = new System.Drawing.Point(4, 26);
            this.tabGerarRelatorio.Name = "tabGerarRelatorio";
            this.tabGerarRelatorio.Padding = new System.Windows.Forms.Padding(3);
            this.tabGerarRelatorio.Size = new System.Drawing.Size(769, 475);
            this.tabGerarRelatorio.TabIndex = 0;
            // 
            // tabControlSala
            // 
            this.tabControlSala.Controls.Add(this.tabGerarRelatorio);
            this.tabControlSala.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlSala.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControlSala.Location = new System.Drawing.Point(17, 53);
            this.tabControlSala.Name = "tabControlSala";
            this.tabControlSala.SelectedIndex = 0;
            this.tabControlSala.Size = new System.Drawing.Size(777, 505);
            this.tabControlSala.TabIndex = 11;
            // 
            // DataTable1GProfessorBindingSource
            // 
            this.DataTable1GProfessorBindingSource.DataMember = "DataTable1GProfessor";
            this.DataTable1GProfessorBindingSource.DataSource = this.GprofessimpalsgpDataSet;
            // 
            // GprofessimpalsgpDataSet
            // 
            this.GprofessimpalsgpDataSet.DataSetName = "GprofessimpalsgpDataSet";
            this.GprofessimpalsgpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataTable1GProfessorTableAdapter
            // 
            this.DataTable1GProfessorTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1GeraProfessor";
            reportDataSource1.Value = this.DataTable1GProfessorBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUE.Relatorio.rpGprofessor12.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(761, 467);
            this.reportViewer1.TabIndex = 0;
            // 
            // frmRlatorioGeProfesso
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
            this.Name = "frmRlatorioGeProfesso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRlatorioGeProfesso";
            this.Load += new System.EventHandler(this.frmRlatorioGeProfesso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.t_professorBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEncerrar)).EndInit();
            this.tabGerarRelatorio.ResumeLayout(false);
            this.tabControlSala.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1GProfessorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GprofessimpalsgpDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnEncerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource t_professorBindingSource;
        private System.Windows.Forms.BindingSource DataTable1GProfessorBindingSource;
        private GprofessimpalsgpDataSet GprofessimpalsgpDataSet;
        private GprofessimpalsgpDataSetTableAdapters.DataTable1GProfessorTableAdapter DataTable1GProfessorTableAdapter;
        public System.Windows.Forms.TabPage tabGerarRelatorio;
        public System.Windows.Forms.TabControl tabControlSala;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        //private impalsgpDataSet impalsgpDataSet;
        // private impalsgpDataSetTableAdapters.t_professorTableAdapter t_professorTableAdapter;
    }
}
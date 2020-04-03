namespace GUE
{
    partial class frmCaCo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCaCo));
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEncerrar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControlSala = new System.Windows.Forms.TabControl();
            this.tabSConsu = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnNo = new System.Windows.Forms.Button();
            this.btnLocalizar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.dvgDados = new System.Windows.Forms.DataGridView();
            this.tabSCad = new System.Windows.Forms.TabPage();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbAno = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbCoord = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCoordenacao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEncerrar)).BeginInit();
            this.tabControlSala.SuspendLayout();
            this.tabSConsu.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDados)).BeginInit();
            this.tabSCad.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 53);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 511);
            this.panel5.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 564);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 10);
            this.panel3.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.btnEncerrar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 53);
            this.panel1.TabIndex = 11;
            // 
            // btnEncerrar
            // 
            this.btnEncerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEncerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEncerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnEncerrar.Image")));
            this.btnEncerrar.Location = new System.Drawing.Point(760, 15);
            this.btnEncerrar.Name = "btnEncerrar";
            this.btnEncerrar.Size = new System.Drawing.Size(20, 24);
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
            this.label1.Size = new System.Drawing.Size(125, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Coordenação";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(800, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 574);
            this.panel2.TabIndex = 7;
            // 
            // tabControlSala
            // 
            this.tabControlSala.Controls.Add(this.tabSConsu);
            this.tabControlSala.Controls.Add(this.tabSCad);
            this.tabControlSala.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlSala.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControlSala.Location = new System.Drawing.Point(16, 59);
            this.tabControlSala.Name = "tabControlSala";
            this.tabControlSala.SelectedIndex = 0;
            this.tabControlSala.Size = new System.Drawing.Size(778, 499);
            this.tabControlSala.TabIndex = 8;
            // 
            // tabSConsu
            // 
            this.tabSConsu.BackColor = System.Drawing.Color.Transparent;
            this.tabSConsu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabSConsu.Controls.Add(this.groupBox2);
            this.tabSConsu.Controls.Add(this.groupBox1);
            this.tabSConsu.Controls.Add(this.dvgDados);
            this.tabSConsu.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabSConsu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabSConsu.Location = new System.Drawing.Point(4, 26);
            this.tabSConsu.Name = "tabSConsu";
            this.tabSConsu.Padding = new System.Windows.Forms.Padding(3);
            this.tabSConsu.Size = new System.Drawing.Size(770, 469);
            this.tabSConsu.TabIndex = 0;
            this.tabSConsu.Click += new System.EventHandler(this.tabSConsu_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnNo);
            this.groupBox2.Controls.Add(this.btnLocalizar);
            this.groupBox2.Location = new System.Drawing.Point(479, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(230, 114);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opção";
            // 
            // btnNo
            // 
            this.btnNo.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNo.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNo.Location = new System.Drawing.Point(51, 69);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(120, 36);
            this.btnNo.TabIndex = 2;
            this.btnNo.Text = "Novo";
            this.btnNo.UseVisualStyleBackColor = false;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnLocalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocalizar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLocalizar.Location = new System.Drawing.Point(51, 19);
            this.btnLocalizar.Name = "btnLocalizar";
            this.btnLocalizar.Size = new System.Drawing.Size(120, 36);
            this.btnLocalizar.TabIndex = 1;
            this.btnLocalizar.Text = "Localizar";
            this.btnLocalizar.UseVisualStyleBackColor = false;
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPesquisar);
            this.groupBox1.Location = new System.Drawing.Point(32, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 93);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(20, 44);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(313, 27);
            this.txtPesquisar.TabIndex = 0;
            this.txtPesquisar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPesquisar_KeyUp);
            // 
            // dvgDados
            // 
            this.dvgDados.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvgDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgDados.GridColor = System.Drawing.SystemColors.Control;
            this.dvgDados.Location = new System.Drawing.Point(14, 150);
            this.dvgDados.Name = "dvgDados";
            this.dvgDados.Size = new System.Drawing.Size(727, 295);
            this.dvgDados.TabIndex = 0;
            this.dvgDados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgDados_CellDoubleClick);
            // 
            // tabSCad
            // 
            this.tabSCad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabSCad.Controls.Add(this.btnCancelar);
            this.tabSCad.Controls.Add(this.btnExcluir);
            this.tabSCad.Controls.Add(this.btnGuardar);
            this.tabSCad.Controls.Add(this.groupBox3);
            this.tabSCad.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabSCad.Location = new System.Drawing.Point(4, 26);
            this.tabSCad.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.tabSCad.Name = "tabSCad";
            this.tabSCad.Padding = new System.Windows.Forms.Padding(3);
            this.tabSCad.Size = new System.Drawing.Size(770, 469);
            this.tabSCad.TabIndex = 1;
            this.tabSCad.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.Location = new System.Drawing.Point(301, 368);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(130, 36);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.ForeColor = System.Drawing.SystemColors.Control;
            this.btnExcluir.Location = new System.Drawing.Point(108, 368);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(122, 36);
            this.btnExcluir.TabIndex = 5;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGuardar.Location = new System.Drawing.Point(507, 368);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(129, 36);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbAno);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.cmbCoord);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtCoordenacao);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtId);
            this.groupBox3.Location = new System.Drawing.Point(159, 46);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(430, 287);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informáções da coordenação";
            // 
            // cmbAno
            // 
            this.cmbAno.FormattingEnabled = true;
            this.cmbAno.Location = new System.Drawing.Point(161, 216);
            this.cmbAno.Name = "cmbAno";
            this.cmbAno.Size = new System.Drawing.Size(205, 28);
            this.cmbAno.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Ano letivo:";
            // 
            // cmbCoord
            // 
            this.cmbCoord.FormattingEnabled = true;
            this.cmbCoord.Location = new System.Drawing.Point(161, 166);
            this.cmbCoord.Name = "cmbCoord";
            this.cmbCoord.Size = new System.Drawing.Size(205, 28);
            this.cmbCoord.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Coordenador:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Coordenção:";
            // 
            // txtCoordenacao
            // 
            this.txtCoordenacao.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCoordenacao.Location = new System.Drawing.Point(161, 114);
            this.txtCoordenacao.Name = "txtCoordenacao";
            this.txtCoordenacao.Size = new System.Drawing.Size(205, 27);
            this.txtCoordenacao.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código:";
            this.label2.Visible = false;
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(237, 43);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(45, 23);
            this.txtId.TabIndex = 23;
            this.txtId.Visible = false;
            // 
            // frmCaCo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 574);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tabControlSala);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCaCo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCaCo";
            this.Load += new System.EventHandler(this.frmCaCo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEncerrar)).EndInit();
            this.tabControlSala.ResumeLayout(false);
            this.tabSConsu.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDados)).EndInit();
            this.tabSCad.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnEncerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.TabControl tabControlSala;
        public System.Windows.Forms.TabPage tabSConsu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Button btnLocalizar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.DataGridView dvgDados;
        public System.Windows.Forms.TabPage tabSCad;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCoordenacao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.ComboBox cmbAno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbCoord;
    }
}
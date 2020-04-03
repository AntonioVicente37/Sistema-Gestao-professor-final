namespace GUE
{
    partial class frmCaPrens
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCaPrens));
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
            this.lblFoto = new System.Windows.Forms.Label();
            this.pnFoto = new System.Windows.Forms.Panel();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.lblProfessor = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.txtProfessor = new System.Windows.Forms.TextBox();
            this.txtAgente = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.mkbfinal = new System.Windows.Forms.MaskedTextBox();
            this.lblEntrada = new System.Windows.Forms.Label();
            this.mkbinicial = new System.Windows.Forms.MaskedTextBox();
            this.ckdPresenca = new System.Windows.Forms.CheckBox();
            this.dtpda = new System.Windows.Forms.DateTimePicker();
            this.cmbAgente = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblAgente = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEncerrar)).BeginInit();
            this.tabControlSala.SuspendLayout();
            this.tabSConsu.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDados)).BeginInit();
            this.tabSCad.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.pnFoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 53);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 511);
            this.panel5.TabIndex = 29;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 564);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 10);
            this.panel3.TabIndex = 30;
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
            this.panel1.TabIndex = 31;
            // 
            // btnEncerrar
            // 
            this.btnEncerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEncerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEncerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnEncerrar.Image")));
            this.btnEncerrar.Location = new System.Drawing.Point(763, 14);
            this.btnEncerrar.Name = "btnEncerrar";
            this.btnEncerrar.Size = new System.Drawing.Size(21, 25);
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
            this.label1.Size = new System.Drawing.Size(207, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marcação de presença ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(800, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 574);
            this.panel2.TabIndex = 27;
            // 
            // tabControlSala
            // 
            this.tabControlSala.Controls.Add(this.tabSConsu);
            this.tabControlSala.Controls.Add(this.tabSCad);
            this.tabControlSala.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlSala.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControlSala.Location = new System.Drawing.Point(12, 58);
            this.tabControlSala.Name = "tabControlSala";
            this.tabControlSala.SelectedIndex = 0;
            this.tabControlSala.Size = new System.Drawing.Size(782, 500);
            this.tabControlSala.TabIndex = 28;
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
            this.tabSConsu.Size = new System.Drawing.Size(774, 470);
            this.tabSConsu.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnNo);
            this.groupBox2.Controls.Add(this.btnLocalizar);
            this.groupBox2.Location = new System.Drawing.Point(544, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(198, 115);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opção";
            // 
            // btnNo
            // 
            this.btnNo.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNo.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNo.Location = new System.Drawing.Point(53, 71);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(102, 36);
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
            this.btnLocalizar.Location = new System.Drawing.Point(53, 26);
            this.btnLocalizar.Name = "btnLocalizar";
            this.btnLocalizar.Size = new System.Drawing.Size(102, 36);
            this.btnLocalizar.TabIndex = 1;
            this.btnLocalizar.Text = "Localizar";
            this.btnLocalizar.UseVisualStyleBackColor = false;
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPesquisar);
            this.groupBox1.Location = new System.Drawing.Point(30, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 94);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(20, 44);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(328, 27);
            this.txtPesquisar.TabIndex = 0;
            this.txtPesquisar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPesquisar_KeyUp);
            // 
            // dvgDados
            // 
            this.dvgDados.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvgDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgDados.GridColor = System.Drawing.SystemColors.Control;
            this.dvgDados.Location = new System.Drawing.Point(21, 159);
            this.dvgDados.Name = "dvgDados";
            this.dvgDados.Size = new System.Drawing.Size(721, 286);
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
            this.tabSCad.Size = new System.Drawing.Size(774, 470);
            this.tabSCad.TabIndex = 1;
            this.tabSCad.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.Location = new System.Drawing.Point(295, 366);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(136, 36);
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
            this.btnExcluir.Location = new System.Drawing.Point(102, 366);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(128, 36);
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
            this.btnGuardar.Location = new System.Drawing.Point(501, 366);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(135, 36);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblFoto);
            this.groupBox3.Controls.Add(this.pnFoto);
            this.groupBox3.Controls.Add(this.lblProfessor);
            this.groupBox3.Controls.Add(this.lblData);
            this.groupBox3.Controls.Add(this.txtProfessor);
            this.groupBox3.Controls.Add(this.txtAgente);
            this.groupBox3.Controls.Add(this.lblNome);
            this.groupBox3.Controls.Add(this.mkbfinal);
            this.groupBox3.Controls.Add(this.lblEntrada);
            this.groupBox3.Controls.Add(this.mkbinicial);
            this.groupBox3.Controls.Add(this.ckdPresenca);
            this.groupBox3.Controls.Add(this.dtpda);
            this.groupBox3.Controls.Add(this.cmbAgente);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.lblAgente);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtId);
            this.groupBox3.Location = new System.Drawing.Point(6, 48);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(727, 292);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informáções da presença";
            // 
            // lblFoto
            // 
            this.lblFoto.AutoSize = true;
            this.lblFoto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoto.Location = new System.Drawing.Point(521, 48);
            this.lblFoto.Name = "lblFoto";
            this.lblFoto.Size = new System.Drawing.Size(41, 20);
            this.lblFoto.TabIndex = 58;
            this.lblFoto.Text = "Foto";
            // 
            // pnFoto
            // 
            this.pnFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnFoto.Controls.Add(this.pbFoto);
            this.pnFoto.Location = new System.Drawing.Point(523, 71);
            this.pnFoto.Name = "pnFoto";
            this.pnFoto.Size = new System.Drawing.Size(188, 196);
            this.pnFoto.TabIndex = 57;
            // 
            // pbFoto
            // 
            this.pbFoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbFoto.Location = new System.Drawing.Point(0, 0);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(186, 194);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 0;
            this.pbFoto.TabStop = false;
            // 
            // lblProfessor
            // 
            this.lblProfessor.AutoSize = true;
            this.lblProfessor.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfessor.Location = new System.Drawing.Point(317, 108);
            this.lblProfessor.Name = "lblProfessor";
            this.lblProfessor.Size = new System.Drawing.Size(75, 20);
            this.lblProfessor.TabIndex = 56;
            this.lblProfessor.Text = "Professor";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(9, 208);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(49, 20);
            this.lblData.TabIndex = 55;
            this.lblData.Text = "Data ";
            // 
            // txtProfessor
            // 
            this.txtProfessor.Location = new System.Drawing.Point(321, 131);
            this.txtProfessor.Name = "txtProfessor";
            this.txtProfessor.Size = new System.Drawing.Size(146, 27);
            this.txtProfessor.TabIndex = 54;
            // 
            // txtAgente
            // 
            this.txtAgente.Location = new System.Drawing.Point(10, 128);
            this.txtAgente.Name = "txtAgente";
            this.txtAgente.Size = new System.Drawing.Size(146, 27);
            this.txtAgente.TabIndex = 53;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(308, 238);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(111, 20);
            this.lblNome.TabIndex = 52;
            this.lblNome.Text = "Hora de saida";
            // 
            // mkbfinal
            // 
            this.mkbfinal.Location = new System.Drawing.Point(312, 261);
            this.mkbfinal.Mask = "00:00";
            this.mkbfinal.Name = "mkbfinal";
            this.mkbfinal.Size = new System.Drawing.Size(49, 27);
            this.mkbfinal.TabIndex = 51;
            // 
            // lblEntrada
            // 
            this.lblEntrada.AutoSize = true;
            this.lblEntrada.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntrada.Location = new System.Drawing.Point(6, 155);
            this.lblEntrada.Name = "lblEntrada";
            this.lblEntrada.Size = new System.Drawing.Size(131, 20);
            this.lblEntrada.TabIndex = 50;
            this.lblEntrada.Text = "Hora de entrada";
            // 
            // mkbinicial
            // 
            this.mkbinicial.Location = new System.Drawing.Point(10, 178);
            this.mkbinicial.Mask = "00:00";
            this.mkbinicial.Name = "mkbinicial";
            this.mkbinicial.Size = new System.Drawing.Size(51, 27);
            this.mkbinicial.TabIndex = 49;
            // 
            // ckdPresenca
            // 
            this.ckdPresenca.AutoSize = true;
            this.ckdPresenca.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckdPresenca.Location = new System.Drawing.Point(321, 187);
            this.ckdPresenca.Name = "ckdPresenca";
            this.ckdPresenca.Size = new System.Drawing.Size(78, 21);
            this.ckdPresenca.TabIndex = 48;
            this.ckdPresenca.Text = "Ausente";
            this.ckdPresenca.UseVisualStyleBackColor = true;
            this.ckdPresenca.CheckedChanged += new System.EventHandler(this.ckdPresenca_CheckedChanged);
            // 
            // dtpda
            // 
            this.dtpda.Location = new System.Drawing.Point(10, 231);
            this.dtpda.Name = "dtpda";
            this.dtpda.Size = new System.Drawing.Size(200, 27);
            this.dtpda.TabIndex = 47;
            // 
            // cmbAgente
            // 
            this.cmbAgente.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAgente.FormattingEnabled = true;
            this.cmbAgente.Location = new System.Drawing.Point(274, 49);
            this.cmbAgente.Name = "cmbAgente";
            this.cmbAgente.Size = new System.Drawing.Size(164, 23);
            this.cmbAgente.TabIndex = 45;
            this.cmbAgente.SelectedIndexChanged += new System.EventHandler(this.cmbAgente_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(270, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 20);
            this.label8.TabIndex = 46;
            this.label8.Text = "Professor";
            // 
            // lblAgente
            // 
            this.lblAgente.AutoSize = true;
            this.lblAgente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgente.Location = new System.Drawing.Point(6, 105);
            this.lblAgente.Name = "lblAgente";
            this.lblAgente.Size = new System.Drawing.Size(150, 20);
            this.lblAgente.TabIndex = 44;
            this.lblAgente.Text = "Numero de Agente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código:";
            this.label2.Visible = false;
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(92, 26);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(45, 23);
            this.txtId.TabIndex = 23;
            this.txtId.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmCaPrens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 574);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.tabControlSala);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCaPrens";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCaPrens";
            this.Load += new System.EventHandler(this.frmCaPrens_Load);
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
            this.pnFoto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.TextBox txtProfessor;
        private System.Windows.Forms.TextBox txtAgente;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.MaskedTextBox mkbfinal;
        private System.Windows.Forms.Label lblEntrada;
        private System.Windows.Forms.MaskedTextBox mkbinicial;
        private System.Windows.Forms.CheckBox ckdPresenca;
        private System.Windows.Forms.DateTimePicker dtpda;
        private System.Windows.Forms.ComboBox cmbAgente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblAgente;
        private System.Windows.Forms.Label lblProfessor;
        private System.Windows.Forms.Label lblFoto;
        private System.Windows.Forms.Panel pnFoto;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.Timer timer1;
    }
}
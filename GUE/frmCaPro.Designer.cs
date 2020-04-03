namespace GUE
{
    partial class frmCaPro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCaPro));
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
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
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPeriodo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dtkprova = new System.Windows.Forms.DateTimePicker();
            this.cmbCoordenacao = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTipoProva = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.mkbfinal = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.mkbinicial = new System.Windows.Forms.MaskedTextBox();
            this.cmbSala = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbDisciplina = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbTurma = new System.Windows.Forms.ComboBox();
            this.cmbprofessor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEncerrar = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControlSala.SuspendLayout();
            this.tabSConsu.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDados)).BeginInit();
            this.tabSCad.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEncerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "Disciplina lecionadas pelo professor";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 564);
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
            this.tabControlSala.Location = new System.Drawing.Point(16, 59);
            this.tabControlSala.Name = "tabControlSala";
            this.tabControlSala.SelectedIndex = 0;
            this.tabControlSala.Size = new System.Drawing.Size(778, 499);
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
            this.tabSConsu.Size = new System.Drawing.Size(770, 469);
            this.tabSConsu.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnNo);
            this.groupBox2.Controls.Add(this.btnLocalizar);
            this.groupBox2.Location = new System.Drawing.Point(561, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(190, 118);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opção";
            // 
            // btnNo
            // 
            this.btnNo.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNo.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNo.Location = new System.Drawing.Point(35, 71);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(116, 36);
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
            this.btnLocalizar.Location = new System.Drawing.Point(35, 26);
            this.btnLocalizar.Name = "btnLocalizar";
            this.btnLocalizar.Size = new System.Drawing.Size(116, 36);
            this.btnLocalizar.TabIndex = 1;
            this.btnLocalizar.Text = "Localizar";
            this.btnLocalizar.UseVisualStyleBackColor = false;
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPesquisar);
            this.groupBox1.Location = new System.Drawing.Point(22, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(433, 90);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(20, 41);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(349, 27);
            this.txtPesquisar.TabIndex = 0;
            this.txtPesquisar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPesquisar_KeyUp);
            // 
            // dvgDados
            // 
            this.dvgDados.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvgDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgDados.GridColor = System.Drawing.SystemColors.Control;
            this.dvgDados.Location = new System.Drawing.Point(22, 158);
            this.dvgDados.Name = "dvgDados";
            this.dvgDados.Size = new System.Drawing.Size(713, 292);
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
            this.btnCancelar.Location = new System.Drawing.Point(312, 379);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(140, 36);
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
            this.btnExcluir.Location = new System.Drawing.Point(119, 379);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(132, 36);
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
            this.btnGuardar.Location = new System.Drawing.Point(518, 379);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(139, 36);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtPeriodo);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.dtkprova);
            this.groupBox3.Controls.Add(this.cmbCoordenacao);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txtTipoProva);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.mkbfinal);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.mkbinicial);
            this.groupBox3.Controls.Add(this.cmbSala);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.cmbDisciplina);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.cmbTurma);
            this.groupBox3.Controls.Add(this.cmbprofessor);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtId);
            this.groupBox3.Location = new System.Drawing.Point(18, 43);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(729, 314);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informáções da prova";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 66;
            this.label4.Text = "Professor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 65;
            this.label6.Text = "Turma";
            // 
            // txtPeriodo
            // 
            this.txtPeriodo.Location = new System.Drawing.Point(496, 179);
            this.txtPeriodo.Name = "txtPeriodo";
            this.txtPeriodo.Size = new System.Drawing.Size(174, 27);
            this.txtPeriodo.TabIndex = 64;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(492, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 63;
            this.label3.Text = "Periodo";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(7, 81);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(118, 20);
            this.label14.TabIndex = 62;
            this.label14.Text = "Data da prova";
            // 
            // dtkprova
            // 
            this.dtkprova.Location = new System.Drawing.Point(10, 104);
            this.dtkprova.Name = "dtkprova";
            this.dtkprova.Size = new System.Drawing.Size(175, 27);
            this.dtkprova.TabIndex = 61;
            // 
            // cmbCoordenacao
            // 
            this.cmbCoordenacao.FormattingEnabled = true;
            this.cmbCoordenacao.Location = new System.Drawing.Point(235, 243);
            this.cmbCoordenacao.MaxDropDownItems = 4;
            this.cmbCoordenacao.Name = "cmbCoordenacao";
            this.cmbCoordenacao.Size = new System.Drawing.Size(174, 28);
            this.cmbCoordenacao.TabIndex = 60;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(231, 220);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(115, 20);
            this.label13.TabIndex = 59;
            this.label13.Text = "Coordenação";
            // 
            // txtTipoProva
            // 
            this.txtTipoProva.Location = new System.Drawing.Point(496, 109);
            this.txtTipoProva.Name = "txtTipoProva";
            this.txtTipoProva.Size = new System.Drawing.Size(174, 27);
            this.txtTipoProva.TabIndex = 58;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(492, 84);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 20);
            this.label12.TabIndex = 57;
            this.label12.Text = "Tipo de prova";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(615, 219);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 20);
            this.label10.TabIndex = 56;
            this.label10.Text = "Hora final";
            // 
            // mkbfinal
            // 
            this.mkbfinal.Location = new System.Drawing.Point(621, 244);
            this.mkbfinal.Mask = "00:00";
            this.mkbfinal.Name = "mkbfinal";
            this.mkbfinal.Size = new System.Drawing.Size(49, 27);
            this.mkbfinal.TabIndex = 55;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(495, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 20);
            this.label7.TabIndex = 54;
            this.label7.Text = "Hora inicial";
            // 
            // mkbinicial
            // 
            this.mkbinicial.Location = new System.Drawing.Point(499, 244);
            this.mkbinicial.Mask = "00:00";
            this.mkbinicial.Name = "mkbinicial";
            this.mkbinicial.Size = new System.Drawing.Size(40, 27);
            this.mkbinicial.TabIndex = 53;
            // 
            // cmbSala
            // 
            this.cmbSala.FormattingEnabled = true;
            this.cmbSala.Location = new System.Drawing.Point(235, 177);
            this.cmbSala.MaxDropDownItems = 4;
            this.cmbSala.Name = "cmbSala";
            this.cmbSala.Size = new System.Drawing.Size(174, 28);
            this.cmbSala.TabIndex = 52;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(231, 154);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 20);
            this.label9.TabIndex = 51;
            this.label9.Text = "Sala";
            // 
            // cmbDisciplina
            // 
            this.cmbDisciplina.FormattingEnabled = true;
            this.cmbDisciplina.Location = new System.Drawing.Point(235, 106);
            this.cmbDisciplina.MaxDropDownItems = 4;
            this.cmbDisciplina.Name = "cmbDisciplina";
            this.cmbDisciplina.Size = new System.Drawing.Size(174, 28);
            this.cmbDisciplina.TabIndex = 50;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(231, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 20);
            this.label8.TabIndex = 49;
            this.label8.Text = "Disciplína";
            // 
            // cmbTurma
            // 
            this.cmbTurma.FormattingEnabled = true;
            this.cmbTurma.Location = new System.Drawing.Point(10, 243);
            this.cmbTurma.MaxDropDownItems = 4;
            this.cmbTurma.Name = "cmbTurma";
            this.cmbTurma.Size = new System.Drawing.Size(174, 28);
            this.cmbTurma.TabIndex = 48;
            // 
            // cmbprofessor
            // 
            this.cmbprofessor.FormattingEnabled = true;
            this.cmbprofessor.Location = new System.Drawing.Point(11, 177);
            this.cmbprofessor.MaxDropDownItems = 4;
            this.cmbprofessor.Name = "cmbprofessor";
            this.cmbprofessor.Size = new System.Drawing.Size(174, 28);
            this.cmbprofessor.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(356, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código:";
            this.label2.Visible = false;
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(436, 39);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(45, 23);
            this.txtId.TabIndex = 23;
            this.txtId.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.btnEncerrar);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(790, 53);
            this.panel1.TabIndex = 31;
            // 
            // btnEncerrar
            // 
            this.btnEncerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEncerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEncerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnEncerrar.Image")));
            this.btnEncerrar.Location = new System.Drawing.Point(750, 15);
            this.btnEncerrar.Name = "btnEncerrar";
            this.btnEncerrar.Size = new System.Drawing.Size(27, 17);
            this.btnEncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEncerrar.TabIndex = 3;
            this.btnEncerrar.TabStop = false;
            this.btnEncerrar.Click += new System.EventHandler(this.btnEncerrar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(12, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Prova";
            // 
            // frmCaPro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 574);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tabControlSala);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCaPro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCaPro";
            this.Load += new System.EventHandler(this.frmCaPro_Load);
            this.tabControlSala.ResumeLayout(false);
            this.tabSConsu.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDados)).EndInit();
            this.tabSCad.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEncerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnEncerrar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPeriodo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtkprova;
        private System.Windows.Forms.ComboBox cmbCoordenacao;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTipoProva;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox mkbfinal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox mkbinicial;
        private System.Windows.Forms.ComboBox cmbSala;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbDisciplina;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbTurma;
        private System.Windows.Forms.ComboBox cmbprofessor;
    }
}
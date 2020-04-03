namespace GUE
{
    partial class frmTesteFoto
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
            this.pbeFoto = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbeFoto)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbeFoto
            // 
            this.pbeFoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbeFoto.Location = new System.Drawing.Point(0, 0);
            this.pbeFoto.Name = "pbeFoto";
            this.pbeFoto.Size = new System.Drawing.Size(162, 170);
            this.pbeFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbeFoto.TabIndex = 1;
            this.pbeFoto.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(402, 323);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Remover";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(312, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pbeFoto);
            this.panel1.Location = new System.Drawing.Point(311, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(166, 174);
            this.panel1.TabIndex = 3;
            // 
            // frmTesteFoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 447);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "frmTesteFoto";
            this.Text = "frmTesteFoto";
            this.Load += new System.EventHandler(this.frmTesteFoto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbeFoto)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbeFoto;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
    }
}
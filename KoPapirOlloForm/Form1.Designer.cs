namespace KoPapirOlloForm
{
    partial class frmFo
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblJatekos = new System.Windows.Forms.Label();
            this.lblGep = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbJatekos = new System.Windows.Forms.PictureBox();
            this.pbGep = new System.Windows.Forms.PictureBox();
            this.lblGyoztes = new System.Windows.Forms.Label();
            this.btnKo = new System.Windows.Forms.Button();
            this.btnPapir = new System.Windows.Forms.Button();
            this.btnOllo = new System.Windows.Forms.Button();
            this.btnKilepes = new System.Windows.Forms.Button();
            this.btnSzabaly = new System.Windows.Forms.Button();
            this.btnUj = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbJatekos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGep)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Játékos:";
            // 
            // lblJatekos
            // 
            this.lblJatekos.AutoSize = true;
            this.lblJatekos.Location = new System.Drawing.Point(149, 20);
            this.lblJatekos.Name = "lblJatekos";
            this.lblJatekos.Size = new System.Drawing.Size(51, 20);
            this.lblJatekos.TabIndex = 2;
            this.lblJatekos.Text = "label3";
            // 
            // lblGep
            // 
            this.lblGep.AutoSize = true;
            this.lblGep.Location = new System.Drawing.Point(449, 20);
            this.lblGep.Name = "lblGep";
            this.lblGep.Size = new System.Drawing.Size(51, 20);
            this.lblGep.TabIndex = 3;
            this.lblGep.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(392, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Gép";
            // 
            // pbJatekos
            // 
            this.pbJatekos.Location = new System.Drawing.Point(44, 92);
            this.pbJatekos.Name = "pbJatekos";
            this.pbJatekos.Size = new System.Drawing.Size(200, 200);
            this.pbJatekos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbJatekos.TabIndex = 5;
            this.pbJatekos.TabStop = false;
            this.pbJatekos.Click += new System.EventHandler(this.pbJatekos_Click);
            // 
            // pbGep
            // 
            this.pbGep.Location = new System.Drawing.Point(345, 92);
            this.pbGep.Name = "pbGep";
            this.pbGep.Size = new System.Drawing.Size(200, 200);
            this.pbGep.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGep.TabIndex = 6;
            this.pbGep.TabStop = false;
            // 
            // lblGyoztes
            // 
            this.lblGyoztes.AutoSize = true;
            this.lblGyoztes.Location = new System.Drawing.Point(270, 321);
            this.lblGyoztes.Name = "lblGyoztes";
            this.lblGyoztes.Size = new System.Drawing.Size(51, 20);
            this.lblGyoztes.TabIndex = 7;
            this.lblGyoztes.Text = "label3";
            // 
            // btnKo
            // 
            this.btnKo.Location = new System.Drawing.Point(62, 14);
            this.btnKo.Name = "btnKo";
            this.btnKo.Size = new System.Drawing.Size(79, 33);
            this.btnKo.TabIndex = 8;
            this.btnKo.Text = "Kő";
            this.btnKo.UseVisualStyleBackColor = true;
            this.btnKo.Click += new System.EventHandler(this.btnKo_Click);
            // 
            // btnPapir
            // 
            this.btnPapir.Location = new System.Drawing.Point(245, 13);
            this.btnPapir.Name = "btnPapir";
            this.btnPapir.Size = new System.Drawing.Size(79, 34);
            this.btnPapir.TabIndex = 9;
            this.btnPapir.Text = "Papír";
            this.btnPapir.UseVisualStyleBackColor = true;
            this.btnPapir.Click += new System.EventHandler(this.btnPapir_Click);
            // 
            // btnOllo
            // 
            this.btnOllo.Location = new System.Drawing.Point(428, 14);
            this.btnOllo.Name = "btnOllo";
            this.btnOllo.Size = new System.Drawing.Size(79, 33);
            this.btnOllo.TabIndex = 10;
            this.btnOllo.Text = "Olló";
            this.btnOllo.UseVisualStyleBackColor = true;
            this.btnOllo.Click += new System.EventHandler(this.btnOllo_Click);
            // 
            // btnKilepes
            // 
            this.btnKilepes.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnKilepes.Location = new System.Drawing.Point(17, 429);
            this.btnKilepes.Name = "btnKilepes";
            this.btnKilepes.Size = new System.Drawing.Size(166, 29);
            this.btnKilepes.TabIndex = 11;
            this.btnKilepes.Text = "Kilépés";
            this.btnKilepes.UseVisualStyleBackColor = true;
            this.btnKilepes.Click += new System.EventHandler(this.btnKilepes_Click);
            // 
            // btnSzabaly
            // 
            this.btnSzabaly.Location = new System.Drawing.Point(209, 429);
            this.btnSzabaly.Name = "btnSzabaly";
            this.btnSzabaly.Size = new System.Drawing.Size(166, 29);
            this.btnSzabaly.TabIndex = 12;
            this.btnSzabaly.Text = "Szabályok";
            this.btnSzabaly.UseVisualStyleBackColor = true;
            // 
            // btnUj
            // 
            this.btnUj.Location = new System.Drawing.Point(401, 429);
            this.btnUj.Name = "btnUj";
            this.btnUj.Size = new System.Drawing.Size(166, 29);
            this.btnUj.TabIndex = 13;
            this.btnUj.Text = "Új játék";
            this.btnUj.UseVisualStyleBackColor = true;
            this.btnUj.Click += new System.EventHandler(this.btnUj_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pbGep);
            this.panel1.Controls.Add(this.pbJatekos);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblGep);
            this.panel1.Controls.Add(this.lblJatekos);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(575, 337);
            this.panel1.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(269, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "label3";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.btnOllo);
            this.panel2.Controls.Add(this.btnPapir);
            this.panel2.Controls.Add(this.btnKo);
            this.panel2.Location = new System.Drawing.Point(1, 363);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(575, 60);
            this.panel2.TabIndex = 15;
            // 
            // frmFo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnKilepes;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnUj);
            this.Controls.Add(this.btnSzabaly);
            this.Controls.Add(this.btnKilepes);
            this.Controls.Add(this.lblGyoztes);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmFo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kő, Papír, Olló";
            this.Load += new System.EventHandler(this.frmFo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbJatekos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGep)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblJatekos;
        private System.Windows.Forms.Label lblGep;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbJatekos;
        private System.Windows.Forms.PictureBox pbGep;
        private System.Windows.Forms.Label lblGyoztes;
        private System.Windows.Forms.Button btnKo;
        private System.Windows.Forms.Button btnPapir;
        private System.Windows.Forms.Button btnOllo;
        private System.Windows.Forms.Button btnKilepes;
        private System.Windows.Forms.Button btnSzabaly;
        private System.Windows.Forms.Button btnUj;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
    }
}


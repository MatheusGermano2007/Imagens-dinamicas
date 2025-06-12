namespace Form_multiplo
{
    partial class frmMenuJogo
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnCarregarFoto1 = new System.Windows.Forms.Button();
            this.btnJogar = new System.Windows.Forms.Button();
            this.btnCarregarFoto2 = new System.Windows.Forms.Button();
            this.txtNomeJog1 = new System.Windows.Forms.TextBox();
            this.txtNomeJog2 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblPlacar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NomeJogador 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(294, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "NomeJogador2";
            // 
            // btnCarregarFoto1
            // 
            this.btnCarregarFoto1.Location = new System.Drawing.Point(86, 315);
            this.btnCarregarFoto1.Name = "btnCarregarFoto1";
            this.btnCarregarFoto1.Size = new System.Drawing.Size(79, 55);
            this.btnCarregarFoto1.TabIndex = 2;
            this.btnCarregarFoto1.Text = "CarregarFoto";
            this.btnCarregarFoto1.UseVisualStyleBackColor = true;
            this.btnCarregarFoto1.Click += new System.EventHandler(this.btnCarregarFoto1_Click);
            // 
            // btnJogar
            // 
            this.btnJogar.Location = new System.Drawing.Point(220, 315);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(75, 55);
            this.btnJogar.TabIndex = 3;
            this.btnJogar.Text = "Jogar";
            this.btnJogar.UseVisualStyleBackColor = true;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // btnCarregarFoto2
            // 
            this.btnCarregarFoto2.Location = new System.Drawing.Point(345, 315);
            this.btnCarregarFoto2.Name = "btnCarregarFoto2";
            this.btnCarregarFoto2.Size = new System.Drawing.Size(80, 55);
            this.btnCarregarFoto2.TabIndex = 4;
            this.btnCarregarFoto2.Text = "CarregarFoto";
            this.btnCarregarFoto2.UseVisualStyleBackColor = true;
            this.btnCarregarFoto2.Click += new System.EventHandler(this.btnCarregarFoto2_Click);
            // 
            // txtNomeJog1
            // 
            this.txtNomeJog1.Location = new System.Drawing.Point(86, 101);
            this.txtNomeJog1.Name = "txtNomeJog1";
            this.txtNomeJog1.Size = new System.Drawing.Size(100, 20);
            this.txtNomeJog1.TabIndex = 7;
            // 
            // txtNomeJog2
            // 
            this.txtNomeJog2.Location = new System.Drawing.Point(297, 101);
            this.txtNomeJog2.Name = "txtNomeJog2";
            this.txtNomeJog2.Size = new System.Drawing.Size(100, 20);
            this.txtNomeJog2.TabIndex = 8;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(297, 127);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(128, 144);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(86, 127);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // lblPlacar
            // 
            this.lblPlacar.BackColor = System.Drawing.SystemColors.Info;
            this.lblPlacar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPlacar.Location = new System.Drawing.Point(456, 331);
            this.lblPlacar.Name = "lblPlacar";
            this.lblPlacar.Size = new System.Drawing.Size(100, 39);
            this.lblPlacar.TabIndex = 9;
            // 
            // frmMenuJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 450);
            this.Controls.Add(this.lblPlacar);
            this.Controls.Add(this.txtNomeJog2);
            this.Controls.Add(this.txtNomeJog1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCarregarFoto2);
            this.Controls.Add(this.btnJogar);
            this.Controls.Add(this.btnCarregarFoto1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmMenuJogo";
            this.Text = "frmMenuJogo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCarregarFoto1;
        private System.Windows.Forms.Button btnJogar;
        private System.Windows.Forms.Button btnCarregarFoto2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtNomeJog1;
        private System.Windows.Forms.TextBox txtNomeJog2;
        private System.Windows.Forms.Label lblPlacar;
    }
}
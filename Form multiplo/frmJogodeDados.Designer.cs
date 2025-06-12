namespace Form_multiplo
{
    partial class frmJogodeDados
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
            this.lblPlacar2 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnJogar = new System.Windows.Forms.Button();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.lblJogador2 = new System.Windows.Forms.Label();
            this.lblPlacar1 = new System.Windows.Forms.Label();
            this.lblJogador1 = new System.Windows.Forms.Label();
            this.pcJogador2 = new System.Windows.Forms.PictureBox();
            this.pcJogador1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcJogador2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcJogador1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPlacar2
            // 
            this.lblPlacar2.BackColor = System.Drawing.Color.Yellow;
            this.lblPlacar2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPlacar2.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlacar2.Location = new System.Drawing.Point(554, 267);
            this.lblPlacar2.Name = "lblPlacar2";
            this.lblPlacar2.Size = new System.Drawing.Size(79, 73);
            this.lblPlacar2.TabIndex = 18;
            this.lblPlacar2.Click += new System.EventHandler(this.lblPlacar2_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(444, 376);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(144, 58);
            this.btnSair.TabIndex = 17;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnJogar
            // 
            this.btnJogar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJogar.Location = new System.Drawing.Point(286, 376);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(144, 58);
            this.btnJogar.TabIndex = 16;
            this.btnJogar.Text = "Jogar";
            this.btnJogar.UseVisualStyleBackColor = true;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReiniciar.Location = new System.Drawing.Point(124, 376);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(144, 58);
            this.btnReiniciar.TabIndex = 15;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // lblJogador2
            // 
            this.lblJogador2.AutoSize = true;
            this.lblJogador2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJogador2.Location = new System.Drawing.Point(550, 17);
            this.lblJogador2.Name = "lblJogador2";
            this.lblJogador2.Size = new System.Drawing.Size(80, 20);
            this.lblJogador2.TabIndex = 14;
            this.lblJogador2.Text = "Jogador 2";
            // 
            // lblPlacar1
            // 
            this.lblPlacar1.BackColor = System.Drawing.Color.Yellow;
            this.lblPlacar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPlacar1.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlacar1.Location = new System.Drawing.Point(63, 267);
            this.lblPlacar1.Name = "lblPlacar1";
            this.lblPlacar1.Size = new System.Drawing.Size(80, 73);
            this.lblPlacar1.TabIndex = 12;
            // 
            // lblJogador1
            // 
            this.lblJogador1.AutoSize = true;
            this.lblJogador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJogador1.Location = new System.Drawing.Point(59, 17);
            this.lblJogador1.Name = "lblJogador1";
            this.lblJogador1.Size = new System.Drawing.Size(80, 20);
            this.lblJogador1.TabIndex = 11;
            this.lblJogador1.Text = "Jogador 1";
            // 
            // pcJogador2
            // 
            this.pcJogador2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcJogador2.Location = new System.Drawing.Point(492, 46);
            this.pcJogador2.Name = "pcJogador2";
            this.pcJogador2.Size = new System.Drawing.Size(220, 220);
            this.pcJogador2.TabIndex = 13;
            this.pcJogador2.TabStop = false;
            // 
            // pcJogador1
            // 
            this.pcJogador1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcJogador1.Location = new System.Drawing.Point(15, 48);
            this.pcJogador1.Name = "pcJogador1";
            this.pcJogador1.Size = new System.Drawing.Size(220, 220);
            this.pcJogador1.TabIndex = 10;
            this.pcJogador1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Placar 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(553, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Placar 2";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(677, 410);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(61, 28);
            this.btnVoltar.TabIndex = 21;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // frmJogodeDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(761, 450);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPlacar2);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnJogar);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.lblJogador2);
            this.Controls.Add(this.pcJogador2);
            this.Controls.Add(this.lblPlacar1);
            this.Controls.Add(this.lblJogador1);
            this.Controls.Add(this.pcJogador1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frmJogodeDados";
            this.Text = "frmJogodeDados";
            this.Load += new System.EventHandler(this.frmJogodeDados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcJogador2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcJogador1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlacar2;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnJogar;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Label lblJogador2;
        private System.Windows.Forms.PictureBox pcJogador2;
        private System.Windows.Forms.Label lblPlacar1;
        private System.Windows.Forms.Label lblJogador1;
        private System.Windows.Forms.PictureBox pcJogador1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVoltar;
    }
}
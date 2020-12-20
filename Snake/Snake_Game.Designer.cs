namespace Snake
{
    partial class Snake_Game
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Startbtn = new System.Windows.Forms.Button();
            this.timelbl = new System.Windows.Forms.Label();
            this.lenghtlbl = new System.Windows.Forms.Label();
            this.highlbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(776, 426);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(805, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Time: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(802, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Highscore:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(805, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Score:";
            // 
            // Startbtn
            // 
            this.Startbtn.Location = new System.Drawing.Point(805, 415);
            this.Startbtn.Name = "Startbtn";
            this.Startbtn.Size = new System.Drawing.Size(181, 23);
            this.Startbtn.TabIndex = 7;
            this.Startbtn.Text = "Start";
            this.Startbtn.UseVisualStyleBackColor = true;
            this.Startbtn.Click += new System.EventHandler(this.Startbtn_Click);
            // 
            // timelbl
            // 
            this.timelbl.AutoSize = true;
            this.timelbl.Location = new System.Drawing.Point(847, 26);
            this.timelbl.Name = "timelbl";
            this.timelbl.Size = new System.Drawing.Size(0, 13);
            this.timelbl.TabIndex = 8;
            // 
            // lenghtlbl
            // 
            this.lenghtlbl.AutoSize = true;
            this.lenghtlbl.Location = new System.Drawing.Point(849, 50);
            this.lenghtlbl.Name = "lenghtlbl";
            this.lenghtlbl.Size = new System.Drawing.Size(0, 13);
            this.lenghtlbl.TabIndex = 9;
            // 
            // highlbl
            // 
            this.highlbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.highlbl.Location = new System.Drawing.Point(805, 101);
            this.highlbl.Name = "highlbl";
            this.highlbl.Size = new System.Drawing.Size(179, 302);
            this.highlbl.TabIndex = 10;
            // 
            // Snake_Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 450);
            this.Controls.Add(this.highlbl);
            this.Controls.Add(this.lenghtlbl);
            this.Controls.Add(this.timelbl);
            this.Controls.Add(this.Startbtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Snake_Game";
            this.Text = "Snake";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Startbtn;
        private System.Windows.Forms.Label timelbl;
        private System.Windows.Forms.Label lenghtlbl;
        private System.Windows.Forms.Label highlbl;
    }
}


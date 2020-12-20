namespace Snake
{
    partial class Zapisz_Wynik
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Savebtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Restartbtn = new System.Windows.Forms.Button();
            this.Wyniklbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Podaj Imie";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(75, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // Savebtn
            // 
            this.Savebtn.Location = new System.Drawing.Point(181, 24);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(75, 23);
            this.Savebtn.TabIndex = 2;
            this.Savebtn.Text = "Save";
            this.Savebtn.UseVisualStyleBackColor = true;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "Zapisz swój wynik:";
            // 
            // Restartbtn
            // 
            this.Restartbtn.Location = new System.Drawing.Point(13, 52);
            this.Restartbtn.Name = "Restartbtn";
            this.Restartbtn.Size = new System.Drawing.Size(243, 23);
            this.Restartbtn.TabIndex = 4;
            this.Restartbtn.Text = "Restart";
            this.Restartbtn.UseVisualStyleBackColor = true;
            this.Restartbtn.Click += new System.EventHandler(this.Restartbtn_Click);
            // 
            // Wyniklbl
            // 
            this.Wyniklbl.AutoSize = true;
            this.Wyniklbl.Location = new System.Drawing.Point(114, 9);
            this.Wyniklbl.Name = "Wyniklbl";
            this.Wyniklbl.Size = new System.Drawing.Size(0, 13);
            this.Wyniklbl.TabIndex = 5;
            // 
            // Zapisz_Wynik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 78);
            this.Controls.Add(this.Wyniklbl);
            this.Controls.Add(this.Restartbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Savebtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Zapisz_Wynik";
            this.Text = "formPopup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Restartbtn;
        public System.Windows.Forms.Label Wyniklbl;
    }
}
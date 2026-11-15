namespace Projekat6622
{
    partial class frmTezina
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
            this.rbtnTezina2 = new System.Windows.Forms.RadioButton();
            this.rbtnTezina1 = new System.Windows.Forms.RadioButton();
            this.rbtnTezina3 = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPotvrdi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // rbtnTezina2
            // 
            this.rbtnTezina2.AutoSize = true;
            this.rbtnTezina2.Location = new System.Drawing.Point(245, 39);
            this.rbtnTezina2.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnTezina2.Name = "rbtnTezina2";
            this.rbtnTezina2.Size = new System.Drawing.Size(14, 13);
            this.rbtnTezina2.TabIndex = 0;
            this.rbtnTezina2.TabStop = true;
            this.rbtnTezina2.UseVisualStyleBackColor = true;
            this.rbtnTezina2.CheckedChanged += new System.EventHandler(this.rbtnTezina2_CheckedChanged);
            // 
            // rbtnTezina1
            // 
            this.rbtnTezina1.AutoSize = true;
            this.rbtnTezina1.Location = new System.Drawing.Point(72, 39);
            this.rbtnTezina1.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnTezina1.Name = "rbtnTezina1";
            this.rbtnTezina1.Size = new System.Drawing.Size(14, 13);
            this.rbtnTezina1.TabIndex = 1;
            this.rbtnTezina1.TabStop = true;
            this.rbtnTezina1.UseVisualStyleBackColor = true;
            this.rbtnTezina1.CheckedChanged += new System.EventHandler(this.rbtnTezina1_CheckedChanged);
            // 
            // rbtnTezina3
            // 
            this.rbtnTezina3.AutoSize = true;
            this.rbtnTezina3.Location = new System.Drawing.Point(411, 39);
            this.rbtnTezina3.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnTezina3.Name = "rbtnTezina3";
            this.rbtnTezina3.Size = new System.Drawing.Size(14, 13);
            this.rbtnTezina3.TabIndex = 2;
            this.rbtnTezina3.TabStop = true;
            this.rbtnTezina3.UseVisualStyleBackColor = true;
            this.rbtnTezina3.CheckedChanged += new System.EventHandler(this.rbtnTezina3_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Projekat6622.Properties.Resources._1;
            this.pictureBox1.Location = new System.Drawing.Point(6, 64);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Projekat6622.Properties.Resources._2_png;
            this.pictureBox2.Location = new System.Drawing.Point(172, 64);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(156, 150);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Projekat6622.Properties.Resources._3_png;
            this.pictureBox3.Location = new System.Drawing.Point(332, 64);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(156, 150);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(13, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Izaberite težinu igre:";
            // 
            // btnPotvrdi
            // 
            this.btnPotvrdi.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnPotvrdi.Location = new System.Drawing.Point(432, 243);
            this.btnPotvrdi.Margin = new System.Windows.Forms.Padding(2);
            this.btnPotvrdi.Name = "btnPotvrdi";
            this.btnPotvrdi.Size = new System.Drawing.Size(115, 34);
            this.btnPotvrdi.TabIndex = 7;
            this.btnPotvrdi.Text = "Potvrdi";
            this.btnPotvrdi.UseVisualStyleBackColor = true;
            this.btnPotvrdi.Click += new System.EventHandler(this.btnPotvrdi_Click);
            // 
            // frmTezina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 305);
            this.Controls.Add(this.btnPotvrdi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.rbtnTezina3);
            this.Controls.Add(this.rbtnTezina1);
            this.Controls.Add(this.rbtnTezina2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmTezina";
            this.Text = "Tezina";
            this.Load += new System.EventHandler(this.frmTezina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnTezina2;
        private System.Windows.Forms.RadioButton rbtnTezina1;
        private System.Windows.Forms.RadioButton rbtnTezina3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPotvrdi;
    }
}
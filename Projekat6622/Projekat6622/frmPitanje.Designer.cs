
namespace Projekat6622
{
    partial class frmPitanje
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
            this.tbxOdgovor1 = new System.Windows.Forms.TextBox();
            this.tbxOdgovor2 = new System.Windows.Forms.TextBox();
            this.tbxOdgovor3 = new System.Windows.Forms.TextBox();
            this.rbtnA = new System.Windows.Forms.RadioButton();
            this.rbtnB = new System.Windows.Forms.RadioButton();
            this.rbtnC = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblPitanje = new System.Windows.Forms.Label();
            this.lblObavestenje = new System.Windows.Forms.Label();
            this.btnDalje = new System.Windows.Forms.Button();
            this.btnPredaj = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.LBLPitanjeetna = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnIzadjiPitanje = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pnlDevojka = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tmrCPU = new System.Windows.Forms.Timer(this.components);
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxOdgovor1
            // 
            this.tbxOdgovor1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxOdgovor1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tbxOdgovor1.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxOdgovor1.Location = new System.Drawing.Point(279, 248);
            this.tbxOdgovor1.Name = "tbxOdgovor1";
            this.tbxOdgovor1.ReadOnly = true;
            this.tbxOdgovor1.Size = new System.Drawing.Size(513, 33);
            this.tbxOdgovor1.TabIndex = 1;
            // 
            // tbxOdgovor2
            // 
            this.tbxOdgovor2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxOdgovor2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tbxOdgovor2.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold);
            this.tbxOdgovor2.Location = new System.Drawing.Point(279, 307);
            this.tbxOdgovor2.Name = "tbxOdgovor2";
            this.tbxOdgovor2.ReadOnly = true;
            this.tbxOdgovor2.Size = new System.Drawing.Size(513, 33);
            this.tbxOdgovor2.TabIndex = 2;
            // 
            // tbxOdgovor3
            // 
            this.tbxOdgovor3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxOdgovor3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tbxOdgovor3.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold);
            this.tbxOdgovor3.ForeColor = System.Drawing.Color.Black;
            this.tbxOdgovor3.Location = new System.Drawing.Point(279, 362);
            this.tbxOdgovor3.Name = "tbxOdgovor3";
            this.tbxOdgovor3.ReadOnly = true;
            this.tbxOdgovor3.Size = new System.Drawing.Size(513, 33);
            this.tbxOdgovor3.TabIndex = 3;
            // 
            // rbtnA
            // 
            this.rbtnA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbtnA.AutoSize = true;
            this.rbtnA.Location = new System.Drawing.Point(208, 251);
            this.rbtnA.Name = "rbtnA";
            this.rbtnA.Size = new System.Drawing.Size(14, 13);
            this.rbtnA.TabIndex = 4;
            this.rbtnA.TabStop = true;
            this.rbtnA.UseVisualStyleBackColor = true;
            // 
            // rbtnB
            // 
            this.rbtnB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbtnB.AutoSize = true;
            this.rbtnB.Location = new System.Drawing.Point(208, 310);
            this.rbtnB.Name = "rbtnB";
            this.rbtnB.Size = new System.Drawing.Size(14, 13);
            this.rbtnB.TabIndex = 5;
            this.rbtnB.TabStop = true;
            this.rbtnB.UseVisualStyleBackColor = true;
            // 
            // rbtnC
            // 
            this.rbtnC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbtnC.AutoSize = true;
            this.rbtnC.Location = new System.Drawing.Point(208, 365);
            this.rbtnC.Name = "rbtnC";
            this.rbtnC.Size = new System.Drawing.Size(14, 13);
            this.rbtnC.TabIndex = 6;
            this.rbtnC.TabStop = true;
            this.rbtnC.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.progressBar1.Location = new System.Drawing.Point(274, 33);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(525, 38);
            this.progressBar1.TabIndex = 10;
            // 
            // lblPitanje
            // 
            this.lblPitanje.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPitanje.BackColor = System.Drawing.Color.RoyalBlue;
            this.lblPitanje.Font = new System.Drawing.Font("Segoe Script", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPitanje.Location = new System.Drawing.Point(141, 134);
            this.lblPitanje.Name = "lblPitanje";
            this.lblPitanje.Size = new System.Drawing.Size(916, 110);
            this.lblPitanje.TabIndex = 11;
            // 
            // lblObavestenje
            // 
            this.lblObavestenje.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblObavestenje.AutoSize = true;
            this.lblObavestenje.Font = new System.Drawing.Font("Segoe Script", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObavestenje.ForeColor = System.Drawing.Color.White;
            this.lblObavestenje.Location = new System.Drawing.Point(407, 399);
            this.lblObavestenje.Name = "lblObavestenje";
            this.lblObavestenje.Size = new System.Drawing.Size(83, 34);
            this.lblObavestenje.TabIndex = 12;
            this.lblObavestenje.Text = "label1";
            // 
            // btnDalje
            // 
            this.btnDalje.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDalje.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDalje.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDalje.Font = new System.Drawing.Font("Segoe Script", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDalje.Location = new System.Drawing.Point(258, 446);
            this.btnDalje.Name = "btnDalje";
            this.btnDalje.Size = new System.Drawing.Size(210, 81);
            this.btnDalje.TabIndex = 9;
            this.btnDalje.Text = "DALjE\r\n";
            this.btnDalje.UseVisualStyleBackColor = false;
            this.btnDalje.Click += new System.EventHandler(this.btnDalje_Click);
            // 
            // btnPredaj
            // 
            this.btnPredaj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPredaj.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnPredaj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPredaj.Font = new System.Drawing.Font("Segoe Script", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPredaj.Location = new System.Drawing.Point(546, 446);
            this.btnPredaj.Name = "btnPredaj";
            this.btnPredaj.Size = new System.Drawing.Size(253, 81);
            this.btnPredaj.TabIndex = 7;
            this.btnPredaj.Text = "POTVRDI";
            this.btnPredaj.UseVisualStyleBackColor = false;
            this.btnPredaj.Click += new System.EventHandler(this.btnPredaj_Click);
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.LBLPitanjeetna);
            this.panel5.Location = new System.Drawing.Point(200, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(756, 100);
            this.panel5.TabIndex = 15;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // LBLPitanjeetna
            // 
            this.LBLPitanjeetna.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LBLPitanjeetna.AutoEllipsis = true;
            this.LBLPitanjeetna.AutoSize = true;
            this.LBLPitanjeetna.Font = new System.Drawing.Font("Segoe Script", 56.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLPitanjeetna.Location = new System.Drawing.Point(190, -13);
            this.LBLPitanjeetna.Name = "LBLPitanjeetna";
            this.LBLPitanjeetna.Size = new System.Drawing.Size(566, 124);
            this.LBLPitanjeetna.TabIndex = 13;
            this.LBLPitanjeetna.Text = "P I T A NJ E";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.btnIzadjiPitanje);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.pnlDevojka);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 558);
            this.panel3.TabIndex = 16;
            // 
            // btnIzadjiPitanje
            // 
            this.btnIzadjiPitanje.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnIzadjiPitanje.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzadjiPitanje.Location = new System.Drawing.Point(-2, 150);
            this.btnIzadjiPitanje.Name = "btnIzadjiPitanje";
            this.btnIzadjiPitanje.Size = new System.Drawing.Size(200, 60);
            this.btnIzadjiPitanje.TabIndex = 7;
            this.btnIzadjiPitanje.Text = "Izađi iz igre";
            this.btnIzadjiPitanje.UseVisualStyleBackColor = false;
            this.btnIzadjiPitanje.Click += new System.EventHandler(this.btnIzadjiPitanje_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(57)))), ((int)(((byte)(187)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 44);
            this.label1.TabIndex = 2;
            this.label1.Text = "DJ3M";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::Projekat6622.Properties.Resources.team_icon_fantastic_five_removebg_preview;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(-11, -2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(128, 100);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // pnlDevojka
            // 
            this.pnlDevojka.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlDevojka.BackColor = System.Drawing.Color.Transparent;
            this.pnlDevojka.BackgroundImage = global::Projekat6622.Properties.Resources.srbgirl_removebg_preview;
            this.pnlDevojka.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlDevojka.Location = new System.Drawing.Point(0, 257);
            this.pnlDevojka.Name = "pnlDevojka";
            this.pnlDevojka.Size = new System.Drawing.Size(197, 296);
            this.pnlDevojka.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = global::Projekat6622.Properties.Resources.vez_ucosku_removebg_preview2;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(504, 140);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(438, 418);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // tmrCPU
            // 
            this.tmrCPU.Tick += new System.EventHandler(this.tmrCPU_Tick);
            // 
            // frmPitanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(940, 557);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.lblObavestenje);
            this.Controls.Add(this.lblPitanje);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnDalje);
            this.Controls.Add(this.btnPredaj);
            this.Controls.Add(this.rbtnC);
            this.Controls.Add(this.rbtnB);
            this.Controls.Add(this.rbtnA);
            this.Controls.Add(this.tbxOdgovor3);
            this.Controls.Add(this.tbxOdgovor2);
            this.Controls.Add(this.tbxOdgovor1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPitanje";
            this.Text = "Pitanje";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPitanje_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbxOdgovor1;
        private System.Windows.Forms.TextBox tbxOdgovor2;
        private System.Windows.Forms.TextBox tbxOdgovor3;
        private System.Windows.Forms.RadioButton rbtnA;
        private System.Windows.Forms.RadioButton rbtnB;
        private System.Windows.Forms.RadioButton rbtnC;
        private System.Windows.Forms.Button btnPredaj;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnDalje;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblPitanje;
        private System.Windows.Forms.Label lblObavestenje;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label LBLPitanjeetna;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.FlowLayoutPanel pnlDevojka;
        private System.Windows.Forms.Button btnIzadjiPitanje;
        private System.Windows.Forms.Timer tmrCPU;
    }
}
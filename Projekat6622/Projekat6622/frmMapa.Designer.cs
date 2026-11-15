
namespace Projekat6622
{
    partial class frmMapa
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
            this.pbxMapa = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tmrMapa = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbxMapa)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxMapa
            // 
            this.pbxMapa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbxMapa.BackgroundImage = global::Projekat6622.Properties.Resources.mapaEvrope6_6_;
            this.pbxMapa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxMapa.Location = new System.Drawing.Point(50, -17);
            this.pbxMapa.Name = "pbxMapa";
            this.pbxMapa.Size = new System.Drawing.Size(808, 548);
            this.pbxMapa.TabIndex = 1;
            this.pbxMapa.TabStop = false;
            this.pbxMapa.Paint += new System.Windows.Forms.PaintEventHandler(this.pbxMapa_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.Font = new System.Drawing.Font("Segoe Script", 15F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(3, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 114);
            this.button1.TabIndex = 2;
            this.button1.Text = "IZAĐI IZ IGRE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmMapa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(212)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(924, 518);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pbxMapa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMapa";
            this.Text = "frmMapa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMapa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxMapa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pbxMapa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer tmrMapa;
    }
}

namespace Projekat6622
{
    partial class frmRezultat
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
            this.lblCestitamo = new System.Windows.Forms.Label();
            this.lblPobednik = new System.Windows.Forms.Label();
            this.btnIzadjiPitanje = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCestitamo
            // 
            this.lblCestitamo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblCestitamo.BackColor = System.Drawing.Color.Transparent;
            this.lblCestitamo.Font = new System.Drawing.Font("Segoe Script", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCestitamo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblCestitamo.Location = new System.Drawing.Point(239, 38);
            this.lblCestitamo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCestitamo.Name = "lblCestitamo";
            this.lblCestitamo.Size = new System.Drawing.Size(921, 164);
            this.lblCestitamo.TabIndex = 0;
            this.lblCestitamo.Text = "ČESTITAMO!!!";
            // 
            // lblPobednik
            // 
            this.lblPobednik.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblPobednik.BackColor = System.Drawing.Color.Transparent;
            this.lblPobednik.Font = new System.Drawing.Font("Segoe Script", 35F, System.Drawing.FontStyle.Bold);
            this.lblPobednik.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblPobednik.Location = new System.Drawing.Point(-11, 155);
            this.lblPobednik.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPobednik.Name = "lblPobednik";
            this.lblPobednik.Size = new System.Drawing.Size(921, 164);
            this.lblPobednik.TabIndex = 1;
            this.lblPobednik.Text = "Pobednik";
            // 
            // btnIzadjiPitanje
            // 
            this.btnIzadjiPitanje.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnIzadjiPitanje.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzadjiPitanje.Location = new System.Drawing.Point(988, 13);
            this.btnIzadjiPitanje.Margin = new System.Windows.Forms.Padding(4);
            this.btnIzadjiPitanje.Name = "btnIzadjiPitanje";
            this.btnIzadjiPitanje.Size = new System.Drawing.Size(247, 74);
            this.btnIzadjiPitanje.TabIndex = 8;
            this.btnIzadjiPitanje.Text = "Izađi iz igre";
            this.btnIzadjiPitanje.UseVisualStyleBackColor = false;
            this.btnIzadjiPitanje.Click += new System.EventHandler(this.btnIzadjiPitanje_Click);
            // 
            // frmRezultat
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::Projekat6622.Properties.Resources.kalemegdan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1232, 638);
            this.Controls.Add(this.btnIzadjiPitanje);
            this.Controls.Add(this.lblPobednik);
            this.Controls.Add(this.lblCestitamo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRezultat";
            this.Text = "frmRezultat";
            this.Load += new System.EventHandler(this.frmRezultat_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCestitamo;
        private System.Windows.Forms.Label lblPobednik;
        private System.Windows.Forms.Button btnIzadjiPitanje;
    }
}
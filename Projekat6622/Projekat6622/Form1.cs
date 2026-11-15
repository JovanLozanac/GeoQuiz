using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Projekat6622
{
    public partial class frmStart : Form
    {
        frmPocetna frm_pocetna = new frmPocetna();
        public frmStart()
        {
            InitializeComponent();
            backgroundWorker1.WorkerReportsProgress = true;
        }
        int height = Screen.PrimaryScreen.Bounds.Height;
        int width = Screen.PrimaryScreen.Bounds.Width;

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy)
            {
                // This method will start the execution asynchronously in the background
                backgroundWorker1.RunWorkerAsync();
            }
            this.Width = width;
            this.Height = height;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            int sum = 0;
            for (int i = 1; i <= 100; i++)
            {
                Thread.Sleep(10);
                sum = sum + i;
                backgroundWorker1.ReportProgress(i);
                if (i == 100)
                {
                    e.Cancel = true;
                    backgroundWorker1.ReportProgress(10);
                    return;
                }

                if (backgroundWorker1.CancellationPending)
                {
                    e.Cancel = true;
                    backgroundWorker1.ReportProgress(0);
                    return;
                }
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            prbarUcitavanje.Value = e.ProgressPercentage;
            lblUcitaj.Text = e.ProgressPercentage.ToString() + "%";
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                lblUcitaj.Text = "";
                frm_pocetna = new frmPocetna();
                frm_pocetna.ShowDialog();
                Close();
            }
            else if (e.Error != null)
            {
                lblUcitaj.Text = e.Error.Message;
            }
            else
            {
                lblUcitaj.Text = e.Result.ToString();
            }
        }
    }
}

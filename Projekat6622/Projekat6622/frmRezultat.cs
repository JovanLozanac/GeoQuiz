using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekat6622
{
    public partial class frmRezultat : Form
    {
        public frmRezultat()
        {
            InitializeComponent();
        }
        public string LblPobednik { set { lblPobednik.Text = value; } }
        private void frmRezultat_Load(object sender, EventArgs e)
        {
            lblCestitamo.Text = "Welcome to Serbia!";
        }

        private void btnIzadjiPitanje_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Da li ste sigurni da želite da izađete? ", "Izađi", MessageBoxButtons.YesNo);
            if (d==DialogResult.Yes) Environment.Exit(0);
        }
    }
}

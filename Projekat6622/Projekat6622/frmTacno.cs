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
    public partial class frmTacno : Form
    {
        public frmTacno()
        {
            InitializeComponent();
        }
        public string LblTacno { get { return lblTacno.Text; } set { lblTacno.Text = value; } }
        private void btnCLose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTacno_Load(object sender, EventArgs e)
        {

        }
    }
}

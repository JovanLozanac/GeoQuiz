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
    public partial class frmNetacno : Form
    {
        public frmNetacno()
        {
            InitializeComponent();
        }
        public string LblNetacno { set { lblNetacno.Text = value; } }
        public string LblTacno { set { lblObjasnjenjeTacnog.Text = value; } }
        public string LblTacanOdg { set { lblTacanOdg.Text = value; } }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
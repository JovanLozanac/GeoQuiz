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
    public partial class frmPreskoceno_pitanje : Form
    {
        public frmPreskoceno_pitanje()
        {
            InitializeComponent();
        }
        public string LblTacanOdg { set { lblTacanOdg.Text = value; } }
        public string LblObjasnjenjeTacnog { set { lblObjasnjenjeTacnog.Text = value; } }
        private void btnxks_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

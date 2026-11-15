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
    public partial class frmTezina : Form
    {
        int tezina;
        public frmTezina(ref int tezina)
        {
            InitializeComponent();
            this.tezina = tezina;
        }


        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rbtnTezina3_CheckedChanged(object sender, EventArgs e)
        {
            tezina = 3;
        }

        private void rbtnTezina2_CheckedChanged(object sender, EventArgs e)
        {
            tezina = 2;
        }

        private void rbtnTezina1_CheckedChanged(object sender, EventArgs e)
        {
            tezina = 1;
        }

        private void frmTezina_Load(object sender, EventArgs e)
        {
            rbtnTezina1.Checked = true;
            tezina = 1;
        }
    }
}

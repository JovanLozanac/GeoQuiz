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
    public partial class frmPersonalizacija : Form
    {
        frmPocetna frm_pocetna;
        public frmPersonalizacija(frmPocetna frm_pocetna)
        {
            InitializeComponent();
            this.frm_pocetna = frm_pocetna;
        }
        private void pbxSlika_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog dijalog = new OpenFileDialog();
            dijalog.Filter = "Slike(*.jpg; *.jpeg; *.bmp; *.png)|*.jpg; *.jpeg; *.bmp; *.png";
            pbxSlika.SizeMode = PictureBoxSizeMode.Zoom;
            if (dijalog.ShowDialog() == DialogResult.OK)
            {
                pbxSlika.Image = Image.FromFile(dijalog.FileName);
            }
        }

        private void frmPersonalizacija_Load(object sender, EventArgs e)
        {
            pbxSlika.Image = Properties.Resources.avatar;
            pbxSlika.SizeMode = PictureBoxSizeMode.Zoom;
            txbImeIgraca.Text = "";
            lblUnesi.Text = $"Unesite podatke za {frm_pocetna.Brojac_unosa_igraca + 1}. igraca.";
        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            frm_pocetna.Imena_igraca[frm_pocetna.Brojac_unosa_igraca] = txbImeIgraca.Text; 
            frm_pocetna.Slike_igraca[frm_pocetna.Brojac_unosa_igraca] = pbxSlika.Image;
            pbxSlika.Image = Properties.Resources.avatar;
            pbxSlika.SizeMode = PictureBoxSizeMode.Zoom;
            txbImeIgraca.Text = "";
            Hide();
            lblUnesi.Text = $"Unesite podatke za {frm_pocetna.Brojac_unosa_igraca + 1}. igraca.";
        }

        private void lblNaslov_Click(object sender, EventArgs e)
        {

        }
    }
}

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
using System.Media;

namespace Projekat6622
{
    public partial class frmPocetna : Form
    {
        frmPersonalizacija frm_pers;
        frmMapa frm_mapa;
        public frmPocetna()
        {
            InitializeComponent();
        }
        int broj_igraca;
        int brojac_unosa_igraca;
        int tezina;
        SoundPlayer muzika = new SoundPlayer(Properties.Resources.muzika);
        bool kliknuto;
        public int Broj_igraca { get { return broj_igraca; } }
        public int Brojac_unosa_igraca { get { return brojac_unosa_igraca; } }
        public bool CPU { get { return cpu; } }
        public int Tezina { get { return tezina; } }
        #region igraci
        // podaci o igracima iz formi frmPersonalizacija
        string[] imena_igraca;
        Image[] slike_igraca;
        bool cpu;
        public string[] Imena_igraca { get { return imena_igraca; } set { imena_igraca = value; } }
        public Image[] Slike_igraca { get { return slike_igraca; } set { slike_igraca = value; } }
        #endregion


        private void btnPlay_Click(object sender, EventArgs e)
        {
            // pokreni muziku
            muzika.PlayLooping();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!kliknuto) btnJedanIgrac_Click(sender, e);
            imena_igraca = new string[broj_igraca];
            slike_igraca = new Image[broj_igraca];
            brojac_unosa_igraca = 0;
            frm_pers = new frmPersonalizacija(this);
            if (cpu)
            {
                imena_igraca[0] = "CPU";
                slike_igraca[0] = Properties.Resources.cpu;
                brojac_unosa_igraca++;
            }
            Hide();
            for (; brojac_unosa_igraca < broj_igraca; brojac_unosa_igraca++)
            {
                frm_pers.ShowDialog();
            }
            frm_pers.Close();
            frm_mapa = new frmMapa(this);
            frm_mapa.ShowDialog();
            Close();
        }
        private void btnJedanIgrac_Click(object sender, EventArgs e)
        {
            frmTezina frm_tezina = new frmTezina(ref tezina);
            frm_tezina.ShowDialog();
            broj_igraca = 2; // jedan je CPU
            cpu = true;
            kliknuto = true;
        }

        private void btnDvaIgraca_Click(object sender, EventArgs e)
        {
            broj_igraca = 2;
            cpu = false;
            kliknuto = true;
        }

        private void btnTriIgraca_Click(object sender, EventArgs e)
        {
            broj_igraca = 3;
            cpu = false;
            kliknuto = true;
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            muzika.Stop();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmPocetna_Load(object sender, EventArgs e)
        {
            btnJedanIgrac.Select();
            cpu = true;
            kliknuto = false;
            muzika.PlayLooping();
        }
    }
}
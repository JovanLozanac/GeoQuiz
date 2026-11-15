using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;

namespace Projekat6622
{
    public partial class frmPitanje : Form
    {
        // iz prethodne forme
        List<Pitanje> pitanja;
        static HashSet<int> iskoriscena_pitanja = new HashSet<int>();
        int naredu;
        bool cpu;
        CPU cpu_igrac;

        // naredne forme
        frmTacno frm_tacno;
        frmNetacno frm_netacno;
        frmPreskoceno_pitanje frm_preskoceno_pitanje;
        frmFaktorSrece frm_faktorsrece;
        public frmPitanje(List<Pitanje> pitanja, int naredu, bool cpu, CPU cpu_igrac = null)
        {
            InitializeComponent();
            this.pitanja = pitanja;
            this.naredu = naredu;
            frm_tacno = new frmTacno();
            frm_netacno = new frmNetacno();
            frm_preskoceno_pitanje = new frmPreskoceno_pitanje();
            frm_faktorsrece = new frmFaktorSrece(this);
            this.cpu = cpu;
            this.cpu_igrac = cpu_igrac;
        }

        Random r = new Random();
        int rand_indeks_pitanja;
        int redosled_odgovora;
        bool provera;
        int rezultat;
        public int Rezultat { get { return rezultat; } set { rezultat *= value; } }
        public bool CPU { get { return cpu; } }
        public int Naredu { get { return naredu; } }
        void IzaberiPitanje()
        {
            if (naredu == 0) lblObavestenje.Text = "Prvi igrač je na redu: ";
            else if (naredu == 1) lblObavestenje.Text = "Drugi igrač je na redu: ";
            else lblObavestenje.Text = "Treći igrač je na redu: ";
            rand_indeks_pitanja = r.Next(pitanja.Count);
            while (iskoriscena_pitanja.Contains(rand_indeks_pitanja)) rand_indeks_pitanja = r.Next(pitanja.Count);
            iskoriscena_pitanja.Add(rand_indeks_pitanja);
            lblPitanje.Text = pitanja[rand_indeks_pitanja].TekstPitanja;
            redosled_odgovora = r.Next(3);
            if (redosled_odgovora == 0)
            { //a je tacno, b je netacan1, c je netacan2
                tbxOdgovor1.Text = pitanja[rand_indeks_pitanja].TacanOdgovor;
                tbxOdgovor2.Text = pitanja[rand_indeks_pitanja].Netacan1;
                tbxOdgovor3.Text = pitanja[rand_indeks_pitanja].Netacan2;
            }
            else if (redosled_odgovora == 1)
            {//a je netacan1, b je tacan, c je netacan2
                tbxOdgovor1.Text = pitanja[rand_indeks_pitanja].Netacan1;
                tbxOdgovor2.Text = pitanja[rand_indeks_pitanja].TacanOdgovor;
                tbxOdgovor3.Text = pitanja[rand_indeks_pitanja].Netacan2;
            }
            else
            {//a je netacan1, b je netacan2, c je tacan
                tbxOdgovor1.Text = pitanja[rand_indeks_pitanja].Netacan1;
                tbxOdgovor2.Text = pitanja[rand_indeks_pitanja].Netacan2;
                tbxOdgovor3.Text = pitanja[rand_indeks_pitanja].TacanOdgovor;
            }
        }
        private void frmPitanje_Load(object sender, EventArgs e)
        {
            //ucitava se forma pitanja i random se bira pitanje iz datoteke i ispisuje, random se redjaju oodgovori i pamti se koji je tacan;
            //ukoliko se izabere odgovor tacan ispisuje se cestitamo i objasnjenje
            provera = false;
            IzaberiPitanje();

            rezultat = 0;
            rbtnA.Enabled = true;
            rbtnB.Enabled = true;
            rbtnC.Enabled = true;
            btnDalje.Enabled = true;
            btnPredaj.Enabled = true;
            tbxOdgovor1.Enabled = false;
            tbxOdgovor2.Enabled = false;
            tbxOdgovor3.Enabled = false;
            // cpu igra
            if (naredu == 0 && cpu)
            {
                rbtnA.Enabled = false;
                rbtnB.Enabled = false;
                rbtnC.Enabled = false;
                btnDalje.Enabled = false;
                btnPredaj.Enabled = false;

                tmrCPU.Interval = 5000;
                tmrCPU.Enabled = true;
                tmrCPU.Start();
            }

            timer1.Interval = 20000;
            timer1.Enabled = true;
            timer1.Start();

        }

        private void btnPredaj_Click(object sender, EventArgs e)
        {
            ProveriPitanje();
        }
        void ProveriPitanje()
        {
            timer1.Stop();
            provera = true;
            if (rbtnA.Checked)
            {
                if (redosled_odgovora == 0)
                {
                    rezultat = 1;
                    frm_tacno.Show();
                    frm_tacno.LblTacno = pitanja[rand_indeks_pitanja].ObjasnjenjeTacnog;
                }
                else if (redosled_odgovora == 1)
                {
                    //netacan1
                    rezultat = -1;
                    frm_netacno.Show();
                    frm_netacno.LblNetacno = pitanja[rand_indeks_pitanja].ObjasnjenjeNetacnog1;
                    frm_netacno.LblTacno = pitanja[rand_indeks_pitanja].ObjasnjenjeTacnog;
                    frm_netacno.LblTacanOdg = pitanja[rand_indeks_pitanja].TacanOdgovor;
                }
                else
                {
                    rezultat = -1;
                    frm_netacno.Show();
                    frm_netacno.LblNetacno = pitanja[rand_indeks_pitanja].ObjasnjenjeNetacnog1;
                    frm_netacno.LblTacno = pitanja[rand_indeks_pitanja].ObjasnjenjeTacnog;
                    frm_netacno.LblTacanOdg = pitanja[rand_indeks_pitanja].TacanOdgovor;
                }//netacan1
            }
            else if (rbtnB.Checked)
            {
                if (redosled_odgovora == 0)
                {
                    //netacan1.Show
                    rezultat = -1;
                    frm_netacno.Show();
                    frm_netacno.LblNetacno = pitanja[rand_indeks_pitanja].ObjasnjenjeNetacnog1;
                    frm_netacno.LblTacno = pitanja[rand_indeks_pitanja].ObjasnjenjeTacnog;
                    frm_netacno.LblTacanOdg = pitanja[rand_indeks_pitanja].TacanOdgovor;

                }
                else if (redosled_odgovora == 1)
                {
                    //tacan
                    rezultat = 1;
                    frm_tacno.Show();
                    frm_tacno.LblTacno = pitanja[rand_indeks_pitanja].ObjasnjenjeTacnog;
                }
                else
                {
                    rezultat = -1;
                    frm_netacno.Show();
                    frm_netacno.LblNetacno = pitanja[rand_indeks_pitanja].ObjasnjenjeNetacnog2;
                    frm_netacno.LblTacno = pitanja[rand_indeks_pitanja].ObjasnjenjeTacnog;
                    frm_netacno.LblTacanOdg = pitanja[rand_indeks_pitanja].TacanOdgovor;
                }//netacan2
            }
            else if (rbtnC.Checked)
            {
                if (redosled_odgovora == 0)
                {
                    //netacan2.Show
                    rezultat = -1;
                    frm_netacno.Show();
                    frm_netacno.LblNetacno = pitanja[rand_indeks_pitanja].ObjasnjenjeNetacnog2;
                    frm_netacno.LblTacno = pitanja[rand_indeks_pitanja].ObjasnjenjeTacnog;
                    frm_netacno.LblTacanOdg = pitanja[rand_indeks_pitanja].TacanOdgovor;
                }
                else if (redosled_odgovora == 1)
                {
                    //netacan2
                    rezultat = -1;
                    frm_netacno.Show();
                    frm_netacno.LblNetacno = pitanja[rand_indeks_pitanja].ObjasnjenjeNetacnog2;
                    frm_netacno.LblTacno = pitanja[rand_indeks_pitanja].ObjasnjenjeTacnog;
                    frm_netacno.LblTacanOdg = pitanja[rand_indeks_pitanja].TacanOdgovor;
                }
                else
                {
                    rezultat = 1;
                    frm_tacno.Show();
                    frm_tacno.LblTacno = pitanja[rand_indeks_pitanja].ObjasnjenjeTacnog;

                }//tacan
            }
            else //isto sto i za neutral
            {
                rezultat = 0;
                frm_preskoceno_pitanje.Show();
                frm_preskoceno_pitanje.LblTacanOdg = pitanja[rand_indeks_pitanja].TacanOdgovor;
                frm_preskoceno_pitanje.LblObjasnjenjeTacnog = pitanja[rand_indeks_pitanja].ObjasnjenjeTacnog;
            }
            timer1.Interval = 5000;
            timer1.Enabled = true;
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timer1.Interval == 20000)
            {
                timer1.Stop();
                if (!provera)
                {
                    ProveriPitanje();
                }
            }
            else if (timer1.Interval == 5000)
            {
                timer1.Stop();
                Close();
                frm_netacno.Hide();
                frm_tacno.Hide();
                if (rezultat != 0) frm_faktorsrece.ShowDialog(); 
                else frm_preskoceno_pitanje.Hide();
            }

        }

        private void btnDalje_Click(object sender, EventArgs e)
        {
            rezultat = 0;
            frm_preskoceno_pitanje.Show();
            frm_preskoceno_pitanje.LblTacanOdg = pitanja[rand_indeks_pitanja].TacanOdgovor;
            frm_preskoceno_pitanje.LblObjasnjenjeTacnog = pitanja[rand_indeks_pitanja].ObjasnjenjeTacnog;

            timer1.Interval = 5000;
            timer1.Enabled = true;
            timer1.Start();
        }

        private void btnIzadjiPitanje_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Da li ste sigurni da želite da izađete? ", "Izađi", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes) Application.Exit();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tmrCPU_Tick(object sender, EventArgs e)
        {
            tmrCPU.Stop();
            int odg = cpu_igrac.CPUOdgovoriNaPitanje(pitanja[rand_indeks_pitanja].TacanOdgovor, tbxOdgovor1.Text, tbxOdgovor2.Text, tbxOdgovor3.Text);
            if (odg == 1)
            {
                rbtnA.Checked = true;
            }
            else if (odg == 2)
            {
                rbtnB.Checked = true;
            }
            else if (odg == 3)
            {
                rbtnC.Checked = true;
            }
            tmrCPU.Enabled = false;
            ProveriPitanje();
        }
    }
}
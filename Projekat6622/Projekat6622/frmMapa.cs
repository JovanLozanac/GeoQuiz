using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Projekat6622
{
    public partial class frmMapa : Form
    {
        frmPitanje frm_pitanje;
        frmPocetna frm_pocetna; // prethodna forma - info o igracima

        public frmMapa(frmPocetna frm_pocetna)
        {
            InitializeComponent();
            this.frm_pocetna = frm_pocetna;
        }
        Graphics g;
        #region putanje_atributi
        List<PointF> koordinate;
        List<string> imena_drzava;
        List<Putanja> putanje;
        List<Timer> tajmeri_putanja;
        #endregion
        #region igraci_atributi
        //Timer[] tajmeri_igraca;
        Igrac[] igraci;
        //PictureBox[] pbxIgraca;
        int broj_igraca;
        int interval_igraca;
        #endregion
        List<Pitanje> pitanja;
        static int naredu = 0;
        bool nije_kraj_igrice;
        #region vodjenje_igrice_atributi
        #endregion
        #region svojstva
        public List<Pitanje> ListaPitanja { get { return pitanja; } }
        //public Timer[] Tajmeri_igraca { get { return tajmeri_igraca; } }
        public Igrac[] Igraci { get { return igraci; } set { igraci = value; } }
        public int NaRedu { get { return naredu; } }
        #endregion
        int sirina = 25;
        int visina = 50;
        float debljina_olovke;
        void UcitajPitanja()
        {
            StreamReader ulaz_pitanja = new StreamReader("Pitanja.txt");
            pitanja = new List<Pitanje>();
            while (!ulaz_pitanja.EndOfStream)
            {
                string red = ulaz_pitanja.ReadLine();
                pitanja.Add(new Pitanje(red));
            }
            ulaz_pitanja.Close();
        }
        void Ucitaj_drzave()
        {
            StreamReader ulaz = new StreamReader("Koordinate_zemalja.txt");
            StreamReader ulaz2 = new StreamReader("Drzave_imena.txt");

            Random rndBoje = new Random();
            putanje = new List<Putanja>();

            tajmeri_putanja = new List<Timer>();
            Timer tmr;

            debljina_olovke = 3;
            while (!ulaz.EndOfStream)
            {
                koordinate = new List<PointF>();
                imena_drzava = new List<string>();

                tmr = new Timer();
                tmr.Enabled = false;
                tmr.Interval = 25;
                tajmeri_putanja.Add(tmr);

                string[] s = ulaz.ReadLine().Split(';');
                for (int i = 0; i < s.Length; i++)
                {
                    string[] el = s[i].Split(',');
                    if (el.Length == 2) koordinate.Add(new PointF(Convert.ToInt32(el[0]), Convert.ToInt32(el[1])));
                }

                s = ulaz2.ReadLine().Split('-');
                for (int i = 0; i < s.Length; i++)
                {
                    imena_drzava.Add(s[i]);
                }
                putanje.Add(new Putanja(koordinate, tajmeri_putanja[tajmeri_putanja.Count - 1], g, Color.FromArgb(rndBoje.Next(255), rndBoje.Next(255), rndBoje.Next(255)), debljina_olovke, imena_drzava));
            }
            ulaz.Close();
            ulaz2.Close();

        }
        void Formiraj_igrace()
        {
            igraci = new Igrac[frm_pocetna.Broj_igraca];
            //Random rnd_put = new Random(); // ideja?
            for (int i = 0; i < igraci.Length; i++)
            {
                if (frm_pocetna.CPU && i == 0) { igraci[i] = new CPU(frm_pocetna.Imena_igraca[i], new PictureBox(), frm_pocetna.Tezina, new Timer(), putanje[i]); }
                else igraci[i] = new Igrac(frm_pocetna.Imena_igraca[i], new PictureBox(), new Timer());
                //podesavanje tajmera***************************
                igraci[i].Tajmer.Interval = interval_igraca;
                //podesavanje PictureBoxa************************
                igraci[i].Slika_igraca = frm_pocetna.Slike_igraca[i]; // postavljanje slike igracu
                igraci[i].Pbx_igraca.Parent = pbxMapa;
                igraci[i].Pbx_igraca.Width = sirina;
                igraci[i].Pbx_igraca.Height = visina;
                igraci[i].Pbx_igraca.BackColor = Color.Transparent;
                igraci[i].Pbx_igraca.Visible = true;
                igraci[i].Pbx_igraca.SizeMode = PictureBoxSizeMode.Zoom;
                igraci[i].Pbx_igraca.BorderStyle = BorderStyle.Fixed3D;
                // dodeljivanje putanja igracima*****************
                igraci[i].Putanja = putanje[i];
            }
        }
        void Postavi_igrace()
        {
            foreach (Igrac i in igraci)
                i.Podesi_pocetnu_poziciju();
        }
        private void frmMapa_Load(object sender, EventArgs e)
        {

            g = pbxMapa.CreateGraphics();
            broj_igraca = frm_pocetna.Broj_igraca;
            interval_igraca = 10;

            // formiranje i postavljanje igraca na pocetne pozicije
            Ucitaj_drzave();
            UcitajPitanja();
            Formiraj_igrace();
            Postavi_igrace();
            Igrac.G = g;

            nije_kraj_igrice = true;
            Igraj();
        }
        void Ocuvaj_sve_putanje(int indeks_igraca, Graphics g)
        {
            // resava problem brisanja putanja ostalih igraca tokom iscrtavanja
            for (int i = 0; i < igraci.Length; i++)
            {
                if (i != indeks_igraca)
                {
                    if (igraci[i].Dosadasnja_putanja.Count > 1)
                    {
                        for (int j = 0; j < igraci[i].Dosadasnja_putanja.Count - 1; j++)
                        {
                            g.DrawLine(igraci[i].Olovka, igraci[i].Dosadasnja_putanja[j], igraci[i].Dosadasnja_putanja[j + 1]);
                        }
                    }
                }
            }
        }
        async void Igraj()
        {
            //frm_pitanje = new frmPitanje(pitanja, naredu);
            int rezultat;
            nije_kraj_igrice = true;
            while (nije_kraj_igrice)
            {
                if (naredu == broj_igraca) naredu = 0;
                if (frm_pocetna.CPU) frm_pitanje = new frmPitanje(pitanja, naredu, true, (CPU) igraci[0]);
                else frm_pitanje = new frmPitanje(pitanja, naredu, false);
                Hide();
                frm_pitanje.ShowDialog();
                Show();
                rezultat = frm_pitanje.Rezultat;

                if (rezultat > 0)
                {
                    for (int i = 0; i < rezultat; i++)
                    {
                        putanje[naredu].Iscrtaj_naredni_deo();
                        igraci[naredu].Pomeri_se_korak_unapred(); 
                    }
                } //idi vrednost puta unapred
                else if (rezultat < 0) //pomeri se unazad
                {
                    for (int i = 0; i > rezultat; i--)
                    {
                        putanje[naredu].Obrisi_prethodni_deo();
                        igraci[naredu].Pomeri_se_korak_unazad();
                    }
                }            
                await Task.Delay(3000);
                if (igraci[naredu].Pobednik) { ProglasiPobednika(naredu); nije_kraj_igrice = false; }
                naredu++;
            }
        }
        void ProglasiPobednika(int naredu)
        {
            frmRezultat frm_rezultat = new frmRezultat();
            if (naredu == 0) frm_rezultat.LblPobednik = "Igrač broj 1 je pobednik.";
            else if (naredu == 1) frm_rezultat.LblPobednik = "Igrač broj 2 je pobednik.";
            else if (naredu == 2) frm_rezultat.LblPobednik = "Igrač broj 3 je pobednik.";
            frm_rezultat.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Da li ste sigurni da želite da izađete? ", "Izađi iz igrice", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes) Application.Exit();


        }

        private void pbxMapa_Paint(object sender, PaintEventArgs e)
        {
            Ocuvaj_sve_putanje(naredu, e.Graphics);
        }
    }
}
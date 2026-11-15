using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Projekat6622
{
    public class Igrac : IAnimacija
    {
        #region atributi
        #region personalizacija
        string ime { get; set; }
        int trenutnoPolje { get; set; } //indeks koji pocinje od 1
        PictureBox pbxIgrac;
        #endregion
        #region animacija
        Timer tajmer;
        List<PointF> putanja;
        bool tajmer_flag = false;
        int trenutna_pozicija_brojac = 0;
        int pomerajX;
        int pomerajY;
        int x; // trenutna lokacija - koordinata x - centralni deo slike
        int y; // trenutna lokacija - koordinata y - centralni deo slike
        Point ciljna_tacka; // naredna tacka za pomeranje
        Point pocetna_tacka; // tacka sa koje se pomera
        Pen olovka;
        static Graphics g;
        List<PointF> dosadasnja_putanja;
        #endregion
        #endregion
        #region konstruktori
        public Igrac(string ime, PictureBox pbxIgrac = null, Timer tajmer = null, Putanja putanja_kretanja = null)
        {
            this.ime = ime;
            this.trenutnoPolje = 1;
            this.pbxIgrac = pbxIgrac;
            this.tajmer = tajmer;
            if (tajmer != null) this.tajmer.Tick += Tajmer_Tick;
            if (putanja != null)
            {
                putanja = putanja_kretanja.Koordinate;
                this.olovka = putanja_kretanja.Olovka;
            }
            if (pbxIgrac != null && putanja != null)
            {
                Point poz = Pretvori_PointF_u_Point(putanja[0]);
                x = poz.X; // koordinata centra slike
                y = poz.Y; // koordinata centra slike
                // podesavanje pozicije
                pbxIgrac.Left = x - pbxIgrac.Width / 2;
                pbxIgrac.Top = y - pbxIgrac.Height / 2;
                pocetna_tacka = poz;
            }

            dosadasnja_putanja = new List<PointF>();
        }

        #endregion
        #region svojstva
        public PictureBox Pbx_igraca { get { return pbxIgrac; } set { pbxIgrac = value; } }
        public Image Slika_igraca { get { return pbxIgrac.Image; } set { pbxIgrac.Image = value; } }
        public Timer Tajmer { get { return tajmer; } set { tajmer = value; tajmer.Tick += Tajmer_Tick; } }
        public Putanja Putanja { set { putanja = value.Koordinate; olovka = value.Olovka; } }
        public List<PointF> Koordinate { get { return putanja; } set { putanja = value; } }
        public Point Pocetna_tacka { get { return pocetna_tacka; } set { pocetna_tacka = value; } }
        public Point Ciljna_tacka { get { return ciljna_tacka; } set { ciljna_tacka = value; } }
        public Pen Olovka { get { return olovka; } set { olovka = value; } }
        static public Graphics G { get { return g; } set { g = value; } }
        public List<PointF> Dosadasnja_putanja { get { return dosadasnja_putanja; } }

        public bool Pobednik
        {
            get
            {
                if (trenutna_pozicija_brojac >= putanja.Count - 1) return true;
                return false;
            }
        }
        #endregion
        #region metode

        Point Pretvori_PointF_u_Point(PointF tackaF)
        {
            return new Point((int)Math.Round(tackaF.X), (int)Math.Round(tackaF.Y));
        }
        public void Pomeri_se_korak_unapred()
        {
            if (putanja == null) return;
            if (trenutna_pozicija_brojac == putanja.Count - 1) return;
            ciljna_tacka = Pretvori_PointF_u_Point(putanja[trenutna_pozicija_brojac + 1]);
            pocetna_tacka = Pretvori_PointF_u_Point(putanja[trenutna_pozicija_brojac]);

            dosadasnja_putanja.Add(ciljna_tacka);
            PomeriSe(ciljna_tacka, null);
        }
        public void Pomeri_se_korak_unazad()
        {
            if (putanja == null) return;
            if (trenutna_pozicija_brojac == 0) return;
            ciljna_tacka = Pretvori_PointF_u_Point(putanja[trenutna_pozicija_brojac - 1]);
            pocetna_tacka = Pretvori_PointF_u_Point(putanja[trenutna_pozicija_brojac]);

            dosadasnja_putanja.Remove(pocetna_tacka);
            PomeriSe(ciljna_tacka, null);
        }
        List<Point> Pretvori_PointF_listu_u_Point(List<PointF> lista)
        {
            List<Point> lista1 = new List<Point>(lista.Count);
            foreach (PointF tacka in lista)
            {
                lista1.Add(Pretvori_PointF_u_Point(tacka));
            }
            return lista1;
        }
        public void Podesi_pocetnu_poziciju()
        {
            if (pbxIgrac == null) return;
            if (putanja == null) return;

            Point poz = Pretvori_PointF_u_Point(putanja[0]);
            x = poz.X; // koordinata centra slike
            y = poz.Y; // koordinata centra slike
            // podesavanje pozicije
            pbxIgrac.Left = x - pbxIgrac.Width / 2;
            pbxIgrac.Top = y - pbxIgrac.Height / 2;
            pocetna_tacka = poz;
            //dosadasnja_putanja.Push(pocetna_tacka);
            dosadasnja_putanja.Add(pocetna_tacka);
        }
        void PomeriSe(Point ciljna_tacka, Nullable<Point> pocetna_tacka = null)
        {
            if (tajmer == null) return;
            if (g == null) return;
            if (olovka == null) return;

            this.ciljna_tacka = ciljna_tacka;
            if (x == this.ciljna_tacka.X && y == this.ciljna_tacka.Y)
            {
                // vec se nalazi na zadatoj poziciji
                return;
            }
            else
            {
                // podesavanje pomeraja
                if (this.ciljna_tacka.X > x) pomerajX = 1;
                else pomerajX = -1;
                if (this.ciljna_tacka.Y > y) pomerajY = 1;
                else pomerajY = -1;

                tajmer.Enabled = true;
                tajmer.Start();
                while (!tajmer_flag)
                    Application.DoEvents();
                tajmer.Enabled = false;
                tajmer_flag = false;
            }
        }

        private void Tajmer_Tick(object sender, EventArgs e)
        {
            tajmer.Stop();
            if (x == ciljna_tacka.X && y == ciljna_tacka.Y)
            {
                if (ciljna_tacka == Pretvori_PointF_u_Point(putanja[trenutna_pozicija_brojac + 1]))
                    trenutna_pozicija_brojac++; // pomerio se na sledecu tacku
                else if (ciljna_tacka == Pretvori_PointF_u_Point(putanja[trenutna_pozicija_brojac - 1]))
                    trenutna_pozicija_brojac--;
                tajmer_flag = true;
            }
            else
            {
                if (x != ciljna_tacka.X)
                {
                    pbxIgrac.Left += pomerajX;
                    x += pomerajX;
                }
                if (y != ciljna_tacka.Y)
                {
                    pbxIgrac.Top += pomerajY;
                    y += pomerajY;
                }
                for (int i = 0; putanja[i] != ciljna_tacka; i++)
                {
                    g.DrawLine(olovka, putanja[i], putanja[i + 1]);
                }
                tajmer.Enabled = true; // restartuje tajmer
            }
        }
        #endregion
    }
}
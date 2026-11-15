using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Projekat6622
{
    public class Putanja : IAnimacija
    {
        #region atributi
        List<PointF> koordinate;
        List<string> imena_drzava;
        int trenutna_t_brojac; // prati do koje je tacke stiglo iscrtavanje
        #region atributi_animacija
        Timer tajmer;
        bool tajmer_flag = false;
        Graphics g;
        Pen olovka;
        PointF t1, t2;
        double pomerajX; // pomeraj u pikselima koji se izvrsi na tik tajmera
        double pomerajY;
        PointF ciljna_tacka;
        PointF pocetna_tacka;
        #endregion
        #endregion
        #region konstruktori
        public Putanja(List<PointF> koordinate, Timer tajmer, Graphics g, Color boja, double debljina = 1, List<string> imena_drzava = null)
        {
            this.koordinate = koordinate;
            this.imena_drzava = imena_drzava;
            trenutna_t_brojac = 0;
            this.tajmer = tajmer;
            this.g = g;
            olovka = new Pen(boja, (float)debljina);
            tajmer.Tick += Tajmer_Tick;
        }
        #endregion
        #region svojstva
        public List<PointF> Koordinate { get { return koordinate; } set { koordinate = value; } }
        public List<string> ImenaDrzava { get { return imena_drzava; } set { imena_drzava = value; } }
        public Color Boja { get { return olovka.Color; } set { olovka = new Pen(value, olovka.Width); } }
        public Timer Tajmer { get { return tajmer; } }
        public Graphics G { get { return g; } set { g = value; } }
        public Pen Olovka { get { return olovka; } set { olovka = value; } }
        #endregion
        #region metode
        public void Iscrtaj(PointF pocetna_tacka, PointF ciljna_tacka, Graphics g = null)
        {

            if (g != null) this.g = g;

            if (trenutna_t_brojac < koordinate.Count - 1)
            {
                t1 = pocetna_tacka;

                t2.X = t1.X;
                t2.Y = t1.Y;
                tajmer.Enabled = true;
                pomerajX = (ciljna_tacka.X - pocetna_tacka.X) * 1.0 / tajmer.Interval;
                pomerajY = (ciljna_tacka.Y - pocetna_tacka.Y) * 1.0 / tajmer.Interval;

                t2.X += (float)pomerajX;

                t2.Y += (float)pomerajY;
                tajmer_flag = false;
                tajmer.Start();
                while (!tajmer_flag)
                    Application.DoEvents();
                tajmer.Enabled = false;
            }
        }
        public void Iscrtaj_naredni_deo()
        {
            if (trenutna_t_brojac >= koordinate.Count - 1) return;
            pocetna_tacka = koordinate[trenutna_t_brojac];
            ciljna_tacka = koordinate[trenutna_t_brojac + 1];
            Iscrtaj(pocetna_tacka, ciljna_tacka);
        }
        public void Obrisi_prethodni_deo()
        {
            if (trenutna_t_brojac == 0) return;
            trenutna_t_brojac--;
        }
        private void Tajmer_Tick(object sender, EventArgs e)
        {
            tajmer.Stop();
            if (Math.Round(t1.X) == Math.Round(ciljna_tacka.X) && Math.Round(t1.Y) == Math.Round(ciljna_tacka.Y))
            {
                // trenutna_t_brojac++;
                if (ciljna_tacka == koordinate[trenutna_t_brojac + 1]) trenutna_t_brojac++;
                //tajmer.Stop();
                //tajmer.Enabled = false;
                tajmer_flag = true;
                //tajmer.Enabled = false;
            }
            else
            {
                g.DrawLine(olovka, t1, t2);
                t1.X = t2.X;
                t1.Y = t2.Y;
                t2.X += (float)pomerajX;
                t2.Y += (float)pomerajY;
                //tajmer.Start();
                tajmer.Enabled = true; // restartuje tajmer
            }
        }
        #endregion
    }
}

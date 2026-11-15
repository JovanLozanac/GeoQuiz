using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Projekat6622
{
    public sealed class CPU : Igrac
    {
        int tezina { get; }

        /*tezina = 0: cpu pogadja 3/10 pitanja
        tezina = 1: cpu pogadja 6/10 pitanja
        tezina = 2: cpu pogadja 9/10 pitanja*/

        int brOdgovorenihPitanja { get; set; }
        int brTacnihOdgovora { get; set; }
        int[] tabelaZaOdgovaranje { get; set; }
        int indeksUTabeli { get; set; }

        /*Tabela za odgovaranje predstavlja niz od 10 nula. U taj niz se ubaci 3, 6 ili 9 jedinica na nasumicnim mestima,
    da ostanu 7, 4 ili 1 nula/e.
    Tu gde je jedinica po trenutnom indeksu koji se pamti, daje se tacan odgovor, a nula, netacan.
    Niz se opet prazni i puni jedinicama pre 1, 11, ... k * 10 + 1 odgovaranja.
    Na ovaj nacin se osigurava dobar, naizgled nasumican algoritam, nego sto je generisanje odluke pre svakog pitanja.*/
        public CPU(string ime, PictureBox slika, int tezina, Timer tajmer, Putanja putanja) : base(ime, slika, tajmer, putanja)
        {
            this.tezina = tezina;
            this.brOdgovorenihPitanja = 0;
            this.brTacnihOdgovora = 0;
            this.tabelaZaOdgovaranje = new int[10];
        }
        private void PopuniTabelu()
        {
            tabelaZaOdgovaranje = new int[10];
            int k;
            Random r = new Random();
            if (tezina == 0) k = 3;
            else if (tezina == 1) k = 6;
            else k = 9;
            int ran;
            for (int i = 0; i < k; i++)
            {
                ran = r.Next(0, 10);
                while (tabelaZaOdgovaranje[ran] == 1)
                {
                    ran = r.Next(0, 10);
                }
                tabelaZaOdgovaranje[ran] = 1;
            }
        }
        public int CPUOdgovoriNaPitanje(string TacanOdgovor, string odg1, string odg2, string odg3)
        {
            if (indeksUTabeli == 0) PopuniTabelu();
            int odgovor = tabelaZaOdgovaranje[indeksUTabeli++];
            if (indeksUTabeli == 10) indeksUTabeli = 0;
            //vraca redni broj odgovora na koji CPU klikce.
            if (odgovor == 1)
            {
                //tacan
                if (TacanOdgovor == odg1) return 1;
                else if (TacanOdgovor == odg2) return 2;
                return 3;
            }
            else
            {
                Random r = new Random();
                if (TacanOdgovor == odg1) return r.Next(2, 4);
                else if (TacanOdgovor == odg3) return r.Next(1, 3);
                else
                {
                    if (r.Next(1, 3) == 1) return 1;
                    return 3;
                }
            }
        }
    }
}
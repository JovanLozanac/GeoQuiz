using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekat6622
{
    public partial class frmFaktorSrece : Form
    {
        frmPitanje frm_pitanje;
        public frmFaktorSrece(frmPitanje frm_pitanje)
        {
            InitializeComponent();
            this.frm_pitanje = frm_pitanje;
        }
        int vrednost; //vrednost bi trebali da prosledimo glavnom programu
        bool kliknuto;
        Random r = new Random();
        Random r_cpu = new Random();
        int cpu_odg;
        //public int Vrednost{ get { return vrednost; } }
        private void frmFaktorSrece_Load(object sender, EventArgs e)
        {
            kliknuto = false;
            vrednost = 0;
            if (frm_pitanje.CPU && frm_pitanje.Naredu == 0)
            {
                cpu_odg = r_cpu.Next(1, 4);
                if (cpu_odg == 1)
                {
                    pbxGrb1_Click_1(sender, e);
                }
                else if (cpu_odg == 2)
                {
                    pbxGrb2_Click_1(sender, e);
                }
                else
                {
                    pbxGrb3_Click_1(sender, e);
                }
            }
        }


        void ZatvoriFormu()
        {
            timerFaktorSrece.Interval = 2000;
            timerFaktorSrece.Enabled = true;
            timerFaktorSrece.Start();

        }

        private void timerFaktorSrece_Tick(object sender, EventArgs e)
        {
            timerFaktorSrece.Stop();
            Close();
        }



        private void pbxGrb1_Click_1(object sender, EventArgs e)
        {
            if (!kliknuto)
            {
                kliknuto = true;
                vrednost = r.Next(1, 4);
                frm_pitanje.Rezultat = vrednost;
                if (vrednost == 1)
                {
                    pbxGrb1.Image = global::Projekat6622.Properties.Resources._1;

                }
                else if (vrednost == 2)
                {
                    pbxGrb1.Image = global::Projekat6622.Properties.Resources._2_png;
                }
                else
                {
                    pbxGrb1.Image = global::Projekat6622.Properties.Resources._3_png;
                }
            }
            ZatvoriFormu();
        }

        private void pbxGrb3_Click_1(object sender, EventArgs e)
        {
            if (!kliknuto)
            {
                kliknuto = true;
                vrednost = r.Next(1, 4);
                frm_pitanje.Rezultat = vrednost;
                if (vrednost == 1)
                {
                    pbxGrb3.Image = global::Projekat6622.Properties.Resources._1;

                }
                else if (vrednost == 2)
                {
                    pbxGrb3.Image = global::Projekat6622.Properties.Resources._2_png;
                }
                else
                {
                    pbxGrb3.Image = global::Projekat6622.Properties.Resources._3_png;
                }
            }
            ZatvoriFormu();
        }

        private void pbxGrb2_Click_1(object sender, EventArgs e)
        {
            if (!kliknuto)
            {
                kliknuto = true;
                vrednost = r.Next(1, 4);
                frm_pitanje.Rezultat = vrednost;
                if (vrednost == 1)
                {
                    pbxGrb2.Image = global::Projekat6622.Properties.Resources._1;

                }
                else if (vrednost == 2)
                {
                    pbxGrb2.Image = global::Projekat6622.Properties.Resources._2_png;
                }
                else
                {
                    pbxGrb2.Image = global::Projekat6622.Properties.Resources._3_png;
                }
            }
            ZatvoriFormu();
        }

        private void timerFaktorSrece_Tick_1(object sender, EventArgs e)
        {
            timerFaktorSrece.Stop();
            Close();
            //mora ponovo da se vrati u onu metodu sa mapom
        }

    }
}
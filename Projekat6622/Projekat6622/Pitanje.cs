using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat6622
{
    public class Pitanje
    {
        #region atributi
        string pitanje;
        string tacanodgovor;
        string netacan1;
        string netacan2;
        string objasnjenjetacnog;
        string objasnjenjenetacnog1;
        string objasnjenjenetacnog2;
        #endregion

        #region konstruktori
        public Pitanje(string red)
        {
            string[] niz = red.Split(';');
            pitanje = niz[0];
            tacanodgovor = niz[1];
            netacan1 = niz[2];
            netacan2 = niz[3];
            objasnjenjetacnog = niz[4];
            objasnjenjenetacnog1 = niz[5];
            objasnjenjenetacnog2 = niz[6];
        }
        public Pitanje(string pitanje, string tacanodgovor, string netacanodgovor1, string netacanodgovor2, string objasnjenjetacnog, string objasnjenjenetacnog1, string objasnjenjenetacnog2)
        {
            this.pitanje = pitanje;
            this.tacanodgovor = tacanodgovor;
            netacan1 = netacanodgovor1;
            netacan2 = netacanodgovor2;
            this.objasnjenjetacnog = objasnjenjetacnog;
            this.objasnjenjenetacnog1 = objasnjenjenetacnog1;
            this.objasnjenjenetacnog2 = objasnjenjenetacnog2;
        }
        #endregion

        #region svojstva
        public string TacanOdgovor { get { return tacanodgovor; } }
        public string Netacan1 { get { return netacan1; } }
        public string Netacan2 { get { return netacan2; } }
        public string TekstPitanja { get { return pitanje; } }
        public string ObjasnjenjeTacnog { get { return objasnjenjetacnog; } }
        public string ObjasnjenjeNetacnog1 { get { return objasnjenjenetacnog1; } }
        public string ObjasnjenjeNetacnog2 { get { return objasnjenjenetacnog2; } }
        #endregion
    }
}

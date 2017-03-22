using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv5 {
    class Autoradio {
        //NaladenyKmitocet a RadioZapnuto.Metody: NastavPredvolbu s argumenty cislo
        //a kmitocet(interně si předvolby ukládejte do privátního členu typu Dictionary<int, double>)
        //a metodu PreladNaPredvolbu s argumentem cislo(tato nastaví NaladenyKmitocet na
        //předem uloženou hodnotu z NastavPredvolbu).
        private Dictionary<int, double> predvolby = new Dictionary<int, double>();

        public bool RadioZapnuto { get; set; }
        public double NaladenyKmitocet { get; set; }

        public void NastavPredvolbu(int cislo, double kmitocet) {
            predvolby[cislo] = kmitocet;
        }

        public void PreladNaPredvolbu(int cislo) {
            if (!predvolby.ContainsKey(cislo)) {
                throw new Exception("Volba neexistuje");
            }
            NaladenyKmitocet =  predvolby[cislo];
        }

        public override string ToString() {
            string strpredvolby = "Predvolby: ";
            foreach (KeyValuePair<int, double> predvolba in predvolby) {
                strpredvolby += predvolba.Key.ToString() + ":" + predvolba.Value.ToString() + "\t";
            }
            return "radio zapnuto: " + RadioZapnuto.ToString() + "\n" +
                "naladeny kmitocet: " + NaladenyKmitocet.ToString() + "\n" +
                strpredvolby + "\n";
        }
        }
}

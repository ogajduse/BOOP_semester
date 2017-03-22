using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cv6 {
    public class Trojuhelnik : Objekt2D {
        private double _zakladna;
        private double _vyska;

        public Trojuhelnik(double vyska, double zakladna) {
            this.zakladna = zakladna;
            this.vyska = vyska;
        }

        public double zakladna {
            get {
                return _zakladna;
            }

            set {
                _zakladna = value;
            }
        }

        public double vyska {
            get {
                return _vyska;
            }

            set {
                _vyska = value;
            }
        }

        public override double SpoctiPlochu() {
            return zakladna * vyska / 2;
        }

        public override void Kresli() {
            Console.WriteLine("Trojuhelnik {0}", SpoctiPlochu());
        }
    }
}
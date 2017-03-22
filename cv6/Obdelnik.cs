using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cv6 {
    public class Obdelnik : Objekt2D {
        private double _a;
        private double _b;

        public Obdelnik(double a, double b) {
            this.a = a;
            this.b = b;
        }

        public double b {
            get {
                return _b;
            }

            set {
                _b = value;
            }
        }

        public double a {
            get {
                return _a;
            }

            set {
                _a = value;
            }
        }

        public override double SpoctiPlochu() {
            return a * b;
        }

        public override void Kresli() {
            Console.WriteLine("Obdelnik: {0}", SpoctiPlochu());
        }
    }
}
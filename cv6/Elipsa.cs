using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cv6 {
    public class Elipsa : Objekt2D {
        private double _a;
        private double _b;

        public Elipsa(double a, double b) {
            this.a = a;
            this.b = b;
        }

        public double a {
            get {
                return _a;
            }

            set {
                _a = value;
            }
        }

        public double b {
            get {
                return _b;
            }

            set {
                _b = value;
            }
        }

        public override void Kresli() {
            Console.WriteLine("Elipsa {0} ", SpoctiPlochu());
        }

        public override double SpoctiPlochu() {
            return a * b * Math.PI;
        }
    }
}
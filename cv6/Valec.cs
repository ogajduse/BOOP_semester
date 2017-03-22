using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cv6 {
    public class Valec : Objekt3D {
        private double _polomer;
        private double _vyska;

        public Valec(double polomer, double vyska) {
            this.polomer = polomer;
            this.vyska = vyska;
        }

        public double vyska {
            get {
                return _vyska;
            }

            set {
                _vyska = value;
            }
        }

        public double polomer {
            get {
                return _polomer;
            }

            set {
                _polomer = value;
            }
        }

        public override double SpoctiObjem() {
            return Math.PI * Math.Pow(polomer, 2) * vyska;
        }

        public override double SpoctiPovrch() {
            return 2 * Math.PI * Math.Pow(polomer, 2) + 2 * Math.PI * polomer * vyska;
        }

        public override void Kresli() {
            Console.WriteLine("Valec {0} {1}", SpoctiObjem(), SpoctiPovrch());
        }
    }
}
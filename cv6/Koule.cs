using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cv6 {
    public class Koule : Objekt3D {
        private double _polomer;

        public Koule(double polomer) {
            this.polomer = polomer;
        }

        public double polomer {
            get {
                return _polomer;
            }

            set {
                _polomer = value;
            }
        }

        public override void Kresli() {
            Console.WriteLine("Koule {0}, {1}", SpoctiObjem(), SpoctiPovrch());
        }

        public override double SpoctiObjem() {
            return 4 / 3 * Math.PI * Math.Pow(polomer, 3);
        }

        public override double SpoctiPovrch() {
            return 4 * Math.PI * Math.Pow(polomer, 2);
        }
    }
}
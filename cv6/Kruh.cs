using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cv6 {
    public class Kruh : Objekt2D {
        private double _polomer;

        public Kruh(double polomer) {
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
            Console.WriteLine("Kruh {0}", SpoctiPlochu());
        }

        public override double SpoctiPlochu() {
            return 2 * Math.PI * polomer;
        }
    }
}
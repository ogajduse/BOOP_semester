using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv7 {
    class Elipsa : Objekt2D {
        private double v1;
        private double v2;

        public Elipsa(double v1, double v2) {
            this.v1 = v1;
            this.v2 = v2;
        }

        public override double Plocha() {
            return Math.PI * v1 * v2;
        }

        public override string ToString() {
            return "Elipsa: strana1 " + v1  + " strana2: " + v2 + " plocha: " + Plocha();
        }
    }
}

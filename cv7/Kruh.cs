using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv7 {
    class Kruh : Objekt2D {
        private double v;

        public Kruh(double v) {
            this.v = v;
        }

        public override double Plocha() {
            return Math.PI * Math.Pow(v, 2);
        }

        public override string ToString() {
            return "kruh: strana " + v + " plocha: " + Plocha();
        }
    }
}

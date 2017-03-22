using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv7 {
    class Ctverec : Objekt2D {
        private double v;

        public Ctverec(double v) {
            this.v = v;
        }

        public override double Plocha() {
            return Math.Pow(v, 2);
        }

        public override string ToString() {
            return "Ctverec: strana " + v + " plocha: " + Plocha();
        }
    }
}

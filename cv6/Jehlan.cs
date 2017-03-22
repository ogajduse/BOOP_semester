using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cv6 {
    public class Jehlan : Objekt3D {
        private double _a;
        private double _vyska;

        public Jehlan(double a, double vyska) {
            this.a = a;
            this.vyska = vyska;
        }

        public double a {
            get {
                return _a;
            }

            set {
                _a = value;
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

        public override void Kresli() {
            Console.WriteLine("Jehlan {0} {1}", SpoctiObjem(), SpoctiPovrch());
        }

        public override double SpoctiObjem() {
            return 1 / 3 * a * a * vyska;
        }

        public override double SpoctiPovrch() {
            return Math.Pow(a, 2) + 4 * 1 / 2 * a * vyska;
        }
    }
}
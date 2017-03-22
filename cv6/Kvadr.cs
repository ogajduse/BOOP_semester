using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cv6 {
    public class Kvadr : Objekt3D {
        private double _a;
        private double _b;
        private double _c;

        public Kvadr(double a, double b, double c) {
            this.a = a;
            this.b = b;
            this.c = c;
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

        public double c {
            get {
                return _c;
            }

            set {
                _c = value;
            }
        }

        public override void Kresli() {
            Console.WriteLine("Kvadr {0} {1}", SpoctiObjem(),SpoctiPovrch());
        }

        public override double SpoctiObjem() {
            return a * b * c;
        }

        public override double SpoctiPovrch() {
            return a * b + b * c + c * a;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv7 {
    public abstract class Objekt2D : I2D, IComparable {
        public int CompareTo(object obj) {
            Objekt2D otherSurface = ((Objekt2D)obj);

            if (otherSurface.Plocha() < Plocha()) {
                return 1;
            }
            if(otherSurface.Plocha() > Plocha()) {
                return -1;
            }
            else {
                return 0;
            }
        }

        public abstract double Plocha();

    }
}

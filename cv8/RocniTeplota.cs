using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv8 {
    class RocniTeplota {
        public int Rok { get; set; }
        public List<double> MesicniTeploty { get; set; }

        public RocniTeplota() {

        }

        public double MaxTeplota {
            get {
                return MesicniTeploty.Max();
            }
        }

        public double MinTeplota {
            get {
                return MesicniTeploty.Min();
            }
        }

        public double PrumernaRocniTeplota {
            get {
                return MesicniTeploty.Average();
            }
        }
    }
}

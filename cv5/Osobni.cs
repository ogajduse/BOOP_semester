using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv5 {
    class Osobni : Auto {
        private int prepravovaneosoby;
        public int MaxOsob { get; protected set; }
        public int PrepravovaneOsoby {
            get {
                return prepravovaneosoby;
            }
            set {
                if (value > MaxOsob) {
                    throw new Exception("Prilis mnoho cestujicich");
                }
                else prepravovaneosoby = value;
            }
        }

        public Osobni(TypPaliva Palivo, double VelikostNadrze, int MaxOsob, double StavNadrze = 0, bool radio = false) : base(Palivo, VelikostNadrze, StavNadrze, radio) {
            this.Palivo = Palivo;
            this.VelikostNadrze = VelikostNadrze;
            this.MaxOsob = MaxOsob;

        }

        public override string ToString() {
            return base.ToString() +
                "max. osob: " + MaxOsob.ToString() + "\n" +
                "prepravovane osoby: " + prepravovaneosoby.ToString() + "\n";
        }
    }
}

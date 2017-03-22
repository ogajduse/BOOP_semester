using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv5 {
    class Nakladni : Auto {
        private double prepravovanynaklad;
        public double MaxNaklad { get; protected set; }
        public double PrepravovanyNaklad {
            get {
                return prepravovanynaklad;
            }
            set {
                if (value > MaxNaklad) {
                    throw new Exception("Prilis mnoho nakladu");
                }
                else prepravovanynaklad = value;
            }
        }

        public Nakladni(TypPaliva Palivo, double VelikostNadrze, int MaxNaklad, double StavNadrze = 0, bool radio = false) : base(Palivo, VelikostNadrze, StavNadrze, radio) {
            this.Palivo = Palivo;
            this.VelikostNadrze = VelikostNadrze;
            this.MaxNaklad = MaxNaklad;
        }

        public override string ToString() {
            return base.ToString() +
                "max. naklad: " + MaxNaklad.ToString() + "\n" +
                "prepravovany naklad: " + prepravovanynaklad.ToString() + "\n";
        }
    }
}

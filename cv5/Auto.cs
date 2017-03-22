using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv5 {
    class Auto {
        public enum TypPaliva {
            Benzin = 0, Nafta
        }
        public double StavNadrze { get; protected set; }
        public double VelikostNadrze { get; protected set; }
        public TypPaliva Palivo { get; protected set; }
        public Autoradio radio;
        private bool MaRadio;


        public Auto(TypPaliva Palivo, double VelikostNadrze, double StavNadrze = 0, bool radio = false) {
            this.Palivo = Palivo;
            this.VelikostNadrze = VelikostNadrze;
            this.StavNadrze = StavNadrze;

            if (radio) {
                this.radio = new Autoradio();
                MaRadio = true;
            }
        }

        public void Natankuj(TypPaliva typPaliva, double mnozstvi) {

            if (typPaliva != Palivo) {
                throw new Exception("Benzin do dieselu nebo diesel do benzinu, no to me podrz!");
            }
            if (mnozstvi + StavNadrze > VelikostNadrze) {
                throw new Exception("Netankuj, pretece ti nadrz!");
            }
            StavNadrze += mnozstvi;

        }

        public override string ToString() {
            string basicout = "velikost nadrze: " + VelikostNadrze.ToString() + "\n" +
                "stav nadrze: " + StavNadrze.ToString() + "\n" +
                "typ paliva: " + Palivo.ToString() + "\n" +
                "autoradio: " + MaRadio.ToString() + "\n";
            if (MaRadio) {
                return basicout + radio.ToString();
            }
            else{
                return basicout;
            }
        }
    }
}

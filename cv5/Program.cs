using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv5 {
    class Program {
        static void Main(string[] args) {
            Osobni o1 = new Osobni(Auto.TypPaliva.Benzin, 60, 5, 45, true);
            Osobni o2 = new Osobni(Auto.TypPaliva.Nafta, 70, 7, 68);

            Nakladni n1 = new Nakladni(Auto.TypPaliva.Nafta, 150.5, 10, 10);
            Nakladni n2 = new Nakladni(Auto.TypPaliva.Nafta, 110.25, 5, 10, true);

            Console.WriteLine("osobni1:\n" + o1.ToString());

            o1.radio.RadioZapnuto=true;
            o1.radio.NastavPredvolbu(1, 100.5);
            o1.radio.PreladNaPredvolbu(1);
            try {
                o1.radio.PreladNaPredvolbu(2);
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }
            o1.Natankuj(Auto.TypPaliva.Benzin, 10);

            try {
                o1.Natankuj(Auto.TypPaliva.Benzin, 10);
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }

            try {
                o1.Natankuj(Auto.TypPaliva.Nafta, 1);
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine(o1.ToString());

            Console.ReadLine();


        }
    }
}

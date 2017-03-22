using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv6 {
    class Program {
        static void Main(string[] args) {
            double celkovyObsah = 0, celkovyPovrch = 0, celkovyObjem = 0;
            GrObjekt[] objekty =
            {
                new Kruh(2), new Obdelnik(2, 2), new Trojuhelnik(2, 2), new Elipsa(2, 2),
                new Kvadr(2, 2, 2), new Koule(2), new Jehlan(2, 2), new Valec(2, 2)
            };
            for (int i = 0; i < 7; ++i) {
                if (objekty[i] != null && objekty[i] is Objekt2D)
                    celkovyObsah += ((Objekt2D)objekty[i]).SpoctiPlochu();
                else if (objekty[i] != null) {
                    celkovyPovrch += ((Objekt3D)objekty[i]).SpoctiPovrch();
                    celkovyObjem += ((Objekt3D)objekty[i]).SpoctiObjem();
                }
            }
            foreach (var obj in objekty) {
                obj.Kresli();
            }
            Console.WriteLine("Celkovy obsah: {0}\ncelkovy povrch: {1}\ncelkovy objem: {2}", celkovyObsah, celkovyPovrch, celkovyObjem);
            Console.ReadLine();
        }
    }
}

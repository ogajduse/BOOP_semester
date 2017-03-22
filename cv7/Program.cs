using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv7 {
    class Program {
        static void Main(string[] args) {
            int[] poleInt = { 1, 3, 4, 7, 9 };
            Kruh[] poleKruh = { new Kruh(12.0), new Kruh(4.0), new Kruh(2.0) };
            Ctverec[] poleCtverec = { new Ctverec(2.0), new Ctverec(18.0), new Ctverec(5.0) };
            Elipsa[] poleElipsa = { new Elipsa(2.0, 4.0), new Elipsa(10.0, 2.0), new Elipsa(1.0, 5.0) };
            Obdelnik[] poleObdelnik = { new Obdelnik(1.0, 4.0), new Obdelnik(8.0, 2.0), new Obdelnik(2.0, 5.0) };
            Trojuhelnik[] poleTrojuhelnik = { new Trojuhelnik(11.0, 4.0), new Trojuhelnik(16.0, 6.0), new Trojuhelnik(10.0, 1.0) };
            Objekt2D[] poleObjekt2D = { new Kruh(2.0), new Ctverec(10.0), new Elipsa(1.0, 5.0), new Obdelnik(8.0, 2.0), new Trojuhelnik(20.0, 6.0) };

            Console.WriteLine("Nejvetsi int: {0}", Extremy.Nejvetsi(poleInt));
            Console.WriteLine("Nejmensi int: {0}", Extremy.Nejmensi(poleInt));

            Console.WriteLine("Nejvetsi kruh: {0}", Extremy.Nejvetsi(poleKruh));
            Console.WriteLine("Nejmensi kruh: {0}", Extremy.Nejmensi(poleKruh));

            Console.WriteLine("Nejvetsi ctverec: {0}", Extremy.Nejvetsi(poleCtverec));
            Console.WriteLine("Nejmensi ctverec: {0}", Extremy.Nejmensi(poleCtverec));

            Console.WriteLine("Nejvetsi elipsa: {0}", Extremy.Nejvetsi(poleElipsa));
            Console.WriteLine("Nejmensi elipsa: {0}", Extremy.Nejmensi(poleElipsa));

            Console.WriteLine("Nejvetsi obdelnik: {0}", Extremy.Nejvetsi(poleObdelnik));
            Console.WriteLine("Nejmensi obdelnik: {0}", Extremy.Nejmensi(poleObdelnik));


            Console.WriteLine("Nejvetsi trojuhelnik: {0}", Extremy.Nejvetsi(poleTrojuhelnik));
            Console.WriteLine("Nejmensi trojuhelnik: {0}", Extremy.Nejmensi(poleTrojuhelnik));

            Console.WriteLine("Nejvetsi Objekt2D: {0}", Extremy.Nejvetsi(poleObjekt2D));
            Console.WriteLine("Nejmensi Objekt2D: {0}", Extremy.Nejmensi(poleObjekt2D));

            int[] poleInt2 = { 1, 3, 5, 7, 9 };


            List<int> intList = new List<int>(new int[] { 1, 3, 5, 7, 9 });

            var res = from p in intList where (p > 4 && p < 8) select p;
            foreach (int i in res) {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}

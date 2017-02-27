using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv3 {
    class spustitelna {
        static void Main(string[] args) {
            double[,] douA = { { 2, 3, 6 }, { 9, 5, 1 }, { 2, 7, 4 } };
            double[,] douB = { { 2, 3, 6 }, { 9, 5, 1 }, { 2, 7, 4 } };
            double[,] douC = { { 4, 7, 2 }, { 1, 7, 1 }, { 2, 5, 9 } };

            Matrix a = new Matrix(douA);
            Matrix b = new Matrix(douB);
            Matrix c = new Matrix(douC);

            Console.WriteLine("A =\n" + a.ToString());
            Console.WriteLine("B =\n" + b.ToString());
            Console.WriteLine("C =\n" + c.ToString());

            Matrix v1 = a - b;
            Console.WriteLine("a - b =\n" + v1.ToString());
            Matrix v2 = -a;
            Console.WriteLine("-a =\n" + v2.ToString());
            Matrix v3 = b + c;
            Console.WriteLine("b+c =\n" + v3.ToString());
            Matrix v4 = c * b;
            Console.WriteLine("c*b =\n" + v3.ToString());

            Console.WriteLine("determinant a: " + a.GetDeterminant().ToString());

            Console.ReadLine();
        }

    }
}

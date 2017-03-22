using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv7 {
    class Extremy {
        public static T Nejvetsi<T>(T[] pole) where T : IComparable {
            T min;
            try {
                min = pole[0];
            }
            catch (NullReferenceException e) {
                Console.WriteLine(e.Message);
                return default(T);
            }

            for (int i = 0; i < pole.Length; i++) {
                if (min.CompareTo(pole[i]) < 0) min = pole[i];
            }

            return min;
        }

        public static T Nejmensi<T>(T[] pole) where T : IComparable {
            T min;
            try {
                min = pole[0];
            }
            catch (NullReferenceException e) {
                Console.WriteLine(e.Message);
                return default(T);
            }

            for (int i = 0; i < pole.Length; i++) {
                if (min.CompareTo(pole[i]) > 0) min = pole[i];
            }

            return min;
        }
    }
}

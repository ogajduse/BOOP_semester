using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv4 {
    class Program {
        static void Main(string[] args) {
            string testInput = "Toto je retezec predstavovany nekolika radky,\n" +
                "ktere jsou od sebe oddeleny znakem LF (Line Feed).\n" +
                "Je tu i nejaky ten vykricnik! Pro ucely testovani i otaznik?\n"
                + "Toto je jen zkratka zkr. ale ne konec vety. A toto je\n"
                + "posledni veta!";

            Console.WriteLine(testInput + "\n");
            StringStatistics a = new StringStatistics(testInput);

            Console.WriteLine("Count of words: {0}", a.getWordsCount());

            Console.WriteLine("Count of lines: {0}", a.getLineCount());

            Console.WriteLine("Count of sentences: {0}", a.getSentenceCount());

            Console.WriteLine("Longest words: {0}", a.getLongestWords());

            Console.WriteLine("Shortest words: {0}", a.getShortestWords());

            Console.WriteLine("Most frequent words: {0}", a.getMostFrequentWords());

            Console.WriteLine("Input sorted alphabetically: {0}", a.getSortedAlpha());

            Console.ReadLine();

        }
    }
}

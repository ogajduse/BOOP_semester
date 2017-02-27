using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace cv4 {
    class StringStatistics {
        private string content;
        private readonly char[] delimiters = { ' ', '\r', '\n' };

        public StringStatistics(string input) {
            this.content = input;
        }

        public int getWordsCount() {
            char[] delimiters = new char[] { ' ', '\r', '\n' };
            return this.content.Split(delimiters, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public int getLineCount() {
            return this.content.Split('\n').Length;
        }

        public int getSentenceCount() {
            return Regex.Matches(content, "[^?!.][?!.] *[\\n]*[A-Z]", RegexOptions.Multiline).Count + 1;
        }

        public string getLongestWords() { //najde jen jedno slovo, ne dve nejdelsi
            char[] delimiters = new char[] { ' ', '\r', '\n' };
            string[] wordArray = content.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            var sorted = wordArray.OrderBy(n => n.Length);
            var longest = sorted.LastOrDefault();
            string result = "";
            foreach (var word in sorted)
                if (word.Length == longest.Length)
                    result += String.Join(", ", word);                
            return result;
        }

        public string getShortestWords() {
            char[] delimiters = new char[] { ' ', '\r', '\n' };
            string[] wordArray = content.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            var sorted = wordArray.OrderBy(n => n.Length);
            var shortest = sorted.FirstOrDefault();
            string result = "";
            foreach (var word in sorted)
                if (word.Length == shortest.Length)
                    result += String.Join(", ", word);
            return result;
        }

        public string[] getMostFrequentWords() {
            char[] delimiters = new char[] { ' ', '\r', '\n' };
            var nameGroup = this.content.Split(delimiters, StringSplitOptions.RemoveEmptyEntries).GroupBy(x => x);
            var maxCount = nameGroup.Max(g => g.Count());
            return nameGroup.Where(x => x.Count() == maxCount).Select(x => x.Key).ToArray();
        }

        public string getSortedAlpha() {
            List<string> wordlist = new List<string>();
            char[] delimiters = new char[] { ' ', '\r', '\n' , ')', '('};
            wordlist = content.Split(delimiters, StringSplitOptions.RemoveEmptyEntries).ToList();
            wordlist.Sort();
            return string.Join(" ", wordlist);
        }
    }
}

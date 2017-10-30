using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulationLibrary
{
    public class FindMatchingWords
    {
        //Find matching words from a text after the specied string
        public List<string> Find(string text, string word)
        {
            var increment = 0;
            const int WhiteSpace = 1;
            var foundWords = new List<string>();

            if (string.IsNullOrWhiteSpace(text) || string.IsNullOrWhiteSpace(word))
                return foundWords;

            while (true)
            {
                var wordIndex = text.IndexOf(word, increment, StringComparison.Ordinal);
                if (wordIndex == -1) break;
                var wordStart = wordIndex + word.Length + WhiteSpace;
                var wordEnd = text.IndexOf(" ", wordStart, StringComparison.Ordinal);
                var wordLength = wordEnd - wordStart;
                foundWords.Add(text.Substring(wordStart, wordLength));
                increment = wordEnd + 1;
            }
            return foundWords;
        }
    }
}

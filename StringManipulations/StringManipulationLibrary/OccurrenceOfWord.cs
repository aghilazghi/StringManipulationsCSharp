using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulationLibrary
{
    public class OccurrenceOfWord
    {
        public int Occurrence(string text, string word)
        {
            if (string.IsNullOrWhiteSpace(text) || string.IsNullOrWhiteSpace(word))
                return 0;

            var splittedText = text
                            .Split(new[] { '.', '?', '!', ' ', ';', ':', ',' }, 
                            StringSplitOptions.RemoveEmptyEntries);
            var words = splittedText
                    .Where(w => string.Equals(w, word, StringComparison.OrdinalIgnoreCase));
            var wordCount = words.Count();

            return wordCount;
        }
    }
}

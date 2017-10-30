using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulationLibrary
{
    public class CountingNumberOfWords
    {
        public int Count(string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return 0;
            /*
             // using regular expression
              var wordCount = Regex.Matches(input, @"\b[A-Za-z0-9]+\b").Count;
            */
            var words = input.Split(new[] { '.', '?', '!', ' ', ';', ':', ',' }, StringSplitOptions.RemoveEmptyEntries);
            var wordCount = words.Length;

            return wordCount;
        }
    }
}

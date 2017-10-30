using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulationLibrary
{
    public class Anagrams
    {
        public bool AreAnagrams(string firstWord, string secondWord)
        {
            if (string.IsNullOrWhiteSpace(firstWord) || string.IsNullOrWhiteSpace(secondWord))
                return false;

            if (firstWord.Length != secondWord.Length) return false;

            var firstWordCharsFrequencies = new Dictionary<char, int>();

            foreach (var item in firstWord.ToLower())
            {
                if (!firstWordCharsFrequencies.ContainsKey(item)) firstWordCharsFrequencies[item] = 0;
                firstWordCharsFrequencies[item]++;
            }

            foreach (var item in secondWord.ToLower())
            {
                if (!firstWordCharsFrequencies.ContainsKey(item)) return false;
                firstWordCharsFrequencies[item]--;
            }
            return firstWordCharsFrequencies.Values.All(c => c == 0);
        }
    }
}

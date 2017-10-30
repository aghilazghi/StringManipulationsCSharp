using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulationLibrary
{
    public class ReplaceVowels
    {
        //Replace vowels in a string with $ sign
        public string Replace(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return string.Empty;

            var result = string.Empty;

            foreach (var ch in input.ToLower())
            {
                if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
                    result += "$";
                else
                    result += ch;
            }

            if (StartWithUpper(input))
                return char.ToUpper(result[0]) + result.Substring(1);

            return result;
        }

        public bool StartWithUpper(string word)
        {
            return Enumerable.Range(65, 26).Contains((int) word[0]);
        }
    }
}

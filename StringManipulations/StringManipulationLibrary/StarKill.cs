using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulationLibrary
{
    public class StarKill
    {
        /*
         * Return a version of the given string, where for every star (*) character
         * in the string, chars immediately to the left and right of a star
         * are gone. If the input string has a leading or trailing star, returns the input string
         * without modification.
         */
        public string Kill(string input)
        {
            if (string.IsNullOrWhiteSpace(input) ||
                input[0] == '*' ||
                input[input.Length - 1] == '*')
            {
                return input;
            }

            var result = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                if (i == 0 && input[i] != '*')
                    result += input[i];
                if (i > 0 && input[i] != '*' && input[i - 1] != '*')
                    result += input[i];
                if (i > 0 && input[i] == '*' && input[i - 1] != '*')
                    result = result.Substring(0, result.Length - 1) + "*";
                if (i > 0 && input[i] == '*' && input[i - 1] == '*')
                    result += "*";
            }

            return result;
        }
    }
}

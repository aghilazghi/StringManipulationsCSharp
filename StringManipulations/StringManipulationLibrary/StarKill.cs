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
         * in the string the star and chars immediately to its left and right
         * are gone. Star cannot be placed in the beginning or in the end.
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

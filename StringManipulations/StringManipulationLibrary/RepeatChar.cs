using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulationLibrary
{
    public class RepeatChar
    {
        /*
         * Given a string, return a string where for every character in 
         * the original append similar char
         * For example: Repeat("The") --> TThhee
         */
        public string Repeat(string input)
        {
            var result = string.Empty;

            for(var i = 0; i < input.Length; i++)
            {
                result += input.Substring(i, 1) + input.Substring(i, 1);
            }
            return result;
        }
    }
}

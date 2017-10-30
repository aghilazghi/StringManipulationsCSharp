using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulationLibrary
{
    public class ReverseString
    {
        public string Reverse(string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return "Your entry is invalid";

            if (input.Length == 1) return input;

            var reversedInput = new char[input.Length];
            var inputLastIndex = input.Length - 1;

            foreach (var ch in input)
            {
                reversedInput[inputLastIndex--] = ch;
            }

            return new string(reversedInput);
        }
    }
}

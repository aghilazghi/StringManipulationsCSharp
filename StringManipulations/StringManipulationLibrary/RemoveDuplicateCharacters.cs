using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulationLibrary
{
    public class RemoveDuplicateCharacters
    {
        public string Remove(string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return "Your entry is invalid";

            var result = string.Empty;

            foreach (var item in input.ToLower())
            {
                if (result.IndexOf(item) == -1) result += item;
            }
            return char.ToUpper(result[0]) + result.Substring(1);
        }
    }
}

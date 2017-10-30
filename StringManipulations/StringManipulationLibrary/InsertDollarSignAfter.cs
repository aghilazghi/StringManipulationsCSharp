using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulationLibrary
{
    public class InsertDollarSignAfter
    {
        //Insert a dollar sign after each character of an input word but the last one recursively
        public string Insert(string inputWord)
        {
            if (string.IsNullOrWhiteSpace(inputWord)) return string.Empty;

            if (inputWord.Length <= 1) return inputWord;

            return inputWord[0] + "$" + Insert(inputWord.Substring(1));
        }
    }
}

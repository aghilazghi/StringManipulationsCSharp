using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulationLibrary
{
    public class WordLength
    {
        /*
         * Find a length of each word in a sentence
         */

        public List<int> Count(string sentence)
        {
            var wordLength = sentence.Split().Select(w => w.Length).ToList();
            return wordLength;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulationLibrary
{
    public class WordsCount
    {
        /* Given an array of strings, return the count 
         * the number of strings with the given length
         */
        public int Count(string[] input, int len)
        {
           
            var count = 0;

            if (IsNullOrEmpty(input) || len < 1)
            {
                return count;
            }

            foreach (var item in input)
            {

                if (item.Length == len)
                    count++;
            }
            /* using LINQ
                var count = input.Count(temp => temp.Length == len);
                return count;
           */

            return count;
        }

        public bool IsNullOrEmpty(string[] array)
        {
            if (array == null || array.Length == 0)
                return true;
            return array.All(item => item == null || item == " ");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulationLibrary
{
    public class WordWithLength
    {
        /* Find a length of each word in a sentence and return 
         * the word and its length
         */
        public List<WordLenMx> Count(string sentence)
        {
            if (string.IsNullOrWhiteSpace(sentence))
                return Enumerable.Empty<WordLenMx>().ToList();

            List<WordLenMx> wordsWithLength = sentence.Split()
                                    .Select(w => new WordLenMx
                                    {
                                        Word = w,
                                        Count = w.Length
                                    }).ToList();

            return wordsWithLength;
        }
    }

    public class WordLenMx
    {
        public string Word { get; set; }
        public int Count { get; set; }

        public override bool Equals(object obj)
        {
            WordLenMx other = obj as WordLenMx;
            if (other == null)
            {
                return false;
            }
            return (this.Word == other.Word) && (this.Count == other.Count);
        }

        public override int GetHashCode()
        {
            return 33 * Word.GetHashCode() + Count.GetHashCode();
        }
    }
}

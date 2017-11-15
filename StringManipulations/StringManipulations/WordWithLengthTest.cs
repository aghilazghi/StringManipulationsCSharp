using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringManipulationLibrary;
using System.Collections.Generic;
using System.Linq;

namespace StringManipulations
{
    [TestClass]
    public class WordWithLengthTest
    {
        [TestMethod]
        public void Count_Expected_This_is_a_sentence()
        {
            var wordWithLen = new WordWithLength();
            var expected = new List<WordLenMx>()
            {
                new WordLenMx { Word = "This", Count = 4},
                new WordLenMx { Word = "is", Count = 2},
                new WordLenMx { Word = "a", Count = 1},
                new WordLenMx { Word = "sentence", Count = 8}
            };

            var actual = wordWithLen.Count("This is a sentence");
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Count_Expected_Empty_List_With_Empty_String_Input()
        {
            var wordWithLen = new WordWithLength();
            var expected = Enumerable.Empty<WordLenMx>().ToList();
            var actual = wordWithLen.Count(" ");
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Count_Expected_Empty_List_With_Null_Input()
        {
            var wordWithLen = new WordWithLength();
            var expected = Enumerable.Empty<WordLenMx>().ToList();
            var actual = wordWithLen.Count(null);
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}

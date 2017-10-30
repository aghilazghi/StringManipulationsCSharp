using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringManipulationLibrary;

namespace StringManipulations
{
    [TestClass]
    public class AnagramsTest
    {
        [TestMethod]
        public void Test_AreAnagrams_InputWithEqualLengthAndCharacters_ExpectedTrue()
        {
            var anagram = new Anagrams();
            var result = anagram.AreAnagrams("Debit card", "Bad credit");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Test_AreAnagrams_InputWithDifferentLength_ExpectedFalse()
        {
            var anagram = new Anagrams();
            var result = anagram.AreAnagrams("Debit car", "Bad credit");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Test_Reverse_InputEmptyOrNullStringFirstParam_ExpectedYourEntryIsInvalid()
        {
            var anagram = new Anagrams();
            string[] tests = { string.Empty, null };

            foreach (var test in tests)
            {
                var result = anagram.AreAnagrams(test, "Bad credit");
                Assert.IsFalse(result);
            }
        }

        [TestMethod]
        public void Test_Reverse_InputEmptyOrNullStringSecondParam_ExpectedYourEntryIsInvalid()
        {
            var anagram = new Anagrams();
            string[] tests = { string.Empty, null };

            foreach (var test in tests)
            {
                var result = anagram.AreAnagrams("Bad credit",test);
                Assert.IsFalse(result);
            }
        }
    }
}

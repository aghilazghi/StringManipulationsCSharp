using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringManipulations
{
    [TestClass]
    public class StringManipulation
    {
        [TestMethod]
        public void Test_RemoveDuplicateChars()
        {
            var expected = "gole";
            var actual = RemoveDuplicateChars("google");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_AreAnagrams()
        {
            var result = AreAnagrams("Debit card", "Bad credit");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Test_ReverseString()
        {
            var expected = "elgoog";
            var actual = ReverseString("google");
            Assert.AreEqual(expected, actual);
        }

        public string RemoveDuplicateChars(string input)
        {
            if(input == null) throw new ArgumentNullException(nameof(input));

            var result = string.Empty;

            foreach (var item in input)
            {
                if (result.IndexOf(item) == -1) result += item;
            }
            return result;
        }

        public bool AreAnagrams(string firstWord, string secondWord)
        {
            if (firstWord == null || secondWord == null) return false;

            if (firstWord.Length != secondWord.Length) return false;

            var firstWordCharsFrequencies = new Dictionary<char, int>();

            foreach (var item in firstWord.ToLower())
            {
                if (!firstWordCharsFrequencies.ContainsKey(item)) firstWordCharsFrequencies[item] = 0;
                firstWordCharsFrequencies[item]++;
            }

            foreach (var item in secondWord.ToLower())
            {
                if (!firstWordCharsFrequencies.ContainsKey(item)) return false;
                firstWordCharsFrequencies[item]--;
            }
            return firstWordCharsFrequencies.Values.All(c => c == 0);
        }

        public string ReverseString(string input)
        {
            if(string.IsNullOrWhiteSpace(input)) throw new ArgumentNullException();

            if (input.Length == 1) return input;

            var reversedInput = new char[input.Length];
            var inputLastIndex = input.Length - 1;

            foreach (var letter in input)
            {
                reversedInput[inputLastIndex--] = letter;
            }

            return new string(reversedInput);
        }

    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringManipulationLibrary;

namespace StringManipulations
{
    [TestClass]
    public class WordsCountTest
    {
        [TestMethod]
        public void Test_Count_InputNullArray_ExpectedZero()
        {
            var words = new WordsCount();
            string[] input = null;
            var expected = 0;
            var actual = words.Count(input, 1);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Count_InputArrayLengthZero_ExpectedZero()
        {
            var words = new WordsCount();
            string[] input = new string[0];
            var expected = 0;
            var actual = words.Count(input, 2);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Count_InputGivenLenghtIsLessOne_ExpectedZero()
        {
            var words = new WordsCount();
            var input = new[] {"Abb", "CCC"};
            var expected = 0;
            var actual = words.Count(input, -2);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Count_InputArrayValuesAreNullOrEmptySpace_ExpectedZero()
        {
            var words = new WordsCount();
            var input = new[] {null, " "};
            var expected = 0;
            var actual = words.Count(input, -2);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Count_InputCountArrayValuesWithOneLength_ExpectedZero()
        {
            var words = new WordsCount();
            var input = new[] {"ABC", "CDSI"};
            var expected = 0;
            var actual = words.Count(input, 1);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Count_InputCountArrayValuesWithOneLength_ExpectedTwo()
        {
            var words = new WordsCount();
            var input = new[] {"A", "C", "CCC", "AB"};
            var expected = 2;
            var actual = words.Count(input, 1);
            Assert.AreEqual(expected, actual);
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringManipulationLibrary;

namespace StringManipulations
{
    [TestClass]
    public class CountingNumberOfWordsTest
    {
        [TestMethod]
        public void Test_CountNumOfWords_Input16Words_Expected16Words()
        {
            var count = new CountingNumberOfWords();
            var expected = 16;
            var actual = count.Count("This is my to do list for today: groceries, gym, and read chapter 1 and 2.");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Count_InputEmptyOrNullString_ExpectedZero()
        {
            var cnt = new CountingNumberOfWords();
            string[] tests = { string.Empty, null };
            var expected = 0;

            foreach (var test in tests)
            {
                var actual = cnt.Count(test);
                Assert.AreEqual(expected, actual);
            }
        }
    }
}

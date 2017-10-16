using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringManipulations
{
    [TestClass]
    public class StringManipulation
    {
        [TestMethod]
        public void TestMethod1()
        {
            var expected = "gole";
            var actual = RemoveDuplicateChars("google");
            Assert.AreEqual(expected, actual);
        }

        public string RemoveDuplicateChars(string input)
        {
            var result = string.Empty;

            foreach (var item in input)
            {
                if (result.IndexOf(item) == -1) result += item;
            }
            return result;
        }
    }
}

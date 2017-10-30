using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringManipulationLibrary;

namespace StringManipulations
{
    [TestClass]
    public class ReplaceVowelsTest
    {
        [TestMethod]
        public void Test_Replace_InputStringWithVowel_ExpectedVowelsChangedWithDollarSign()
        {
            var vowel = new ReplaceVowels();
            var expected = "H$ll$";
            var actual = vowel.Replace("Hello");
            Assert.AreEqual(expected,actual);
        }

        [TestMethod]
        public void Test_Replace_InputStringWithOutVowel_ExpectedReturnsTheSameLikeInput()
        {
            var vowel = new ReplaceVowels();
            var expected = "Dry";
            var actual = vowel.Replace("Dry");
            Assert.AreEqual(expected,actual);
        }

        [TestMethod]
        public void Test_Replace_InputEmpytOrNull_ExpectedReturnsEmptyString()
        {
            var vowel = new ReplaceVowels();
            string[] testNulls = {string.Empty, null};
            var expected = string.Empty;

            foreach (var item in testNulls)
            {
                var actual = vowel.Replace(item);
                Assert.AreEqual(expected, actual);
            }
          
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringManipulationLibrary;
using System.Collections.Generic;

namespace StringManipulations
{
    [TestClass]
    public class WordLengthTest
    {
        [TestMethod]
        public void Count_Expected_4_2_1_4_8()
        {
            var wordLength = new WordLength();
            var expectedNumbrs = new List<int>() { 4, 2, 1, 4, 8 };
            List<int> actualNumbers = wordLength.Count("This is a long sentence");
            CollectionAssert.AreEqual(expectedNumbrs, actualNumbers);
        }
    }
}

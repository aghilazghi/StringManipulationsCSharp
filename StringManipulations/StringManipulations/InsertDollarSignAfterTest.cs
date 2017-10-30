using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringManipulationLibrary;

namespace StringManipulations
{
    [TestClass]
    public class InsertDollarSignAfterTest
    {
        [TestMethod]
        public void Test_Insert_InputWordMorethanOneCharacter_ExpectedDollarSignInsertedAfterEachCharButLastOne()
        {
            var ids = new InsertDollarSignAfter();
            var word = "Hello";
            var expected = "H$e$l$l$o";
            var actual = ids.Insert(word);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Insert_InputEmptyOrNullString_ExpectedEmptyString()
        {
            var ids = new InsertDollarSignAfter();
            string[] tests = { string.Empty, null };
            var expected = string.Empty;

            foreach (var test in tests)
            {
                var actual = ids.Insert(test);
                Assert.AreEqual(expected, actual);
            }
        }
    }
}

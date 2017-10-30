using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringManipulationLibrary;


namespace StringManipulations
{
    [TestClass]
    public class RemoveDuplicateCharactersTest
    {

        [TestMethod]
        public void Test_Remove_InputWithDuplicatedChars_ExpectedRemovedCharacters()
        {
            var rdc = new RemoveDuplicateCharacters();
            const string expected = "Gole";
            var actual = rdc.Remove("Google");
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Test_Remove_InputWithUnduplicatedChars_ExpectedTheSameResultAsInput()
        {
            var rdc = new RemoveDuplicateCharacters();
            const string expected = "Amine";
            var actual = rdc.Remove("Amine");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Remove_InputEmptyOrNullString_ExpectedYourEntryIsInvalid()
        {
            var rdc = new RemoveDuplicateCharacters();
            string[] tests = { string.Empty, null };
            var expected = "Your entry is invalid";

            foreach (var test in tests)
            {
                var actual = rdc.Remove(test);
                Assert.AreEqual(expected, actual);
            }
        }
    }
}

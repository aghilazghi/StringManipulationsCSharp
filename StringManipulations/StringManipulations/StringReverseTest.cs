using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringManipulationLibrary;

namespace StringManipulations
{
    [TestClass]
    public class StringReverseTest
    {
        [TestMethod]
        public void Test_Reverse_InputNonEmptyOrNullString_ExpectedReversedString()
        {
            var rev = new ReverseString();
            var expected = "elgoog";
            var actual = rev.Reverse("google");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Reverse_InputOneCharacter_ExpectedReturnsOneCharacter()
        {
            var rev = new ReverseString();
            var expected = "A";
            var actual = rev.Reverse("A");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Reverse_InputEmptyOrNullString_ExpectedYourEntryIsInvalid()
        {
            var rev = new ReverseString();
            string[] tests = {string.Empty, null};
            var expected = "Your entry is invalid";

            foreach (var test in tests)
            {
                var actual = rev.Reverse(test);
                Assert.AreEqual(expected, actual);
            }  
        }
    }
}

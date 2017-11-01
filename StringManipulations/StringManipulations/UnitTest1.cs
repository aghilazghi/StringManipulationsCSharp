using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringManipulationLibrary;

namespace StringManipulations
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_Repeat_InputString_ExpectedRepeatedCharsReturnsRepeatedChars()
        {
            var chars = new RepeatChar();
            var expected = "TThhee--##";
            var actual = chars.Repeat("The-#");
            Assert.AreEqual(expected, actual);
        }
    }
}

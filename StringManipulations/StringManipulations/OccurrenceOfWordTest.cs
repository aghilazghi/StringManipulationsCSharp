using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringManipulationLibrary;

namespace StringManipulations
{
    [TestClass]
    public class OccurrenceOfWordTest
    {
        [TestMethod]
        public void Test_Occurrence_InputWordOccursInText_ExpectedMoreThanOne()
        {
            var ew = new OccurrenceOfWord();
            var text = "Pork chop chicken spare ribs, short ribs meatball short loin porchetta picanha sausage filet mignon.";
            var expected = 2;
            var actual = ew.Occurrence(text, "ribs");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Occurrence_InputEmptyOrNullStringFirstParam_ExpectedReturnedZero()
        {
            var ow = new OccurrenceOfWord();
            string[] testNulls = { string.Empty, null };
            var expected = 0;

            foreach (var item in testNulls)
            {
                var actual = ow.Occurrence(item, "ribs");
                Assert.AreEqual(expected, actual);
            }
        }

        [TestMethod]
        public void Test_Occurrence_InputEmptyOrNullStringSecondParam_ExpectedReturnedZero()
        {
            var ow = new OccurrenceOfWord();
            var text = "Pork chop chicken spare ribs, " +
                       "short ribs meatball short loin porchetta " +
                       "picanha sausage filet mignon.";
            string[] testNulls = { string.Empty, null };
            var expected = 0;

            foreach (var item in testNulls)
            {
                var actual = ow.Occurrence(text, item);
                Assert.AreEqual(expected, actual);
            }
        }

    }
}

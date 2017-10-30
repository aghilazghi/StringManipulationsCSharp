using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringManipulationLibrary;

namespace StringManipulations
{
    [TestClass]
    public class ValidateCreditCardNumberTest
    {

        [TestMethod]
        public void Test_Validate_InputValidCreditNumber_ExpectedTrue()
        {
            var credit = new ValidateCreditCardNumber();
            var actual = credit.Validate("4417123456789113");
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void Test_Validate_InputInvalidCreditNumber_ExpectedFalse()
        {
            var credit = new ValidateCreditCardNumber();
            var actual = credit.Validate("4517123456789113");
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void Test_Validate_InputEmptyOrNullString_ExpectedFalse()
        {
            var credit = new ValidateCreditCardNumber();
            string[] testNulls = { string.Empty, null };

            foreach (var item in testNulls)
            {
                var actual = credit.Validate(item);
                Assert.IsFalse(actual);
            }
        }
    }
}

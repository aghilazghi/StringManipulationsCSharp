using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringManipulationLibrary;

namespace StringManipulations
{
    [TestClass]
    public class FindMatchingWordsAfterSpeciedStringTest
    {
        [TestMethod]
        public void Test_Find_InputsContainMatchingWords_ExpectedOneAndMoreWords()
        {
            var fw = new FindMatchingWords();
            var text =
                "We have large selection of goods.Customers can buy from" +
                " the category: shoes which is the best selling in our " +
                "inventory also category: shirts is the second to our shoes. " +
                "Also, we have category: computers and other items…";
            var expectedWords = new List<string> {"shoes", "shirts", "computers"};
            var actualWords = fw.Find(text, "category:");
            CollectionAssert.AreEqual(expectedWords, actualWords);
        }

        [TestMethod]
        public void Test_Find_InputsContainNonMatchingWords_ExpectedZeroCount()
        {
            var fw = new FindMatchingWords();
            var text =
                "We have large selection of goods.Customers can buy from" +
                " the non-matching: shoes which is the best selling in our " +
                "inventory also non-matching: shirts is the second to our shoes. " +
                "Also, we have non-matching: computers and other items…";
            var expectedWords = new List<string>();
            var actualWords = fw.Find(text, "category:");
            CollectionAssert.AreEqual(expectedWords, actualWords);
        }


        [TestMethod]
        public void Test_Find_InputsEmptyOrNullFirstParam_ExpectedZeroCount()
        {
            var fw = new FindMatchingWords();
            var expectedWords = new List<string>();
            string[] tests = {string.Empty};

            foreach (var test in tests)
            {
                var actualWords = fw.Find(test, "category:");
                CollectionAssert.AreEqual(expectedWords, actualWords);
            }
        }

        [TestMethod]
        public void Test_Find_InputsEmptyOrNullSecondParam_ExpectedZeroCount()
        {
            var fw = new FindMatchingWords();
            var text =
                "We have large selection of goods. Customers can buy from" +
                " the category: shoes which is the best selling in our " +
                "inventory also category: shirts is the second to our shoes. " +
                "Also, we have category: computers and other items…";
            var expectedWords = new List<string>();
            string[] tests = {string.Empty};

            foreach (var test in tests)
            {
                var actualWords = fw.Find(text, test);
                CollectionAssert.AreEqual(expectedWords, actualWords);
            }
        }
    }
}

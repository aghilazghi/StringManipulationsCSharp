using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringManipulations
{
    [TestClass]
    public class StringManipulation
    {
        [TestMethod]
        public void Test_RemoveDuplicateChars()
        {
            var expected = "gole";
            var actual = RemoveDuplicateChars("google");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_AreAnagrams()
        {
            var result = AreAnagrams("Debit card", "Bad credit");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Test_ReverseString()
        {
            var expected = "elgoog";
            var actual = ReverseString("google");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_CountNumOfWords()
        {
            var expected = 16;
            var actual = CountNumOfWords("This is my to do list for today: groceries, gym, and read chapter 1 and 2.");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_OccurrencesOfAWord()
        {
            var text = "Pork chop chicken spare ribs, short ribs meatball short loin porchetta picanha sausage filet mignon.";
            var word = "ribs";
            var expected = 2;
            var actual = OccurrencesOfAWord(text, word);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_ValidateCreditCardNumber()
        {
            var creditCardNumber = "4417123456789113";
            var actual = ValidateCreditCardNumber(creditCardNumber);
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void Test_FindWordsAfterCategoriesColon()
        {
            var text =
                "We have large selection of goods.Customers can buy from" +
                " the category:shoes which is the best selling in our " +
                "inventory also category:shirts is the second to our shoes " +
                "inventory. Also, we category:computers and other items…";
            var categoryColon = "category:";
            var expectedWords = new List<string>{"shoes", "shirts", "computers"};
            var actualWords = FindWordsAfterCategoriesColon(text, categoryColon);
            CollectionAssert.AreEqual(expectedWords, actualWords);
        }

        public string RemoveDuplicateChars(string input)
        {
            if(input == null) throw new ArgumentNullException(nameof(input));

            var result = string.Empty;

            foreach (var item in input)
            {
                if (result.IndexOf(item) == -1) result += item;
            }
            return result;
        }

        public bool AreAnagrams(string firstWord, string secondWord)
        {
            if (firstWord == null || secondWord == null) return false;

            if (firstWord.Length != secondWord.Length) return false;

            var firstWordCharsFrequencies = new Dictionary<char, int>();

            foreach (var item in firstWord.ToLower())
            {
                if (!firstWordCharsFrequencies.ContainsKey(item)) firstWordCharsFrequencies[item] = 0;
                firstWordCharsFrequencies[item]++;
            }

            foreach (var item in secondWord.ToLower())
            {
                if (!firstWordCharsFrequencies.ContainsKey(item)) return false;
                firstWordCharsFrequencies[item]--;
            }
            return firstWordCharsFrequencies.Values.All(c => c == 0);
        }

        public string ReverseString(string input)
        {
            if(string.IsNullOrWhiteSpace(input)) throw new ArgumentNullException();

            if (input.Length == 1) return input;

            var reversedInput = new char[input.Length];
            var inputLastIndex = input.Length - 1;

            foreach (var ch in input)
            {
                reversedInput[inputLastIndex--] = ch;
            }

            return new string(reversedInput);
        }

        public int CountNumOfWords(string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return 0;
            /*
             // using regular expression
              var wordCount = Regex.Matches(input, @"\b[A-Za-z0-9]+\b").Count;
            */
            var words = input.Split(new[] { '.', '?', '!', ' ', ';', ':', ',' }, StringSplitOptions.RemoveEmptyEntries);
            var wordCount = words.Length;

            return wordCount;
        }

        public int OccurrencesOfAWord(string text, string word)
        {
            var splittedText = text.Split(new[] { '.', '?', '!', ' ', ';', ':', ',' }, StringSplitOptions.RemoveEmptyEntries);
            var words = splittedText.Where(w => string.Equals(w, word, StringComparison.OrdinalIgnoreCase));
            var wordCount = words.Count();

            return wordCount;
        }

        public bool ValidateCreditCardNumber(string creditCardNumber)
        {
            var creditCardLenght = creditCardNumber.Length;

            if(creditCardLenght == 0) throw  new ArgumentException();

            var total = 0;

            //operation that starts from first number and escapes the following number
            for (var i = 0; i < creditCardLenght; i += 2)
            {
                //double digits by escaping one starting form the first number
                var doubled = Convert.ToInt32(creditCardNumber.Substring(i, 1)) * 2;

                // if the product is less than 10, add it to the total otherwise split the two digits and add them 
                if (doubled < 10)
                {
                    total += doubled;
                }
                else
                {
                    var doubleDigit = doubled.ToString();
                    total += doubleDigit.Select((t, j) => Convert.ToInt32(doubleDigit.Substring(j, 1))).Sum();
                }
            }

            //operation that starts from second number and escapes the following number
            for (var i = 1; i < creditCardLenght; i += 2)
            {
                total += Convert.ToInt32(creditCardNumber.Substring(i, 1));

            }

            return total % 10 == 0;

        }

        public List<string> FindWordsAfterCategoriesColon(string text, string categoryPlusColon)
        {
            var increment = 0;
            var foundWords = new List<string>();
            while (true)
            {
                var specifiedWordFound = text.IndexOf(categoryPlusColon, increment);
                if(specifiedWordFound == -1) break;
                var wordStart = specifiedWordFound + categoryPlusColon.Length;
                var wordEnd = text.IndexOf(" ", wordStart);
                var wordLength = wordEnd - wordStart;
                foundWords.Add(text.Substring(wordStart, wordLength));
                increment = wordEnd + 1;
            }
            return foundWords;
        }
    }
}

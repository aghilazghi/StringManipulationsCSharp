using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringManipulationLibrary;

namespace StringManipulations
{
    [TestClass]
    public class StarKillTest
    {
        [TestMethod]
        public void Test_Kill_InputOneStarInTheMiddle_ExpectedLeftAndRightEliminated()
        {
            var star = new StarKill();
            var expected = "a*d";
            var actual = star.Kill("ab*cd");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Kill_InputTwoStarsInTheMiddle_ExpectedLeftAndRightEliminated()
        {
            var star = new StarKill();
            var expected = "a**d";
            var actual = star.Kill("ab**cd");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Kill_InputThreeStarsInTheMiddle_ExpectedLeftAndRightEliminated()
        {
            var star = new StarKill();
            var expected = "a***d";
            var actual = star.Kill("ab***cd");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Kill_InputNoStarInTheMiddle_ExpectedTheSameAsInput()
        {
            var star = new StarKill();
            var expected = "ad";
            var actual = star.Kill("ad");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Kill_InputStarInTheBeginning_ExpectedRightCharFromStarRemoved()
        {
            var star = new StarKill();
            var expected = "*ad";
            var actual = star.Kill("*ad");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Kill_InputStarInTheEnd_ExpectedLeftCharFromStarRemoved()
        {
            var star = new StarKill();
            var expected = "ad*";
            var actual = star.Kill("ad*");
            Assert.AreEqual(expected, actual);
        }
    }
}

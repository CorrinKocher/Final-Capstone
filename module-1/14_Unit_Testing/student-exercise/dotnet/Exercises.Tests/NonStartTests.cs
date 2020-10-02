using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class NonStartTests
    {
        [TestMethod]
        public void TheHFromTheWordHelloShouldBeDropped()
        {
            string a = "hello";
            string b = "there";
            NonStart noLetterH = new NonStart();
            string result = noLetterH.GetPartialString(a, b);
            Assert.AreEqual("ellohere", result);

        }
        [TestMethod]
        public void FirstStringEmptyReturnsOnlySecondStringMinusFirstChar()
        {
            string a = "";
            string b = "there";
            NonStart noLetterH = new NonStart();
            string result = noLetterH.GetPartialString(a, b);
            Assert.AreEqual("here", result);

        }
        [TestMethod]
        public void TwoEmptyStringsReturnsAnEmptyString()
        {
            string a = "";
            string b = "";
            NonStart noLetterH = new NonStart();
            string result = noLetterH.GetPartialString(a, b);
            Assert.AreEqual("", result);

        }
    }
}

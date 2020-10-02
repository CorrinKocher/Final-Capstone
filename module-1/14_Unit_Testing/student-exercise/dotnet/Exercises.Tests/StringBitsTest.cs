using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class StringBitsTest
    {
        [TestMethod]
        public void HelloReturnsHlo()
        {
            string a = "hello";
            StringBits hello = new StringBits();
            string result = hello.GetBits(a);
            Assert.AreEqual("hlo", result);
        }
        [TestMethod]
        public void EmptyStringReturnsEmptyString()
        {
            string a = "";
            StringBits hello = new StringBits();
            string result = hello.GetBits(a);
            Assert.AreEqual("", result);
        }
        [TestMethod]
        public void HReturnsH()
        {
            string a = "h";
            StringBits hello = new StringBits();
            string result = hello.GetBits(a);
            Assert.AreEqual("h", result);
        }
    }
}

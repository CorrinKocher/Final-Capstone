using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class Less20Tests
    {
        [TestMethod]
        public void Int40ReturnsFalse()
        {
            Less20 forty = new Less20();
            bool result = forty.IsLessThanMultipleOf20(40);
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Int39ReturnsTrue()
        {
            Less20 thirtyNine = new Less20();
            bool result = thirtyNine.IsLessThanMultipleOf20(39);
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void Int0ReturnsFalse()
        {
            Less20 zero = new Less20();
            bool result = zero.IsLessThanMultipleOf20(0);
            Assert.AreEqual(false, result);
        }
    }
}

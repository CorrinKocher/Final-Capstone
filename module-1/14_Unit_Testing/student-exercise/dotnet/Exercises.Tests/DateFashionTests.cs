using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class DateFashionTests
    {
        [TestMethod]
        public void DontGetATableIfYouAre0AndDateIsA10()
        {
            DateFashion badFashion = new DateFashion();
            int result = badFashion.GetATable(0, 10);

            Assert.AreEqual(0, result);
        }
        [TestMethod]
        public void GetATableIfYouAre10AndDateIsA5()
        {
            DateFashion badFashion = new DateFashion();
            int result = badFashion.GetATable(10, 5);

            Assert.AreEqual(2, result);
        }
        [TestMethod]
        public void DontGetATableIfYouAre0AndDateIsA5()
        {
            DateFashion badFashion = new DateFashion();
            int result = badFashion.GetATable(0, 5);

            Assert.AreEqual(0, result);
        }
    }
}

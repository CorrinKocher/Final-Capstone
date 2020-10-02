using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class Lucky13Tests
    {
        [TestMethod]
        public void NoOnesAndNoThreesShouldReturnTrue()
        {
            int[] nums = new int[] { 0, 4, 5, 6 };
            Lucky13 no1no3 = new Lucky13();
            bool result = no1no3.GetLucky(nums);
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void NoOnesAndSomeThreesShouldReturnFalse()
        {
            int[] nums = new int[] { 0, 4, 5, 6, 3, 3 };
            Lucky13 no1no3 = new Lucky13();
            bool result = no1no3.GetLucky(nums);
            Assert.AreEqual(false, result);
        }
        [TestMethod]
        public void OnesAndThreesShouldReturnFalse()
        {
            int[] nums = new int[] { 0, 4, 5, 6, 1, 3 };
            Lucky13 no1no3 = new Lucky13();
            bool result = no1no3.GetLucky(nums);
            Assert.AreEqual(false, result);
        }
        [TestMethod]
        public void EmptyArrayReturnTrue()
        {
            int[] nums = new int[] { };
            Lucky13 no1no3 = new Lucky13();
            bool result = no1no3.GetLucky(nums);
            Assert.AreEqual(true, result);
        }
    }
}

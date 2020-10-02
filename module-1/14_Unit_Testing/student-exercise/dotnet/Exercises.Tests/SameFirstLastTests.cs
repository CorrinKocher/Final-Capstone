using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class SameFirstLastTests
    {
        [TestMethod]
        public void FirstAndLastAre1SoShouldReturnTrue()
        {
            int[] nums = { 1, 1, 1}; 
            SameFirstLast theNumber1 = new SameFirstLast();
            bool result = theNumber1.IsItTheSame(nums);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void FirstIs1Lastis2ShouldReturnFalse()
        {
            int[] nums = { 1, 1, 2 };
            SameFirstLast theNumber1 = new SameFirstLast();
            bool result = theNumber1.IsItTheSame(nums);
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void EmptyArrayShouldReturnFalse()
        {
            int[] nums = { };
            SameFirstLast theNumber1 = new SameFirstLast();
            bool result = theNumber1.IsItTheSame(nums);
            Assert.IsFalse(result);
        }
    }
}

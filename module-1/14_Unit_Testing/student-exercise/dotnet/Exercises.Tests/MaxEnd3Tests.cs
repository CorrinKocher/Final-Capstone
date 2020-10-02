using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class MaxEnd3Tests
    {
        [TestMethod]
        public void LastNumberinArrayis3SoAllNumbersInArrayAre3()
        {
            int[] nums = new int[] { 1, 2, 3 };
            int[] newNums = new int[] { 3, 3, 3 };
            MaxEnd3 theNumberThree = new MaxEnd3();
            int[] result = theNumberThree.MakeArray(nums);
            CollectionAssert.AreEqual(newNums, result);
            //int[] result = theNumberThree.MakeArray(nums);
           // Assert.AreEqual(nums[0], result[0]); 
        }
        [TestMethod]
        public void LastNumberinArrayis4SoPosition0ShouldBe4()
        {
            int[] nums = new int[] { 1, 2, 4 };
           // int[] newNums = new int[] { 4, 4, 4 };
            MaxEnd3 theNumberFour = new MaxEnd3();
            int[] result = theNumberFour.MakeArray(nums);
            Assert.AreEqual(nums[0], result[0]); 
        }
        [TestMethod]
        public void LastNumberinArrayis0AndPosition0isneg1SoPosition0ShouldBe0()
        {
            int[] nums = new int[] { -1, 2, 0 };
           
            MaxEnd3 zero = new MaxEnd3();
            int[] result = zero.MakeArray(nums);
            Assert.AreEqual(nums[0], result[0]);
        }
    }
}

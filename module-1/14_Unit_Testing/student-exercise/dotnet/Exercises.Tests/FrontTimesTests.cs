using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class FrontTimesTests
    {
        [TestMethod]
        public void Int3ShouldRepeatFirst3Letters3Times()
        {
            FrontTimes threepeat = new FrontTimes();
            string result = threepeat.GenerateString("Chocolate", 3);
            Assert.AreEqual("ChoChoCho", result);

        }

        [TestMethod]
        public void StringLessThan3ShouldRepeat3Times()
        {
            FrontTimes threepeat = new FrontTimes();
            string result = threepeat.GenerateString("hi", 3);
            Assert.AreEqual("hihihi", result);

        }
        [TestMethod]
        public void EmptyStringShouldReturnEmptyString()
        {
            FrontTimes empty = new FrontTimes();
            string result = empty.GenerateString("", 3);
            Assert.AreEqual("", result);

        }
        [TestMethod]
        public void Int0ShouldReturnEmptyString()
        {
            FrontTimes empty = new FrontTimes();
            string result = empty.GenerateString("Hi", 0);
            Assert.AreEqual("", result);

        }
    }
}

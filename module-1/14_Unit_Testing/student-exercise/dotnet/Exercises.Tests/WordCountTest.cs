using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]

    public class WordCountTest
    {
        [TestMethod]
        public void BaBaBaReturnsBa3()
        {
            Dictionary<string, int> answer = new Dictionary<string, int>() { { "ba", 3 } };
            string[] blackSheep = new string[] { "ba", "ba", "ba" };
            WordCount bababa = new WordCount();
            Dictionary<string, int> result = bababa.GetCount(blackSheep);
            CollectionAssert.AreEqual(answer, result);
        }
        [TestMethod]
        public void EmptyStringReturnsEmptyKeyAndZero()
        {
            Dictionary<string, int> answer = new Dictionary<string, int>() { {"", 0} };
            string[] blackSheep = new string[] {""};
            WordCount bababa = new WordCount();
            Dictionary<string, int> result = bababa.GetCount(blackSheep);
            CollectionAssert.AreEqual(answer, result);
        }
        [TestMethod]
        public void StringA1ShouldReturnA1Comma3()
        {
            Dictionary<string, int> answer = new Dictionary<string, int>() { { "A1", 3 } };
            string[] blackSheep = new string[] { "A1", "A1", "A1" };
            WordCount bababa = new WordCount();
            Dictionary<string, int> result = bababa.GetCount(blackSheep);
            CollectionAssert.AreEqual(answer, result);
        }

    }
}

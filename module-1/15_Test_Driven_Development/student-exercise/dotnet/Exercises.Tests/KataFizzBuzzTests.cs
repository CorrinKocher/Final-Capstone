using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Tests
{
    [TestClass()]
    public class KataFizzBuzzTests
    {
        [TestMethod]
        public void Number3ReturnsFizz()
        {
            int number = 3;
            KataFizzBuzz fizz = new KataFizzBuzz();
            string result = fizz.ReturnFizzBuzz(number);
        }
        
    }
}

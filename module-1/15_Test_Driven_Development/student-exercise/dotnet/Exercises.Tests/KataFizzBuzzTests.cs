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
        [DataRow(0, "0")]
        [DataRow(3, "Fizz")]
        [DataRow(5, "Buzz")]
        [DataRow(15, "FizzBuzz")]
        [DataRow(101,"")]
        [DataRow(-1, "")]
        public void Number3ReturnsFizz(int number, string expected)
        {
            
            KataFizzBuzz fizz = new KataFizzBuzz();
            string result = fizz.ReturnFizzBuzz(number);

        }
        
    }
}

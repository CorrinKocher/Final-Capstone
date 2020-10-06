using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class KataFizzBuzz
    {
        public string ReturnFizzBuzz(int number)
        {


            if (number <= 100 && number >= 1 && number % 3 == 0 && number % 5 == 0)
            {
                return "FizzBuzz";
            }
            else if (number <= 100 && number >= 1 && number % 3 == 0)
            {
                return "Fizz";
            }
            else if (number <= 100 && number >= 1 && number % 5 == 0)
            {
                return "Buzz";
            }
            else if (number >= 1 && number <= 100)
            {
                return number.ToString();
            }
            else
            {
                return "";
            }
        }
    }
}
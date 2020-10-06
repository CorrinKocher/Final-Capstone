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
            const int numberFive = 5;
            const int numberThree = 3;
            bool hasFive = number.ToString().Contains(numberFive.ToString());


            if (number <= 100 && number >= 1)
            {

                if(number % 3 == 0 && number % 5 == 0 || number.ToString().Contains(numberFive.ToString()) && number.ToString().Contains(numberThree.ToString()))
                {
                    return "FizzBuzz";
                }
            } 
            else if (number <= 100 && number >= 1 && hasFive == false)
            {
                if(number % 3 == 0 || number.ToString().Contains(numberThree.ToString()) || number == numberThree)
                {
                    return "Fizz";
                }
            }
                
            else if (number <= 100 && number >= 1 && number % 5 == 0 || number.ToString().Contains(numberFive.ToString()) || number == numberThree)
            {
                return "Buzz";
            }
            else if (number >= 1 && number <= 100 )
            {
                return number.ToString();
            }
            else
            {
                return "";
            }
            return "";
        }
    }
}
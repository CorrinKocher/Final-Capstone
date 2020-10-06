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
            bool hasThree = number.ToString().Contains(numberThree.ToString());

            if ( number < 1 || number > 100)
            {
                return "";
            }

            if((number % 3 == 0 && number % 5 == 0) || (hasFive && hasThree))
            {
                return "FizzBuzz";
            }
            
            else if (!hasFive)
            {
                if(number % 3 == 0 || hasThree )
                {
                    return "Fizz";
                }
            }
                
            else if ( number % 5 == 0 || hasFive)
            {
                return "Buzz";
            }
            return number.ToString();
          
            
           
        }
    }
}
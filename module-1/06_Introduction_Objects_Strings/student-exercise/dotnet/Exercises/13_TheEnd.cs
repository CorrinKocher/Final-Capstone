using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class StringExercises
    {
        /*
        Given a string, return a string length 1 from its front, unless front is false, in which case
        return a string length 1 from its back. The string will be non-empty.
        TheEnd("Hello", true) → "H"
        TheEnd("Hello", false) → "o"
        TheEnd("oh", true) → "o"
        */
        public string TheEnd(string str, bool front)
        {

            if (front == true)
            {
               // if (str.Length < 2)
               // {
                 //   return str;
                //}
               // if (str.Length >= 2)
           //     {
                   string newString = (str.Substring(0, 1));
                return newString;
             //   }
            }
            else 
            {
               // if (str.Length < 2)
               // {
                 //   return str;
               // }
              //  if (str.Length >= 2)
               // {
                    string otherString = (str.Substring(str.Length - 1, 1));
                return otherString;
              //  }
            }

        }
    }
}

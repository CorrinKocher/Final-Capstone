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
        Given a string, return a version where all the "x" have been removed. Except an "x" at the very start or end
        should not be removed.
        StringX("xxHxix") → "xHix"
        StringX("abxxxcd") → "abcd"
        StringX("xabxxxcdx") → "xabcdx"
        */
        public string StringX(string str)
        {
            string result = "";
            for (int i = 0; i < str.Length; i++)
            {
                
                //int index = str.IndexOf('x');
                if (i == 0 || i ==str.Length -1)
                {
                    result += str.Substring(i, 1);
                }
                else if (str.Substring(i, 1) != "x")
                {
                    result += str.Substring(i, 1);
                }
                

                  
            }
            return result;
        }
    }
}

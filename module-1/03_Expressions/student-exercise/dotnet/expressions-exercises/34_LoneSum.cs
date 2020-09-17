﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         Given 3 int values, a b c, return their sum. However, if one of the values is the same as another
         of the values, it does not count towards the sum.
         LoneSum(1, 2, 3) → 6
         LoneSum(3, 2, 3) → 2
         LoneSum(3, 3, 3) → 0
         */
        public int LoneSum(int a, int b, int c)
        {
            if (a == b)
            {
                if (b != c)
                {
                    return c;
                }
                return 0;
            }
            if (b == c)
            {
                if(c != a)
                {
                    return a;
                }
                return 0;
            }
            if (a == c)
            {

                if (c != b)
                {
                    return b;
                }
                return 0;
            }                    
            else
            {
                return a + b + c;
            }

            
        }

    }
}

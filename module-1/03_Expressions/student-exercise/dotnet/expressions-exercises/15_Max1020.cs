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
      Given 2 positive int values, return the larger value that is in the range 10..20 inclusive,
      or return 0 if neither is in that range.
      Max1020(11, 19) → 19
      Max1020(19, 11) → 19
      Max1020(11, 9) → 11
      */
        public int Max1020(int a, int b)
        {


            //if((a < 10 || a > 20) && (b < 10 || b > 20)) //John would get rid of cases where you wouldnt compare the two values
            //{
            //    return 0;
            //}
            //else if(a >= 10 &  a <= 20 && b >= 10 & b <= 20 && a > b)  // than check if only A is out of the range. Than check if only b is out of the range.
            //{
            //    return a;
            //}
            //else if (a >= 10 & a <= 20 && b >= 10 & b <= 20 && a < b) // than, finally compare A and B
            //{
            //    return b;
            //}

            if (a >= 10 && a <= 20)
            {
                if (b >= 10 && b <= 20)
                {
                    if (a > b)
                    {
                        return a;
                    }
                    if (b > a)
                    {
                        return b;
                    }
                    if (b == a)
                    {
                        return b;
                    }
                }
                return a;
            }
            if (b >= 10 && b <= 20)
            {
                return b;
            }
            return 0;








        } 

    }
}

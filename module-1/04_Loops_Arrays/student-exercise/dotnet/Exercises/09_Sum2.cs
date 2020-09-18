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
         Given an array of ints, return the sum of the first 2 elements in the array. If the array length
          is less than 2, just sum up the elements that exist, returning 0 if the array is length 0.
         Sum2([1, 2, 3]) → 3
         Sum2([1, 1]) → 2
         Sum2([1, 1, 1, 1]) → 2
         */
        public int Sum2(int[] nums)
        {  int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums.Length < 2)
                {
                    sum += nums[i];
                    
                    return sum;
                }
                if (nums.Length >= 2)
                {
                    sum = nums[0] + nums[1];

                    return sum;
                }

            }
            return 0;
        }

    }
}

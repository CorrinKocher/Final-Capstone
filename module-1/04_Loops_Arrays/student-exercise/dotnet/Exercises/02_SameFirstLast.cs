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
         Given an array of ints, return true if the array is length 1 or more, and the first element and
         the last element are equal.
         SameFirstLast([1, 2, 3]) → false
         SameFirstLast([1, 2, 3, 1]) → true
         SameFirstLast([1, 2, 1]) → true
         */
        public bool SameFirstLast(int[] nums)
        {
            if(1 <= nums.Length)
            {
                if (nums[nums.Length - 1] == nums[0])
                {
                    return true;
                } 
                return false;
            }
            return false;
        }

    }
}

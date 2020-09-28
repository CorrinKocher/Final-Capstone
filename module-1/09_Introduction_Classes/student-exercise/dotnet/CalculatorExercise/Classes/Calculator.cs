using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechElevator.Classes
{
    /// <summary>
    /// Represents a "simple" calculator
    /// </summary>
    public class Calculator
    {
        // public int MathExample (intx, int power)
        // Math.Pow(x,power) = x raised to the power int)
        // (int) Math.POW(x, power)
        // cannot convert double to an int. so cast the double to an int
        
     
        public int Result { get; private set; }



        public int Add(int addend)
        {
            Result = Result + addend;
            return Result;
        }
        public int Multiply(int multiplier)
        {
            Result = Result * multiplier;
            return Result;
        }
        public int Power(int exponent)

        {
            Result = Result * Result;
            //double x;
            // result = Math.Pow(x, (double)int exponent);
            //return result;
            return Result;
        }
        public void Reset()
        {
            Result = 0;
        }
        public int Subtract(int subtrahend)
        {
            Result = Result - subtrahend;
            return Result;
        }

    }
} 
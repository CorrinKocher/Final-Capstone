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
        private int result = 0;
        private int addend = 0;
        private int multiplier = 0;
        private int exponent = 0;
        public int Result { get; private set; }



        public int Add(int addend)
        {
            Result = this.result + this.addend;
            return result;
        }
        public int Multiply(int multiplier)
        {
            Result = result * this.multiplier;
            return result;
        }
        public int Power(int exponent)

        {
            Result = result * result;
            //double x;
            // result = Math.Pow(x, (double)int exponent);
            //return result;
            return result;
        }
        public void Reset()
        {
            Result = 0;
        }
        public int Subtract(int subtrahend)
        {
            Result = this.result - subtrahend;
            return result;
        }

    }
} 
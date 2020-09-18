using System;

namespace LinearConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to the Length Converter");
            Console.WriteLine("Please enter a length");

            string length = Console.ReadLine();
            double lengthAmt = double.Parse(length);

            Console.WriteLine();
            Console.WriteLine("Please enter F to convert feet to meters and M to convert meters to feet");

            string measurementType = Console.ReadLine();
            
            double result = 0;
            double ftToMet = .3048;
            double metToFt = 3.2808399;

            if(measurementType == "F" || measurementType == "f")
            {
                result = lengthAmt * ftToMet;
                Console.WriteLine("Your measurement in feet is " + lengthAmt + " and is " + result + " in meters");
                
            }
            else if(measurementType == "M" || measurementType == "m")
                {
                result = lengthAmt * metToFt;
                Console.WriteLine("Your measurement in meters is " + lengthAmt + " and is " + result + " in feet");
            }
            
           
            


        }
    }
}

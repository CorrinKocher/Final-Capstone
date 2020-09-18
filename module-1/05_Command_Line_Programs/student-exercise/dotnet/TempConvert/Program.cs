using System;

namespace TempConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to the temperature converter, where we convert Fahrenheit to Celsius and Celsius to Fahrenheit.");
            Console.WriteLine("Please enter a temperature.");

            string tempEntered = Console.ReadLine();
            double temperature = double.Parse(tempEntered);

            Console.WriteLine();
            Console.WriteLine("Is the temperature in Celsius or Fehrenheit? Enter F for Fahrenheit; Enter C for Celsius.");

            string typeEntered = Console.ReadLine();
            
            double result = 0;
            double thirtyTwo = 32;
            

            if (typeEntered == "F" || typeEntered == "f")
            {
                result = (temperature - thirtyTwo) / 1.8;
                Console.WriteLine("Your temperature in Fahrenheit is " + temperature + " and is " + result + " in Celsius");

            }
            else if(typeEntered == "C" || typeEntered == "c")
            {
                result = (temperature * 1.8) + thirtyTwo;
                Console.WriteLine("Your temperature in Celsius is " + temperature + " and is " + result + " in Fahrenheit");
            }
          
        }
    }
}

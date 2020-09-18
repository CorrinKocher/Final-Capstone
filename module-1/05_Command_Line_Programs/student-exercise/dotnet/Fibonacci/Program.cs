using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to the Fibonacci Generator. Please enter a number!");
            

            string requestedNumber = Console.ReadLine();
            double requestedFibonacci = double.Parse(requestedNumber);

            int first = 0;
            int second = 1;
            int next = 0;

            Console.Write("0, 1");

            while (next <= requestedFibonacci)
            {
                next = first + second;

                if (next > requestedFibonacci)
                {
                    break;
                }

                Console.Write(", " + next);

                first = second;
                second = next;

            }
        }
    }
}

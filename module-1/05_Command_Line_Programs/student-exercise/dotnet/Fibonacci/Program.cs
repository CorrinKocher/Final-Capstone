using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to the Fibonacci Generator. Please enter a number!");
            

<<<<<<< HEAD
            string requestedNumber = Console.ReadLine();
            double requestedFibonacci = double.Parse(requestedNumber);
=======
            // We'll modify the line below to create a merge conflict together
            string myName = "Matt Eland";
>>>>>>> e8b4bb213d6ef099f3a1c6dda93e67c37d4922e4

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

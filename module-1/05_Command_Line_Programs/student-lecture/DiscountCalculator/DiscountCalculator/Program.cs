using System;

namespace DiscountCalculator
{
    class Program
    {
        static void Main(string[] args)

        {
            for (int i = 0; i < 10; i++)
            {
                if(i % 2 == 0)
                {
                    continue;
                }
                if(i % 5 == 0)
                {
                    break;
                }
                Console.WriteLine(i);
            }
            Console.WriteLine("Welcome to .NET's discount Calculator");

            string author = "Cohort12 .NET(CBUS)";

            Console.Write("this application was written by Cohort 12 .NET (CBUS)");
            
            Console.Write(author);
            
            Console.WriteLine(" We hope you like it!");
            
            Console.WriteLine();

            Console.WriteLine("Enter the discount percentage(without a % sign)");

            string discountText = Console.ReadLine();

            double discountPercent = double.Parse(discountText);
            
            discountPercent += 5;

            Console.WriteLine("Your discount is " + discountPercent + "%");

            Console.WriteLine($"Your discount is {discountText}%");

            //get prices from the user
            bool shouldExit = false;

            while(shouldExit == false)
            {

                Console.WriteLine("Please enter a series of prices seperated by spaces or press Q to exit");

                string priceText = Console.ReadLine();

                if (priceText == "Q")
                {
                    shouldExit = true;
                }

                else
                {

                    string[] priceArray = priceText.Split(" ");

                    for (int i = 0; i < priceArray.Length; i++)
                    {
                        double individualPrice = double.Parse(priceArray[i]);

                        double discountedPrice = individualPrice * (discountPercent / 100);

                        Console.WriteLine(individualPrice + " is " + discountedPrice + " discounted.");
                    }
                }
            }


            Console.WriteLine("Thank you for using our awesome calculator. May your prices be cheap.");

        }
    }
}

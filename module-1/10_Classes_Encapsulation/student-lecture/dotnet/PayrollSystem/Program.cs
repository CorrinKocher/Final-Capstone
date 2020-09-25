using System;
using PayrollSystem.PayrollDetails;

namespace PayrollSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Company hooli = new Company("Hooli", "42 Wallaby Way");

            Employee moss = new Employee(1, "Moss", "Crowd");

            hooli.Hire(moss, 75000M);

            moss.LastName = null;

            hooli.Pay();

            Console.WriteLine("That's All Folks!");
        }
    }
}

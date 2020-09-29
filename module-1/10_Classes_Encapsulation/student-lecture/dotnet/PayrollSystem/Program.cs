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

            Employee roy = new Employee(2, "Roy", "Jerkface");
            hooli.Hire(roy, 10000M);

            moss.LastName = null;

            hooli.Pay();

            //PayEmployees(hooli); cant call a method that is not static if inside a static method.

            moss.Pay(1000M);

            Console.WriteLine("That's All Folks!");
        }
        private void PayEmployees(Company company)
        {
            company.Pay();
        }
    }
}

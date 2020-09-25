using System;
using System.Collections.Generic;
using System.Text;

namespace PayrollSystem.PayrollDetails
{
    public class Employee
    {
        private decimal totalIncome;
        private string firstName;
        private string lastName;
        public Employee(int id, string firstName, string lastName)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
        }
        public int Id { get; }

        public decimal Salary { get; set; }
        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if(!string.IsNullOrWhiteSpace(value))
                {
                    this.firstName = value;
                }
            }

        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                if(!string.IsNullOrWhiteSpace(value))
                {
                    this.lastName = value;
                }
            }
        }
        public string FullName
        {
            get
            {
                return this.firstName + " " + this.lastName;
            }
        }
        public void Pay()
        {
            Console.WriteLine("It is payday for " + this.FullName);
            this.totalIncome += this.Salary;

        }

    }
}

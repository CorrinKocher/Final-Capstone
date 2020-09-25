using System;
using System.Collections.Generic;
using System.Text;

namespace PayrollSystem.PayrollDetails
{
    public class Company
    {
        private List<Employee> employees = new List<Employee>();
        public Company(string name, string address)
        {
            this.Address = address;
            this.Name = name;
            this.WirelessPassowrd = "Password1";
        }
        public string Address { get; set; }

        public string Name { get; }

        public string WirelessPassowrd { get; private set; }

        public void Hire(Employee employee, decimal startingSalary)
        {
            employee.Salary = startingSalary;

            employees.Add(employee);
        }
        public void Pay()
        {
            foreach (Employee emp in this.employees)
            {
                emp.Pay();
            }
        }
    }
}

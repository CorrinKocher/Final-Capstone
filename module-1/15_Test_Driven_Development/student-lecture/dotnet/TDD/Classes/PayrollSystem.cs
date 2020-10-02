using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TDD.Classes
{
    /// <summary>
    /// This class is responsible for trackingemployees and their pay
    /// </summary>
    public class PayrollSystem
    {
        public double TotalPayroll { get; private set; }

        public bool HireEmployee(string name, double salary)
        {
            this.employeeSalaries[name] = salary;
            TotalPayroll += salary;
            return true;
        }
        public double TotalSalary { get; private set; }
        private Dictionary<string, double> employeeSalaries = new Dictionary<string, double>();

        public void FireEmployee(string name)
        {
            if(this.employeeSalaries.ContainsKey(name))
            {
                this.TotalPayroll -= this.employeeSalaries[name];
                this.employeeSalaries[name] = 0;
                this.employeeSalaries.Remove(name);
            }
            
        }
        public string[] Employees
        {
            get
            {
               return this.employeeSalaries.Keys.ToArray();
            }
        }
    }
}

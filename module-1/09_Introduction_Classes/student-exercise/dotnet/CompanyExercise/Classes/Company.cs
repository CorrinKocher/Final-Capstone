using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechElevator.Classes
{
    public class Company
    {
        /// <summary>
        /// The company name.
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// The number of employees at the company.
        /// </summary>
        public int NumberOfEmployees { get; set; }

        /// <summary>
        /// The annual revenue of the company.
        /// </summary>
        public decimal Revenue { get; set; }

        /// <summary>
        /// The annual expenses of the company
        /// </summary>
        public decimal Expenses { get; set; }

        /// <summary>
        /// Returns "small" if less than 50 employees, "medium" if between 50 and 250 employees, "large" if greater than 250 employees.
        /// </summary>
        /// <returns></returns>
        /// 

        public string GetCompanySize()
        {
            
            if (NumberOfEmployees < 50)
            {
                return "small";
            }
            if (NumberOfEmployees >= 50 && NumberOfEmployees <= 250)
            {
                return "medium";
            }
            if(NumberOfEmployees > 250)
            {
                return "large";
            }
            else
            {
                return "";
            }
            
        }

        /// <summary>
        /// Returns the result of revenue - expenses.
        /// </summary>
        /// <returns></returns>
        public decimal GetProfit()
        {
            return this.Revenue - this.Expenses;

        }


    }
    
}

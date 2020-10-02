using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using TDD.Classes;

namespace TDD.Tests
{
    [TestClass]
    public class PayrollSystemTests
    {
        // Our requirements:

        // 0. We can create a payroll system
        [TestMethod]
        public void PayrollSystemShouldInitializeCorrectly()
        {
            //arrange
            PayrollSystem system = new PayrollSystem();
            //act
            //Act is the act of creating the system in arrange
            //assert
            Assert.IsNotNull(system);
        }
        // 1. HireEmployee should accept a name and salary and return true
        [TestMethod]
        public void HireEmployeeShouldSucceed()
        {
            //arrange
            PayrollSystem system = new PayrollSystem();
            //act
            bool result = system.HireEmployee("Bruce Wayne", 75000);
            //assert
            Assert.IsTrue(result);
        }
        // 2. A TotalPayroll property which gives us the current total pay
        [TestMethod]
        [DataRow("John Fulton", 1000)]
        [DataRow("Matt Eland", 0)]
        public void TotalPayrollReflectsHiredEmployee(string name, double salary)
        {
            //arrange
            PayrollSystem system = new PayrollSystem();
            system.HireEmployee(name, salary);
            //act
            double result = system.TotalPayroll;
            //assert
            Assert.AreEqual(salary, result);
        }

        // 3. FireEmployee should accept a name and remove that employee from the organization(TotalPayroll should no longer include them)
        [TestMethod]        
        public void FireEmployeeShouldReduceSalary()
        {
            //arrange
            PayrollSystem system = new PayrollSystem();
            system.HireEmployee("Big Head", 42000);

            //act
            system.FireEmployee("Big Head");

            //assert
            Assert.AreEqual(0, system.TotalPayroll);
        }
        // 4. Employees property should return the names of all current employees
        [TestMethod]
        public void FireEmployeeShouldDoNothingWithNonEmployees()
        {
            //arrange
            PayrollSystem system = new PayrollSystem();
           

            //act
            system.FireEmployee("Big Head");

            //assert
            Assert.AreEqual(0, system.TotalPayroll);
        }

        [TestMethod]        
        public void EmployeesShouldListAllEmployees()
        {
            //arrange
            PayrollSystem system = new PayrollSystem();
            system.HireEmployee("Bruce Banner", 75000);
            system.HireEmployee("Peter Parker", 50000);

            //act
            string[] result = system.Employees;

            //assert
            Assert.AreEqual(2, result.Length);
            Assert.AreEqual("Bruce Banner", result[0]);
            Assert.AreEqual("Peter Parker", result[1]);
        }
        [TestMethod]
        public void EmployeesShouldNotBeEmployeesAfterBeingFired()
        {
            //arrange
            PayrollSystem system = new PayrollSystem();
            system.HireEmployee("Milton", 35000);

            //act
            system.FireEmployee("Milton");
            string[] employees = system.Employees;
            //assert
            CollectionAssert.DoesNotContain(system.Employees, "Milton");
        }
        // 5. GiveRaise should increase all current employees salaries by a specific %

    }
}

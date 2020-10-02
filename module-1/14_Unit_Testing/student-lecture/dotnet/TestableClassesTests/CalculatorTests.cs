using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestableClassesTests;
using TestableClasses;
using TestableClasses.Classes;
namespace TestableClassesTests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void CalculatorShouldAddTwoAndTwoCorrectly()
        {
            // Arrange  - Set up the code we want to test
            Calculator calc = new Calculator();
            // Act      - Do some form of an action that we want to verify is correct
            int result = calc.Add(2, 2);
            // Assert   - Verify that the system under test behaved the way we wanted it to
            Assert.AreEqual(4, result);
        }
        [TestMethod]
        public void CalculatorShouldAddTenAndfiveCorrectly()
        {
            Calculator calc = new Calculator();

            int result = calc.Add(10, 5);

            Assert.AreEqual(15, result);
        }
        [TestMethod]
        public void CalculatorShouldDivideFiveAndThree()
        {
            Calculator calc = new Calculator();

            int result = calc.Divide(5, 3);

            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void CalculatorShouldDivideByZero()
        {
            Calculator calc = new Calculator();

            int result = calc.Divide(5, 0);

            Assert.AreEqual(0, result);
        }
        [TestMethod]
        public void CalculatorShouldReturnLargestNumber()
        {
            Calculator calc = new Calculator();

            int[] numbers = { };

            int result = calc.GetLargestValue(numbers);

            Assert.AreEqual(0, result);
        }
    }
}

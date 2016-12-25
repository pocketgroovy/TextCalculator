using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace YoshiMiyamoto.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void getResult_addition()
        {
            string[] inputs = { "2", "3", "4", "Addition" };
            Calculator calculator = new Calculator(inputs);
           
            Assert.AreEqual(9, calculator.getResult());
        }

        [TestMethod()]
        [ExpectedException(typeof(DivideByZeroException))]
        public void getResultTest_divideByZero()
        {
            string[] inputs = { "2", "0", "4", "Division" };

            Calculator calculator = new Calculator(inputs);
            calculator.getResult();         
        }

        [TestMethod()]
        [ExpectedException(typeof(Exception))]
        public void getResultTest_underZero()
        {
            string[] inputs = { "2", "0", "4", "Subtraction" };
            Calculator calculator = new Calculator(inputs);
            calculator.getResult();
        }
    }
}
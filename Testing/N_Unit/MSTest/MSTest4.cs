using System;
using System.Collections.Generic;
using System.Text;

namespace MSTest
{
    [TestClass]
    public class CalculatorTests
    {
        Calculator calc;


        [TestInitialize]
        public void Setup()
        {
            calc = new Calculator();
        }


        [TestMethod]
        public void Divide_Test()
        {
            Assert.AreEqual(5, calc.Divide(10, 2));
        }


        [TestMethod]
        [ExpectedException(typeof(ArithmeticException))]
        public void Divide_ByZero_ShouldThrowException()
        {
            calc.Divide(10, 0);
        }
    }

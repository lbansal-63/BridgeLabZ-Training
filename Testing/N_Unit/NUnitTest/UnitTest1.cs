using NUnit.Framework;
using CalculatorApp;
using System;

namespace NUnitTest
{
    [TestFixture]
    public class UnitTest1
    {
        private Calculator calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [Test]
        public void Add_Test()
        {
            int result = calculator.Add(10, 20);

            Assert.AreEqual(30, result);
        }

        [Test]
        public void Subtract_Test()
        {
            int result = calculator.Subtract(20, 10);

            Assert.AreEqual(10, result);
        }

        [Test]
        public void Multiply_Test()
        {
            int result = calculator.Multiply(5, 4);

            Assert.AreEqual(20, result);
        }

        [Test]
        public void Divide_Test()
        {
            int result = calculator.Divide(20, 5);

            Assert.AreEqual(4, result);
        }

        [Test]
        public void Divide_By_Zero_Test()
        {
            Assert.Throws<DivideByZeroException>(() =>
            {
                calculator.Divide(10, 0);
            });
        }
    }
}

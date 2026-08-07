using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTest
{
    internal class UnitTest5
    {
        [TestFixture]
        public class CalculatorTests
        {
            private Calculator calc;

            [SetUp]
            public void Setup()
            {
                calc = new Calculator();
            }

            [Test]
            public void Divide_ShouldReturnQuotient()
            {
                Assert.AreEqual(5, calc.Divide(10, 2));
            }

            [Test]
            public void Divide_ByZero_ShouldThrowException()
            {
                Assert.Throws<ArithmeticException>(() => calc.Divide(10, 0));
            }
        }
    }
}

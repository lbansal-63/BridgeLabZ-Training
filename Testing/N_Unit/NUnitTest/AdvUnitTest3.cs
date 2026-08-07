using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;


namespace NUnitTest
{
    internal class AdvUnitTest3
    {
        
    [TestFixture]
    public class TemperatureConverterTests
    {
        TemperatureConverter converter;


        [SetUp]
        public void Setup()
        {
            converter = new TemperatureConverter();
        }


        [Test]
        public void CelsiusToFahrenheit_Test()
        {
            Assert.AreEqual(32,converter.CelsiusToFahrenheit(0));
        }


        [Test]
        public void FahrenheitToCelsius_Test()
        {
            Assert.AreEqual(
                0,
                converter.FahrenheitToCelsius(32)
            );
        }
    }
}
}

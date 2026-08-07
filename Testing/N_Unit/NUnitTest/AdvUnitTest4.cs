using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
namespace NUnitTest
{
    internal class AdvUnitTest4
    {
        [TestFixture]
        public class DateFormatterTests
        {
            DateFormatter formatter;


            [SetUp]
            public void Setup()
            {
                formatter = new DateFormatter();
            }


            [Test]
            public void ValidDate_ShouldConvertFormat()
            {
                Assert.AreEqual("25-12-2025",formatter.FormatDate("2025-12-25"));
            }


            [Test]
            public void InvalidDate_ShouldThrowException()
            {
                Assert.Throws<FormatException>(() =>
                {
                    formatter.FormatDate("25/12/2025");
                });
            }
    }
}
}

using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace NUnitTest
{
    internal class UnitTest2
    {
        [TestFixture]
        public class StringUtilsTests
        {
            private StringUtils utils;

            [SetUp]
            public void Setup()
            {
                utils = new StringUtils();
            }

            [Test]
            public void Reverse_ShouldReturnReversedString()
            {
                Assert.AreEqual("olleH", utils.Reverse("Hello"));
            }

            [Test]
            public void IsPalindrome_ShouldReturnTrue()
            {
                Assert.IsTrue(utils.IsPalindrome("madam"));
            }

            [Test]
            public void IsPalindrome_ShouldReturnFalse()
            {
                Assert.IsFalse(utils.IsPalindrome("hello"));
            }

            [Test]
            public void ToUpperCase_ShouldConvertToUpper()
            {
                Assert.AreEqual("HELLO", utils.ToUpperCase("hello"));
            }
        }
    }
}

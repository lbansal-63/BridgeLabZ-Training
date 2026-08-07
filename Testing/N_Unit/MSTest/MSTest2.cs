using System;
using System.Collections.Generic;
using System.Text;

namespace MSTest
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class StringUtilsTests
    {
        StringUtils utils;

        [TestInitialize]
        public void Setup()
        {
            utils = new StringUtils();
        }

        [TestMethod]
        public void Reverse_Test()
        {
            Assert.AreEqual("olleH", utils.Reverse("Hello"));
        }

        [TestMethod]
        public void IsPalindrome_ReturnTrue()
        {
            Assert.IsTrue(utils.IsPalindrome("madam"));
        }

        [TestMethod]
        public void IsPalindrome_ReturnFalse()
        {
            Assert.IsFalse(utils.IsPalindrome("hello"));
        }

        [TestMethod]
        public void ToUpperCase_Test()
        {
            Assert.AreEqual("HELLO", utils.ToUpperCase("hello"));
        }
    }
}

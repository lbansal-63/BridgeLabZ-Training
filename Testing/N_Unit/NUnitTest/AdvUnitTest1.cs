using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTest
{
    internal class AdvUnitTest1
    {
        using NUnit.Framework;


[TestFixture]
    public class PasswordValidatorTests
    {
        PasswordValidator validator;


        [SetUp]
        public void Setup()
        {
            validator = new PasswordValidator();
        }


        [Test]
        public void ValidPassword_ReturnsTrue()
        {
            Assert.IsTrue(
                validator.Validate("Password123")
            );
        }


        [TestCase("pass")]
        [TestCase("password")]
        [TestCase("PASSWORD")]
        public void InvalidPassword_ReturnsFalse(string password)
        {
            Assert.IsFalse(
                validator.Validate(password)
            );
        }
    }
}
}

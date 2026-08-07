using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTest
{
    internal class AdvUnitTest5
    {
        [TestFixture]
        public class UserRegistrationTests
        {
            UserRegistration registration;


            [SetUp]
            public void Setup()
            {
                registration = new UserRegistration();
            }


            [Test]
            public void ValidUser_ShouldRegister()
            {
                bool result =
                registration.RegisterUser(
                "John",
                "john@gmail.com",
                "Pass123");


                Assert.IsTrue(result);
            }


            [Test]
            public void EmptyUsername_ShouldThrowException()
            {
                Assert.Throws<ArgumentException>(() =>
                {
                    registration.RegisterUser(
                    "",
                    "abc@gmail.com",
                    "Pass123");
                });
            }
        }
    }
}

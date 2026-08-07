using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTest
{
    internal class UnitTest6
    {
        [TestFixture]
        public class DatabaseConnectionTests
        {
            private DatabaseConnection db;

            [SetUp]
            public void Setup()
            {
                db = new DatabaseConnection();
                db.Connect();
            }

            [TearDown]
            public void TearDown()
            {
                db.Disconnect();
            }

            [Test]
            public void Connection_ShouldBeEstablished()
            {
                Assert.IsTrue(db.IsConnected);
            }

            [Test]
            public void Disconnect_ShouldCloseConnection()
            {
                db.Disconnect();

                Assert.IsFalse(db.IsConnected);
            }
        }
    }
}

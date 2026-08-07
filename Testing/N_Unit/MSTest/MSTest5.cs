using System;
using System.Collections.Generic;
using System.Text;

namespace MSTest
{
    [TestClass]
    public class DatabaseConnectionTests
    {
        DatabaseConnection db;


        [TestInitialize]
        public void Initialize()
        {
            db = new DatabaseConnection();
            db.Connect();
        }


        [TestCleanup]
        public void Cleanup()
        {
            db.Disconnect();
        }


        [TestMethod]
        public void Connection_ShouldOpen()
        {
            Assert.IsTrue(db.Connected);
        }


        [TestMethod]
        public void Connection_ShouldClose()
        {
            db.Disconnect();

            Assert.IsFalse(db.Connected);
        }
    }

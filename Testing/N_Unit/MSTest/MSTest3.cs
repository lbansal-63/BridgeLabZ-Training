using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Generic;

namespace MSTest
{
    [TestClass]
    public class ListManagerTests
    {
        ListManager manager;
        List<int> list;

        [TestInitialize]
        public void Setup()
        {
            manager = new ListManager();
            list = new List<int>();
        }


        [TestMethod]
        public void AddElement_Test()
        {
            manager.AddElement(list, 10);

            Assert.IsTrue(list.Contains(10));
        }


        [TestMethod]
        public void RemoveElement_Test()
        {
            list.Add(20);

            manager.RemoveElement(list, 20);

            Assert.IsFalse(list.Contains(20));
        }


        [TestMethod]
        public void GetSize_Test()
        {
            list.Add(1);
            list.Add(2);

            Assert.AreEqual(2, manager.GetSize(list));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace NUnitTest
{
    internal class UnitTest4
    {
        [TestFixture]
        public class ListManagerTests
        {
            private ListManager manager;
            private List<int> list;

            [SetUp]
            public void Setup()
            {
                manager = new ListManager();
                list = new List<int>();
            }

            [Test]
            public void AddElement_ShouldAddElement()
            {
                manager.AddElement(list, 10);

                Assert.Contains(10, list);
            }

            [Test]
            public void RemoveElement_ShouldRemoveElement()
            {
                list.Add(20);

                manager.RemoveElement(list, 20);

                Assert.IsFalse(list.Contains(20));
            }

            [Test]
            public void GetSize_ShouldReturnCorrectSize()
            {
                list.Add(1);
                list.Add(2);

                Assert.AreEqual(2, manager.GetSize(list));
            }
        }
    }
}

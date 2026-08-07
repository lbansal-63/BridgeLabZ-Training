using System;
using System.Collections.Generic;
using System.Text;

namespace MSTest
{
    [TestClass]
    public class NumberUtilsTests
    {
        NumberUtils utils = new NumberUtils();


        [TestMethod]
        [DataRow(2, true)]
        [DataRow(4, true)]
        [DataRow(6, true)]
        [DataRow(7, false)]
        [DataRow(9, false)]
        public void IsEven_Test(int number, bool expected)
        {
            Assert.AreEqual(expected, utils.IsEven(number));
        }
    }
}

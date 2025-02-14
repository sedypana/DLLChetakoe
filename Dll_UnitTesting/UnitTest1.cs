using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CalculateLibary;

namespace Dll_UnitTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGetQuantityForProduct_AreNotEqualResultWhenCountIsNull()
        {
            int result = DllFile.GetQuantityForProduct(3, 1, Convert.ToInt32(null), 20, 45);
            int expected = -1;
            Assert.AreNotEqual(expected, result);
        }

        [TestMethod]
        public void TestGetQuantityForProduct_AreEqualResultWhenWidthIsNull()
        {
            int result = DllFile.GetQuantityForProduct(3, 1, 15, Convert.ToInt32(null), 45);
            Assert.AreNotEqual(null, result);
        }

        [TestMethod]
        public void TestGetQuantityForProduct_TypeOfResult()
        {
            int result = DllFile.GetQuantityForProduct(3, 3, 10, 10, 10);
            Assert.IsInstanceOfType(result, typeof(int));
        }

    }
}

﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
    }
}

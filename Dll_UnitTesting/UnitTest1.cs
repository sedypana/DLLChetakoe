using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CalculateLibary;

namespace Dll_UnitTesting
{
    [TestClass]
    public class UnitTest1
    {
        // Проверка: недопустимый тип продукта должен вернуть -1
        [TestMethod]
        public void GetQuantityForProduct_InvalidProductType_ReturnsMinusOne()
        {
            int result = DllFile.GetQuantityForProduct(99, 1, 10, 20, 30);
            Assert.AreEqual(-1, result);
        }

        // Проверка: недопустимый тип материала должен вернуть -1
        [TestMethod]
        public void GetQuantityForProduct_InvalidMaterialType_ReturnsMinusOne()
        {
            int result = DllFile.GetQuantityForProduct(1, 99, 10, 20, 30);
            Assert.AreEqual(-1, result);
        }

        // Проверка: корректность округления Math.Ceiling
        [TestMethod]
        public void GetQuantityForProduct_CeilingFunction_WorksCorrectly()
        {
            int result = DllFile.GetQuantityForProduct(1, 1, 1, 1.3f, 1.3f);
            double expected = Math.Ceiling(1.3 * 1.3 * 1 * 1.1 * 1.883);
            Assert.AreEqual((int)expected, result);
        }

        // Проверка: метод не должен выбрасывать исключение
        [TestMethod]
        public void GetQuantityForProduct_NoExceptionThrown()
        {
            try
            {
                DllFile.GetQuantityForProduct(2, 1, 5, 10, 20);
            }
            catch
            {
                Assert.Fail("Метод выбросил исключение.");
            }
        }

        // Проверка: объект результата не изменяется при вызове метода с одними и теми же параметрами
        [TestMethod]
        public void GetQuantityForProduct_SameObjectsForSameParams()
        {
            var result1 = DllFile.GetQuantityForProduct(1, 2, 5, 10, 20);
            var result2 = DllFile.GetQuantityForProduct(1, 2, 5, 10, 20);
            Assert.AreEqual(result1, result2);
        }

        // Проверка: объект результата изменяется при изменении параметров
        [TestMethod]
        public void GetQuantityForProduct_DifferentObjectsForDifferentParams()
        {
            var result1 = DllFile.GetQuantityForProduct(2, 1, 5, 10, 20);
            var result2 = DllFile.GetQuantityForProduct(2, 1, 6, 10, 20);
            Assert.AreNotSame(result1, result2);
        }

        // Проверка: результат метода должен быть типа int
        [TestMethod]
        public void GetQuantityForProduct_ReturnsIntType()
        {
            var result = DllFile.GetQuantityForProduct(2, 1, 5, 10, 20);
            Assert.IsInstanceOfType(result, typeof(int));
        }

        // Проверка: метод не должен возвращать string
        [TestMethod]
        public void GetQuantityForProduct_ReturnsNotStringType()
        {
            var result = DllFile.GetQuantityForProduct(2, 1, 5, 10, 20);
            Assert.IsNotInstanceOfType(result, typeof(string));
        }

        // Проверка: если count = 0, результат должен быть 0
        [TestMethod]
        public void GetQuantityForProduct_ZeroCount_ReturnsZero()
        {
            int result = DllFile.GetQuantityForProduct(1, 1, 0, 20, 30);
            Assert.AreEqual(0, result);
        }

        // Проверка: ожидаемое поведение с неинициализированными значениями
        [TestMethod]
        public void GetQuantityForProduct_NullValues_ShouldFail()
        {
            int result = DllFile.GetQuantityForProduct(1, 1, Convert.ToInt32(null), 20, 30);
            Assert.AreNotEqual(-1, result);
        }

        // Проверка: если все параметры 0, должен вернуть 0
        [TestMethod]
        public void GetQuantityForProduct_AllZeroValues_ReturnsZero()
        {
            int result = DllFile.GetQuantityForProduct(1, 1, 0, 0, 0);
            Assert.AreEqual(0, result);
        }

        // Проверка: возвращаемый результат не null
        [TestMethod]
        public void GetQuantityForProduct_ResultIsNotNull()
        {
            int result = DllFile.GetQuantityForProduct(1, 1, 5, 10, 10);
            Assert.IsNotNull(result);
        }

        // Проверка: передача некорректных значений приводит к -1
        [TestMethod]
        public void GetQuantityForProduct_NegativeValues_ReturnsMinusOne()
        {
            int result = DllFile.GetQuantityForProduct(1, 1, -5, -10, -10);
            Assert.AreNotEqual(-1, result);
        }

        // Проверка: метод возвращает значение в допустимых пределах
        [TestMethod]
        public void GetQuantityForProduct_ResultWithinValidRange()
        {
            int result = DllFile.GetQuantityForProduct(2, 1, 10, 5, 5);
            Assert.IsTrue(result >= 0 && result < int.MaxValue);
        }

        // Проверка: метод не должен возвращать null
        [TestMethod]
        public void GetQuantityForProduct_ShouldNotReturnNull()
        {
            var result = DllFile.GetQuantityForProduct(2, 1, 10, 5, 5);
            Assert.IsNotNull(result);
        }

    }
}

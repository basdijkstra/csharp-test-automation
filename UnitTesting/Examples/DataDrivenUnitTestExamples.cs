using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using UnitTesting.TestObjects;

namespace UnitTesting.Examples
{
    [TestClass]
    public class DataDrivenUnitTestExamples
    {
        [DataTestMethod]
        [DataRow(2, 5, 7)]
        [DataRow(1, 1, 2)]
        [DataRow(987, 13, 1000)]
        public void StartWith_Add_ShouldBe(int initialValue, int valueToAdd, int expectedResult)
        {
            // Arrange
            Calculator calculator = new Calculator(initialValue);

            // Act
            calculator.Add(valueToAdd);

            // Assert
            Assert.AreEqual(expectedResult, calculator.GetCurrentTotal());
        }

        [DataTestMethod]
        [DynamicData(nameof(GetTestData), DynamicDataSourceType.Method)]
        public void StartWith_DivideBy_ShouldBe(int initialValue, int valueToDivideBy, int expectedResult)
        {
            // Arrange
            Calculator calculator = new Calculator(initialValue);

            // Act
            calculator.Divide(valueToDivideBy);

            // Assert
            Assert.AreEqual(expectedResult, calculator.GetCurrentTotal());
        }

        private static IEnumerable<object[]> GetTestData()
        {
            yield return new object[] { 4, 2, 2 };
            yield return new object[] { 100, 5, 20 };
            yield return new object[] { 12321, 9, 1369 };
        }
    }
}

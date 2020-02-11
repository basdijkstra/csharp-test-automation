using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UnitTesting.TestObjects;

namespace UnitTesting.Examples
{
    [TestClass]
    public class UnitTestExamples
    {
        [TestMethod]
        public void StartWith2_Add5_ShouldBe7()
        {
            // Arrange
            Calculator calculator = new Calculator(2);

            // Act
            calculator.Add(5);

            // Assert
            Assert.AreEqual(7, calculator.GetCurrentTotal());
        }

        [TestMethod]
        public void StartWith4_DivideBy0_ShouldThrowDivideByZeroException()
        {
            // Arrange
            Calculator calc = new Calculator(4);

            // Act and assert
            Assert.ThrowsException<DivideByZeroException>(() => calc.Divide(0));
        }

        [TestMethod]
        public void StartWith4_DivideBy0_ShouldThrowDivideByZeroExceptionWithExpectedMessage()
        {
            // Arrange
            Calculator calc = new Calculator(4);

            // Act
            DivideByZeroException dbze = Assert.ThrowsException<DivideByZeroException>(() => calc.Divide(0));

            // Assert
            Assert.AreEqual("Attempted to divide by zero.", dbze.Message);
        }
    }
}

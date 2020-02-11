using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using UnitTesting.TestObjects;

namespace UnitTesting.Answers
{
    [TestClass]
    public class DataDrivenLoanTestsAnswers
    {
        // Exercise 1
        // Create a new data driven method that performs the following actions three times:
        // 1. Create a new Loan with a given initial amount <initialAmount>
        // 2. Calculate interest on this loan using the interest rate <interestRate>
        // 3. Check that the new loan amount equals <newAmount>
        // for the following values:
        // (initialAmount, interestRate, newAmount)
        // (1000, 0.05, 1050)
        // (500, 0.01, 505)
        // (10000000, 0.10, 11000000)
        // Use the DataRow mechanism to do this

        [DataTestMethod]
        [DataRow(1000, 0.05, 1050)]
        [DataRow(500, 0.01, 505)]
        [DataRow(10000000, 0.10, 11000000)]
        public void CreateLoan_AddInterest_NewAmountShouldBe(double initialAmount, double interestRate, double newAmount)
        {
            // Arrange
            Loan loan = new Loan(initialAmount);

            // Act
            loan.CalculateInterest(interestRate);

            // Assert
            Assert.AreEqual(newAmount, loan.Amount);
        }

        // Exercise 2
        // Repeat exercise 1, but now use the DynamicData mechanism and define a private static method
        // GetTestData() that returns the specified test data rows one at a time (using yield)

        [DataTestMethod]
        [DynamicData(nameof(GetTestData), DynamicDataSourceType.Method)]
        public void CreateLoan_AddInterest_ShouldBe_UsingDynamicData(double initialAmount, double interestRate, double newAmount)
        {
            // Arrange
            Loan loan = new Loan(initialAmount);

            // Act
            loan.CalculateInterest(interestRate);

            // Assert
            Assert.AreEqual(newAmount, loan.Amount);
        }

        private static IEnumerable<object[]> GetTestData()
        {
            yield return new object[] { 1000, 0.05, 1050 };
            yield return new object[] { 500, 0.01, 505 };
            yield return new object[] { 10000000, 0.10, 11000000 };
        }
    }
}

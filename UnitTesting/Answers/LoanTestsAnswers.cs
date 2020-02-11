using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UnitTesting.TestObjects;

namespace UnitTesting.Answers
{
    [TestClass]
    public class LoanTestsAnswers
    {
        // Exercise 1
        // Add the right class-level attribute to enable MSTest to discover tests in this class
        // Import MSTest in this class with the 'using' keyword

        // Exercise 2
        // Write a test method that performs the following steps:
        // 1. Create a new Loan (the default amount of 1000 is OK)
        // 2. Call the CalculateInterest method with an interest rate of 0.05
        // 3. Assert that the new amount is equal to 1050
        [TestMethod]
        public void CreateLoan_Add5Interest_AmountShouldBe1050()
        {
            Loan loan = new Loan();

            loan.CalculateInterest(0.05);

            Assert.AreEqual(1050, loan.Amount);
        }

        // Exercise 3
        // Write a test method that performs the following steps:
        // 1. Create a new Loan (the default amount of 1000 is OK)
        // 2. Call the CalculateInterest method with an interest rate of -0.05
        // 3. Assert that an ArgumentException is thrown
        [TestMethod]
        public void CreateLoan_AddMinus5Interest_ShouldThrowException()
        {
            Loan loan = new Loan();

            Assert.ThrowsException<ArgumentException>(() => loan.CalculateInterest(-0.05));
        }

        // Exercise 4
        // Repeat exercise 3, but now also assert that the exception message equals
        // 'Interest rate should be a positive double value'
        [TestMethod]
        public void CreateLoan_AddMinus5Interest_ShouldThrowExceptionWithMessage()
        {
            Loan loan = new Loan();

            ArgumentException ae = Assert.ThrowsException<ArgumentException>(() => loan.CalculateInterest(-0.05));

            Assert.AreEqual("Interest rate should be a positive double value", ae.Message);
        }
    }
}

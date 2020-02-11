using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting.Exercises
{
    public class LoanTests
    {
        // Exercise 1
        // Add the right class-level attribute to enable MSTest to discover tests in this class
        // Import MSTest in this class with the 'using' keyword

        // Exercise 2
        // Write a test method that performs the following steps:
        // 1. Create a new Loan (the default amount of 1000 is OK)
        // 2. Call the CalculateInterest method with an interest rate of 0.05
        // 3. Assert that the new amount is equal to 1050

        // Exercise 3
        // Write a test method that performs the following steps:
        // 1. Create a new Loan (the default amount of 1000 is OK)
        // 2. Call the CalculateInterest method with an interest rate of -0.05
        // 3. Assert that an ArgumentException is thrown

        // Exercise 4
        // Repeat exercise 3, but now also assert that the exception message equals
        // 'Interest rate should be a positive double value'
    }
}

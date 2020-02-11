using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting.Exercises
{
    [TestClass]
    public class DataDrivenLoanTests
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

        // Exercise 2
        // Repeat exercise 1, but now use the DynamicData mechanism and define a private static method
        // GetTestData() that returns the specified test data rows one at a time (using yield)
    }
}

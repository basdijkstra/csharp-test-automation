using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting.TestObjects
{
    public class Loan
    {
        public double Amount { get; set; } = 1000;

        public Loan()
        {
        }

        public Loan(double initialAmount)
        {
            Amount = initialAmount;
        }

        public void CalculateInterest(double interestRate)
        {
            if (interestRate <= 0)
            {
                throw new ArgumentException("Interest rate should be a positive double value");
            }
            else
            {
                Amount *= (1 + interestRate);
            }
        }
    }
}

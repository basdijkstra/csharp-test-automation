using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting.TestObjects
{
    public class Calculator
    {
        public int CurrentTotal { get; set; }

        public Calculator()
        {
            CurrentTotal = 0;
        }

        public Calculator(int InitialValue)
        {
            CurrentTotal = InitialValue;
        }

        public void SetCurrentTotal(int NewCurrentTotal)
        {
            CurrentTotal = NewCurrentTotal;
        }

        public int GetCurrentTotal()
        {
            return CurrentTotal;
        }

        public void Add(int NumberToAddToCurrentTotal)
        {
            CurrentTotal += NumberToAddToCurrentTotal;
        }

        public void Subtract(int NumberToSubtractFromCurrentTotal)
        {
            CurrentTotal -= NumberToSubtractFromCurrentTotal;
        }

        public void Multiply(int NumberToMultiplyCurrentTotalWith)
        {
            CurrentTotal *= NumberToMultiplyCurrentTotalWith;
        }

        public void Divide(int NumberToDivideCurrentTotalBy)
        {
            CurrentTotal /= NumberToDivideCurrentTotalBy;
        }
    }
}

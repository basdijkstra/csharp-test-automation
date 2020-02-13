using System;

namespace UnitTesting.ObjectOrientedPrinciples
{
    public class Employee : Person
    {
        private int Id = 12345;
        private int Salary = 4000;

        public Employee()
        {
        }

        public override string GetDescription()
        {
            return $"Employee #{Id} ({Name}) is {Age}" +
                $"years old and earns {Salary} monthly";
        }
    }
}

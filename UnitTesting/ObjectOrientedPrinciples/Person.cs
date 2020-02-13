using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting.ObjectOrientedPrinciples
{
    public class Person
    {
        protected string Name = "Jane Doe";
        protected int Age = 35;

        public Person()
        {
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public virtual string GetDescription()
        {
            return $"{Name} is {Age} years old";
        }
    }
}

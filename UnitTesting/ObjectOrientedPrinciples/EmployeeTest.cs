using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTesting.ObjectOrientedPrinciples
{
    [TestClass]
    public class EmployeeTest
    {
        [TestMethod]
        public void TestEmployeeDescription()
        {
            Employee employee = new Employee();

            Assert.AreEqual(
                "Employee #12345 (Jane Doe) is 35 years old and earns 4000 monthly",
                employee.GetDescription()
            );
        }

        [TestMethod]
        public void TestPersonDescription()
        {
            Person person = new Person();

            Assert.AreEqual(
                "Jane Doe is 35 years old",
                person.GetDescription()
            );
        }
    }
}

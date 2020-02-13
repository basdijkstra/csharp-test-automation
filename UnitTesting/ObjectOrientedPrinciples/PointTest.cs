using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTesting.ObjectOrientedPrinciples
{
    [TestClass]
    public class PointTest
    {
        [TestMethod]
        public void CreatePoint_DoubleDistanceToOrigin_CheckDistance()
        {
            Point point = new Point(-3, 4);
            
            Assert.AreEqual(5, point.DistanceToOrigin());

            point.DoubleDistanceToOrigin();

            Assert.AreEqual(10, point.DistanceToOrigin());
        }
    }
}

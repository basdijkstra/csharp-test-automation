namespace UnitTesting.ObjectOrientedPrinciples
{
    public class OnlineOrder : Order
    {
        public OnlineOrder()
        {
        }

        public override bool IsValid()
        {
            // Implementation specific for online orders
            return true;
        }

        public override bool Process()
        {
            // Implementation specific for online sorders
            return true;
        }
    }
}

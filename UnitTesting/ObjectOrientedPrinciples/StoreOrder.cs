namespace UnitTesting.ObjectOrientedPrinciples
{
    public class StoreOrder : Order
    {
        public StoreOrder()
        {
        }

        public override bool IsValid()
        {
            // Implementation specific for store orders
            return true;
        }

        public override bool Process()
        {
            // Implementation specific for store orders
            return true;
        }
    }
}

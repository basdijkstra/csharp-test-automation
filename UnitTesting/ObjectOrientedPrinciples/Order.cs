namespace UnitTesting.ObjectOrientedPrinciples
{
    public abstract class Order
    {
        private int Id = 12345;
        private int CustomerId = 6789;
        private double Amount = 50.99;

        public abstract bool IsValid();
        public abstract bool Process();
        
        public string GetDescription()
        {
            // All order types have the same description
            return $"Order {Id}, placed by customer {CustomerId}, is for {Amount}";
        }
    }
}

namespace UnitTesting.ObjectOrientedPrinciples
{
    public class Car : Vehicle
    {
        private string Make = "Alfa Romeo";
        private string Model = "Giulia";
        private int YearOfProduction = 2019;
        public int CalculateInsurance()
        {
            return 1000;
        }

        public string GetDescription()
        {
            return $"This is a {YearOfProduction} {Make} {Model}";
        }
    }
}

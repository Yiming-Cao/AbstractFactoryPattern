namespace AbstractFactoryPattern.Beverages
{
    internal class ChocolateBeverage : Beverage
    {
        public ChocolateBeverage()
        {
            description = "Chocolate";
        }

        public override double cost()
        {
            return 1.50;
        }
    }
}

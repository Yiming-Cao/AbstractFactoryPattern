using AbstractFactoryPattern.Beverages;

namespace AbstractFactoryPattern.Factories
{
    internal abstract class BeverageFactory
    {
        public Beverage Order(CoffeeMix mix)
        {
            Beverage beverage = CreateBeverage(mix);
            Console.WriteLine($"{mix}: {beverage.GetDescription()} - €{beverage.cost():0.00}");
            return beverage;
        }

        protected abstract Beverage CreateBeverage(CoffeeMix mix);
    }
}

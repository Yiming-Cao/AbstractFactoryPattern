using AbstractFactoryPattern.Beverages;
using AbstractFactoryPattern.Condiments;

namespace AbstractFactoryPattern.Factories
{
    internal class ChocolateBeverageFactory : BeverageFactory
    {
        protected override Beverage CreateBeverage(CoffeeMix mix)
        {
            if (mix != CoffeeMix.ChocolateMilk)
            {
                throw new ArgumentOutOfRangeException(nameof(mix), mix, "This drink is not on the chocolate menu.");
            }

            Beverage beverage = new ChocolateBeverage();
            beverage = new Milk(beverage);
            beverage = new Milk(beverage);
            return beverage;
        }
    }
}

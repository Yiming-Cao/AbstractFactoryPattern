using AbstractFactoryPattern.Beverages;
using AbstractFactoryPattern.Factories;

namespace AbstractFactoryPattern
{
    internal class Barista
    {
        private readonly BeverageFactory factory;

        public Barista(BeverageFactory factory)
        {
            this.factory = factory;
        }

        public Beverage Order(CoffeeMix mix)
        {
            return factory.Order(mix);
        }
    }
}

using AbstractFactoryPattern.Beverages;
using AbstractFactoryPattern.Condiments;

namespace AbstractFactoryPattern.Factories
{
    internal class EspressoBeverageFactory : BeverageFactory
    {
        protected override Beverage CreateBeverage(CoffeeMix mix)
        {
            Beverage beverage = new Espresso();

            switch (mix)
            {
                case CoffeeMix.Espresso:
                    break;
                case CoffeeMix.Doppio:
                    beverage = new EspressoShot(beverage);
                    break;
                case CoffeeMix.Lungo:
                    beverage = new Water(beverage);
                    break;
                case CoffeeMix.Macchiato:
                    beverage = new MilkFoam(beverage);
                    break;
                case CoffeeMix.Corretta:
                    beverage = new Liqour(beverage);
                    break;
                case CoffeeMix.ConPanna:
                    beverage = new Whip(beverage);
                    break;
                case CoffeeMix.Cappuccino:
                    beverage = new SteamedMilk(beverage);
                    beverage = new MilkFoam(beverage);
                    break;
                case CoffeeMix.Americano:
                    beverage = new Water(beverage);
                    beverage = new Water(beverage);
                    break;
                case CoffeeMix.CaffeLatte:
                    beverage = new SteamedMilk(beverage);
                    beverage = new SteamedMilk(beverage);
                    beverage = new MilkFoam(beverage);
                    break;
                case CoffeeMix.FlatWhite:
                    beverage = new SteamedMilk(beverage);
                    beverage = new SteamedMilk(beverage);
                    break;
                case CoffeeMix.Romana:
                    beverage = new Lemon(beverage);
                    break;
                case CoffeeMix.Morocchino:
                    beverage = new Chocolate(beverage);
                    beverage = new MilkFoam(beverage);
                    break;
                case CoffeeMix.Mocha:
                    beverage = new Chocolate(beverage);
                    beverage = new SteamedMilk(beverage);
                    beverage = new Whip(beverage);
                    break;
                case CoffeeMix.Bicerin:
                    beverage = new BlackChocolate(beverage);
                    beverage = new WhiteChocolate(beverage);
                    beverage = new Whip(beverage);
                    break;
                case CoffeeMix.Breve:
                    beverage = new MilkFoam(beverage);
                    beverage = new HalfMilk(beverage);
                    break;
                case CoffeeMix.RafCoffee:
                    beverage = new VanillaSugar(beverage);
                    beverage = new Cream(beverage);
                    break;
                case CoffeeMix.MeadRaf:
                    beverage = new Honey(beverage);
                    beverage = new Cream(beverage);
                    break;
                case CoffeeMix.Galao:
                    beverage = new MilkFoam(beverage);
                    beverage = new MilkFoam(beverage);
                    break;
                case CoffeeMix.CaffeAffogato:
                    beverage = new EspressoShot(beverage);
                    beverage = new IceCream(beverage);
                    break;
                case CoffeeMix.ViennaCoffee:
                    beverage = new EspressoShot(beverage);
                    beverage = new Whip(beverage);
                    beverage = new Whip(beverage);
                    break;
                case CoffeeMix.Glace:
                    beverage = new IceCream(beverage);
                    break;
                case CoffeeMix.DemiCreme:
                    beverage = new EspressoShot(beverage);
                    beverage = new Cream(beverage);
                    beverage = new Cream(beverage);
                    break;
                case CoffeeMix.LatteMacchiato:
                    beverage = new SteamedMilk(beverage);
                    beverage = new SteamedMilk(beverage);
                    beverage = new MilkFoam(beverage);
                    break;
                case CoffeeMix.Freddo:
                    beverage = new Liqour(beverage);
                    beverage = new Ice(beverage);
                    break;
                case CoffeeMix.Frappuccino:
                    beverage = new Ice(beverage);
                    beverage = new SteamedMilk(beverage);
                    beverage = new Whip(beverage);
                    break;
                case CoffeeMix.CaramelFrappuccino:
                    beverage = new Ice(beverage);
                    beverage = new SteamedMilk(beverage);
                    beverage = new Cream(beverage);
                    beverage = new Syrup(beverage);
                    break;
                case CoffeeMix.Frappe:
                    beverage = new SteamedMilk(beverage);
                    beverage = new SteamedMilk(beverage);
                    beverage = new IceCream(beverage);
                    break;
                case CoffeeMix.IrishCoffee:
                    beverage = new EspressoShot(beverage);
                    beverage = new Whiskey(beverage);
                    beverage = new Whip(beverage);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(mix), mix, "This drink is not on the espresso menu.");
            }

            return beverage;
        }
    }
}

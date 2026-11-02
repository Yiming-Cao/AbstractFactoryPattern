using AbstractFactoryPattern.Beverages;
using AbstractFactoryPattern.Factories;

namespace AbstractFactoryPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Barista espressoBarista = new Barista(new EspressoBeverageFactory());
            Barista chocolateBarista = new Barista(new ChocolateBeverageFactory());

            Console.WriteLine("Espresso menu:");
            foreach (CoffeeMix mix in Enum.GetValues<CoffeeMix>())
            {
                if (mix == CoffeeMix.ChocolateMilk)
                {
                    continue;
                }

                espressoBarista.Order(mix);
            }

            Console.WriteLine("\nChocolate menu:");
            chocolateBarista.Order(CoffeeMix.ChocolateMilk);

            Console.WriteLine("\nOff-menu orders are rejected:");
            TryOrder(espressoBarista, CoffeeMix.ChocolateMilk);
            TryOrder(chocolateBarista, CoffeeMix.Espresso);
            TryOrder(espressoBarista, (CoffeeMix)999);
        }

        static void TryOrder(Barista barista, CoffeeMix mix)
        {
            try
            {
                barista.Order(mix);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Rejected {mix}: {ex.Message}");
            }
        }
    }
}

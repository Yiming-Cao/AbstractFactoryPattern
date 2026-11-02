using AbstractFactoryPattern.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Condiments
{
    internal class EspressoShot : CondimentDecorator
    {
        public EspressoShot(Beverage beverage) : base(beverage)
        {
            this.baseBeverage = beverage;
        }

        public override double cost()
        {
            return SizePrice(0.50, 0.55, 0.60) + baseBeverage.cost();
        }

        public override string GetDescription()
        {
            return baseBeverage.GetDescription() + ", Espresso";
        }
    }
}

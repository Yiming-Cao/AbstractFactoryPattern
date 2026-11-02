using AbstractFactoryPattern.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Condiments
{
    internal class Whiskey : CondimentDecorator
    {
        public Whiskey(Beverage beverage) : base(beverage)
        {
            this.baseBeverage = beverage;
        }

        public override double cost()
        {
            return SizePrice(1.00, 1.05, 1.10) + baseBeverage.cost();
        }

        public override string GetDescription()
        {
            return baseBeverage.GetDescription() + ", Whiskey";
        }
    }
}

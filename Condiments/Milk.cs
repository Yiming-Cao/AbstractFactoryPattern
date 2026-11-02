using AbstractFactoryPattern.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Condiments
{
    internal class Milk : CondimentDecorator
    {
        public Milk(Beverage beverage) : base(beverage)
        {
            this.baseBeverage = beverage;
        }

        public override double cost()
        {
            return SizePrice(0.15, 0.20, 0.25) + baseBeverage.cost();
        }

        public override string GetDescription()
        {
            return baseBeverage.GetDescription() + ", Milk";
        }
    }
}

using AbstractFactoryPattern.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Condiments
{
    internal abstract class CondimentDecorator : Beverage
    {
        protected Beverage baseBeverage;

        public CondimentDecorator(Beverage baseBeverage)
        {
            this.baseBeverage = baseBeverage;
        }

        public override Size Size
        {
            get { return baseBeverage.Size; }
            set
            {
                baseBeverage.Size = value;
                base.Size = value;
            }
        }

        public abstract override string GetDescription();

        protected double SizePrice(double tall, double grande, double venti)
        {
            switch (Size)
            {
                case Size.GRANDE:
                    return grande;
                case Size.VENTI:
                    return venti;
                default:
                    return tall;
            }
        }
    }
}

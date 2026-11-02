using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Beverages
{
    enum Size
    {
        TALL,
        GRANDE,
        VENTI
    }
    internal abstract class Beverage
    {
        public virtual Size Size 
        { 
            get { return size; } 
            set { size = value; } 
        }
        private Size size;

        protected string description = "Unknown";

        public virtual string GetDescription()
        {
            return description;
        }

        public abstract double cost();
    }
}

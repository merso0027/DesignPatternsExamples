using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public abstract class CondimentDecorator : Beverage
    {
        protected Beverage beverage;

        public CondimentDecorator(Beverage beverage)
        {
            this.beverage = beverage;
        }
    }
}

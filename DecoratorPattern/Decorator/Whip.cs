using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern.Decorator
{
    public class Whip : CondimentDecorator
    {
        public Whip(Beverage beverage):base(beverage)
        {
        }

        public override double Cost()
        {
            return beverage.Cost() + 0.22;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + " Whip";
        }
    }
}

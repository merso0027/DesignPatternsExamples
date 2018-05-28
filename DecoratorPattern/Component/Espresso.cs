using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern.Component
{
    public class Espresso : Beverage
    {

        public Espresso()
        {
            description = "Espresso";
        }

        public override double Cost()
        {
            return 1.99;
        }
    }
}

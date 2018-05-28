using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern.Component
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            description = "Dark Roast";
        }

        public override double Cost()
        {
            return 1.88;
        }
    }
}

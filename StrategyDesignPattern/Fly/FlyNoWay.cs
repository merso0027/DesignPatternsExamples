using System;

namespace StrategyDesignPattern.Fly
{
    public class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Don't fly");
        }
    }
}

using System;

namespace StrategyDesignPattern.Fly
{
    public class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Fly with wings");
        }
    }
}

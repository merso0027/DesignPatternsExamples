using StrategyDesignPattern.Fly;
using StrategyDesignPattern.Sound;
using System;

namespace StrategyDesignPattern.Birds
{
    public class Canary : Bird
    {
        public Canary()
        {
            base.flyBehavior = new FlyWithWings();
            base.soundBehavior = new Sing();
            Console.WriteLine("Canary");
        }

        public override void Display()
        {
            Console.WriteLine("Canary");
        }
    }
}

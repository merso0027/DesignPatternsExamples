using StrategyDesignPattern.Fly;
using StrategyDesignPattern.Sound;
using System;

namespace StrategyDesignPattern.Birds
{
    public class Duck : Bird
    {
        public Duck()
        {
            base.flyBehavior = new FlyWithWings();
            base.soundBehavior = new Quack();
            Console.WriteLine("Duck");
        }

        public override void Display()
        {
            Console.WriteLine("Display Duck");
        }
    }
}

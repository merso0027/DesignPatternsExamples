using StrategyDesignPattern.Fly;
using StrategyDesignPattern.Sound;
using System;

namespace StrategyDesignPattern.Birds
{
    public class Sparrow : Bird
    {
        public Sparrow()
        {
            flyBehavior = new FlyWithWings();
            soundBehavior = new Sing();
            Console.WriteLine("Sparrow");
        }
        public override void Display()
        {
            Console.WriteLine("Display Sparrow");
        }
    }
}

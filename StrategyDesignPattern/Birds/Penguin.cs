using StrategyDesignPattern.Fly;
using StrategyDesignPattern.Sound;
using System;

namespace StrategyDesignPattern.Birds
{
    public class Penguin : Bird
    {
        public Penguin()
        {
            base.flyBehavior = new FlyNoWay();
            base.soundBehavior = new Mute();
            Console.WriteLine("Penguin");
        }

        public override void Display()
        {
            Console.WriteLine("Display Penguin");
        }
    }
}

using StrategyDesignPattern.Birds;
using StrategyDesignPattern.Fly;
using StrategyDesignPattern.Sound;
using System;

namespace StrategyDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Bird bird1 = new Sparrow();
            bird1.PerformFly();
            bird1.PerformSound();

            Bird bird2 = new Duck();
            bird2.PerformFly();
            bird2.PerformSound();

            Bird bird3 = new Canary();
            bird3.PerformFly();
            bird3.PerformSound();
            bird3.SetFlyBehavior(new FlyNoWay());
            bird3.SetSoundBehavior(new Mute());
            bird3.PerformFly();
            bird3.PerformSound();


            Bird bird4 = new Penguin();
            bird4.PerformFly();
            bird4.PerformSound();

            Console.WriteLine("End of program");
            Console.ReadKey();
        }
    }
}

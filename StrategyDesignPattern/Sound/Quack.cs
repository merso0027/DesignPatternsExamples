using System;

namespace StrategyDesignPattern.Sound
{
    public class Quack : ISoundBehavior
    {
        public void Play()
        {
            Console.WriteLine("Quack");
        }
    }
}

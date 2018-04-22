using System;

namespace StrategyDesignPattern.Sound
{
    public class Sing : ISoundBehavior
    {
        public void Play()
        {
            Console.WriteLine("Sing");
        }
    }
}

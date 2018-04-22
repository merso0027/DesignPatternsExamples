using System;

namespace StrategyDesignPattern.Sound
{
    public class Mute : ISoundBehavior
    {
        public void Play()
        {
            Console.WriteLine("Mute");
        }
    }
}

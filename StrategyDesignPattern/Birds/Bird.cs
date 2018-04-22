using StrategyDesignPattern.Fly;
using StrategyDesignPattern.Sound;

namespace StrategyDesignPattern.Birds
{
    public abstract class Bird
    {
        protected IFlyBehavior flyBehavior;
        protected ISoundBehavior soundBehavior;

        public virtual void PerformFly()
        {
            flyBehavior.Fly();
        }

        public virtual void PerformSound()
        {
            soundBehavior.Play();
        }

        public abstract void Display();
    }
}

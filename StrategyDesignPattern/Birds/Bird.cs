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

        public void SetSoundBehavior(ISoundBehavior soundBehavior)
        {
            this.soundBehavior = soundBehavior;
        }

        public void SetFlyBehavior(IFlyBehavior flyBehavior)
        {
            this.flyBehavior = flyBehavior;
        }
    }
}

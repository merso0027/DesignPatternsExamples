using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverDesginPatternWithEvents
{
    public class CurrentConditionsDisplay
    {
        WeatherData subject;

        public CurrentConditionsDisplay(WeatherData subject)
        {
            this.subject = subject;
        }

        public void Subscribe()
        {
            //Every time the event is raised(from eventHandler(this,EventArgs.Empty);), DoSomething(...) is called
            subject.eventHandler += DoSomething;
        }

        public void UnSubscribe()
        {
            //Now, when the event is raised,
            //DoSomething(...) is no longer called
            subject.eventHandler -= DoSomething;  
        }

        private void DoSomething(object sender, EventArgs e)
        {
            Console.WriteLine("This Observer instance has receiveda notification from its associated Subject.");
        }
        private void DoSomething2()
        {
            Console.WriteLine("This Observer instance has receiveda notification from its associated Subject.");
        }
    }
}

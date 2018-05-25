using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverDesginPatternWithEvents
{
    public class WeatherData
    {
        public event EventHandler eventHandler; //We can also consider
                                                //using an auto-implemented property instead of a public field

        public void NotifyObservers()
        {
            //Ensures that if there are no handlers, the event won't be raised
            if (eventHandler != null)  
            {
                //We can also replace, EventArgs.Empty with our own message
                eventHandler(this, EventArgs.Empty);    
            }
        }
    }
}

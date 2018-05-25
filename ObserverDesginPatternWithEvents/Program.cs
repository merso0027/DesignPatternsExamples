using System;

namespace ObserverDesginPatternWithEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData subject = new WeatherData();
            CurrentConditionsDisplay observer1 = new CurrentConditionsDisplay(subject);

            //subscribe the Observer instances to "subject"
            observer1.Subscribe();

            subject.NotifyObservers();  //both Observer instances' 
                                        //DoSomething(object sender, EventArgs e) method are called

            observer1.UnSubscribe();
            subject.NotifyObservers();  //only observer2's  DoSomething(object sender, EventArgs e) 
                                        //method is called because observer2 has unsubscribed from "subject"

            Console.ReadKey();
        }
    }
}

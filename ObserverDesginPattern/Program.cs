using ObserverDesginPattern.Display;
using System;

namespace ObserverDesginPattern
{
    class Program
    {
        static void Main(string[] args)
        { 
            // Subject
            WeatherData weatherData = new WeatherData();

            // First Observer
            CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);
            // Implement Statistic display
            // Implement Forcast display
            weatherData.SetMeasurements(80, 65, 30.4f);
            weatherData.SetMeasurements(82, 70, 29.2f);
            weatherData.SetMeasurements(78, 90, 29.2f);
            Console.ReadKey();
        }
    }
}

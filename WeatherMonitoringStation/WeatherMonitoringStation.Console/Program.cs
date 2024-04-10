using System;
using WeatherMonitoringStation.Library;

namespace WeatherMonitoringStation.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = WeatherData.GetInstance();
            CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);

            // Simulate weather changes
            weatherData.SetMeasurements(25, 65, 30.4f);

            System.Console.WriteLine("Press any key to exit...");
            System.Console.ReadKey();
        }
    }
}

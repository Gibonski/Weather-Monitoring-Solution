using System;

namespace WeatherMonitoringStation.Library
{
    /// <summary>
    /// Represents an observer for displaying current weather conditions. Implements IDisplay.
    /// </summary>
    public class CurrentConditionsDisplay : IDisplay
    {
        private IWeatherData weatherData;

        public CurrentConditionsDisplay(IWeatherData weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this); // Registering this display as an observer
        }

        /// <summary>
        /// Display method to show current weather data on the display.
        /// </summary>
        public void Display()
        {
            // Access weather data through IWeatherData interface
            Console.WriteLine("Current Conditions: " + 
                              weatherData.GetTemperature() + "C degrees and " +
                              weatherData.GetHumidity() + "% humidity");
        }
    }
}

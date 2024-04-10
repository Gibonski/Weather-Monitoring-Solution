using System;
using System.Collections.Generic;

namespace WeatherMonitoringStation.Library
{
    /// <summary>
    /// Represents the central weather data source. This class follows the Singleton pattern.
    /// </summary>
    public class WeatherData : IWeatherData
    {
        private static WeatherData instance = null!;
        private List<IDisplay> _observers = new List<IDisplay>();

        // Private constructor to prevent instantiation
        private WeatherData() { }

        /// <summary>
        /// Gets the singleton instance of WeatherData.
        /// </summary>
        /// <returns>The singleton instance of WeatherData.</returns>
        public static WeatherData GetInstance()
        {
            if (instance == null)
            {
                instance = new WeatherData();
            }
            return instance;
        }

        /// <summary>
        /// Registers an observer to receive weather updates.
        /// </summary>
        /// <param name="observer">The observer to register.</param>
        public void RegisterObserver(IDisplay observer)
        {
            _observers.Add(observer);
        }

        /// <summary>
        /// Removes an observer from receiving weather updates.
        /// </summary>
        /// <param name="observer">The observer to remove.</param>
        public void RemoveObserver(IDisplay observer)
        {
            _observers.Remove(observer);
        }

        /// <summary>
        /// Notifies all registered observers about weather changes.
        /// </summary>
        public void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Display();
            }
        }

        // Placeholder for actual weather measurements
        private float temperature;
        private float humidity;
        private float pressure;

        /// <summary>
        /// Sets the weather measurements.
        /// </summary>
        /// <param name="temperature">The temperature value.</param>
        /// <param name="humidity">The humidity value.</param>
        /// <param name="pressure">The pressure value.</param>
        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;

            // Notify observers about the changes
            NotifyObservers();
        }

        /// <summary>
        /// Gets the current temperature.
        /// </summary>
        /// <returns>The current temperature.</returns>
        public float GetTemperature()
        {
            return temperature;
        }

        /// <summary>
        /// Gets the current humidity.
        /// </summary>
        /// <returns>The current humidity.</returns>
        public float GetHumidity()
        {
            return humidity;
        }

        /// <summary>
        /// Gets the current pressure.
        /// </summary>
        /// <returns>The current pressure.</returns>
        public float GetPressure()
        {
            return pressure;
        }
    }
}

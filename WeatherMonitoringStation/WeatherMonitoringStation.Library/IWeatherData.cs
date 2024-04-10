namespace WeatherMonitoringStation.Library
{
    /// <summary>
    /// Defines an interface for the weather data provider.
    /// </summary>
    public interface IWeatherData 
    {
        /// <summary>
        /// Gets the current temperature.
        /// </summary>
        /// <returns>The current temperature.</returns>
        float GetTemperature();

        /// <summary>
        /// Gets the current humidity.
        /// </summary>
        /// <returns>The current humidity.</returns>
        float GetHumidity();

        /// <summary>
        /// Registers an observer to receive weather updates.
        /// </summary>
        /// <param name="observer">The observer to register.</param>
        void RegisterObserver(IDisplay observer);

        /// <summary>
        /// Removes an observer from receiving weather updates.
        /// </summary>
        /// <param name="observer">The observer to remove.</param>
        void RemoveObserver(IDisplay observer);

        /// <summary>
        /// Notifies all registered observers about weather changes.
        /// </summary>
        void NotifyObservers();
    }
}

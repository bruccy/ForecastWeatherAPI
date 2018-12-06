using System.Collections.Generic;
using ForecastWeatherAPI.Factory.Attributes;
using ForecastWeatherAPI.Models;
using ForecastWeatherAPI.Repository.Interfaces;

namespace ForecastWeatherAPI.Repository.Implementations
{
    [Implements(typeof(IForecastWeatherRepository))]
    public class ForecastWeatherRepository : IForecastWeatherRepository
    {
        public IList<ForecastWeather> GetForecastWeatherList()
        {
            throw new System.NotImplementedException();
        }
    }
}

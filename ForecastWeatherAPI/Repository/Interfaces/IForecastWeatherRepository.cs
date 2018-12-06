using ForecastWeatherAPI.Models;
using System.Collections.Generic;

namespace ForecastWeatherAPI.Repository.Interfaces
{
    public interface IForecastWeatherRepository
    {
        IList<ForecastWeather> GetForecastWeatherList();
    }
}

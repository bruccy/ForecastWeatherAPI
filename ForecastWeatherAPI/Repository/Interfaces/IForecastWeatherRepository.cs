using ForecastWeatherAPI.Models;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;

namespace ForecastWeatherAPI.Repository.Interfaces
{
    public interface IForecastWeatherRepository: IDisposable
    {
        IList<ForecastWeather> GetForecastWeatherList();

        void EnsureCreated();

        void Insert(IList<ForecastWeather> list);
    }
}

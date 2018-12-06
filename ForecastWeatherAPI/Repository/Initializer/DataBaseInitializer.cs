using ForecastWeatherAPI.Factory;
using ForecastWeatherAPI.Models;
using ForecastWeatherAPI.Repository.Interfaces;
using System;
using System.Collections.Generic;

namespace ForecastWeatherAPI.Repository.Initializer
{
    public static class DataBaseInitializer
    {
        public static void CreateDbAndSampleData()
        {
            using (var repository = InstanceFactory.Create<IForecastWeatherRepository>())
            {
                repository.EnsureCreated();

                var savedList = repository.GetForecastWeatherList();

                if (savedList.Count == 0)
                {
                    var sampleList = new List<ForecastWeather>
                    {
                        new ForecastWeather
                        {
                            Date = new DateTime(2018, 6, 24),
                            TempC = 32,
                            TempF = 89,
                            Summary = "Scorching"
                        },
                        new ForecastWeather
                        {
                            Date = new DateTime(2018, 6, 25),
                            TempC = 45,
                            TempF = 112,
                            Summary = "Mild"
                        },
                        new ForecastWeather
                        {
                            Date = new DateTime(2018, 6, 26),
                            TempC = -4,
                            TempF = 25,
                            Summary = "Mild"
                        },
                        new ForecastWeather
                        {
                            Date = new DateTime(2018, 6, 27),
                            TempC = 16,
                            TempF = 60,
                            Summary = "Balmy"
                        },
                        new ForecastWeather
                        {
                            Date = new DateTime(2018, 6, 28),
                            TempC = 53,
                            TempF = 127,
                            Summary = "Hot"
                        }
                    };

                    repository.Insert(sampleList);
                }
            }
        }
    }
}

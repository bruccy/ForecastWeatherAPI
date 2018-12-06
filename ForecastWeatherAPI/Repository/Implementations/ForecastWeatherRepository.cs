using System.Collections.Generic;
using ForecastWeatherAPI.Factory.Attributes;
using ForecastWeatherAPI.Models;
using ForecastWeatherAPI.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ForecastWeatherAPI.Repository.Implementations
{
    [Implements(typeof(IForecastWeatherRepository))]
    public class ForecastWeatherRepository : DbContext, IForecastWeatherRepository
    {
        public DbSet<ForecastWeather> ForecastsWeather { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=./ForecastsWeather.db");
        }        

        public IList<ForecastWeather> GetForecastWeatherList()
        {
            return ForecastsWeather.ToList();
        }

        public void Insert(IList<ForecastWeather> list)
        {
            ForecastsWeather.AddRange(list);
            SaveChanges();
        }

        public void EnsureCreated()
        {
            Database.EnsureCreated();
        }
    }
}

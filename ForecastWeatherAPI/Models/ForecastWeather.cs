using System;

namespace ForecastWeatherAPI.Models
{
    public class ForecastWeather
    {
        public DateTime Date { get; set; }

        public int TempC { get; set; }

        public int TempF { get; set; }

        public string Summary { get; set; }
    }
}

using System;
using System.ComponentModel.DataAnnotations;

namespace ForecastWeatherAPI.Models
{
    public class ForecastWeather
    {
        [Key]
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public int TempC { get; set; }

        public int TempF { get; set; }

        public string Summary { get; set; }
    }
}

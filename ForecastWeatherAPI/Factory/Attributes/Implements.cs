using System;

namespace ForecastWeatherAPI.Factory.Attributes
{
    public class Implements : Attribute
    {
        public Type Type { get; set; }

        public Implements(Type type)
        {
            Type = type;
        }
    }
}

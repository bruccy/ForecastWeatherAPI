using ForecastWeatherAPI.Factory.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ForecastWeatherAPI.Factory
{
    public class InstanceFactory
    {
        private static Dictionary<Type, Type> _dictionaryInterfaceImplementations;

        static InstanceFactory()
        {
            _dictionaryInterfaceImplementations =
                (from assemblie in AppDomain.CurrentDomain.GetAssemblies()
                 from type in assemblie.GetTypes()
                 let attributes = type.GetCustomAttributes(typeof(Implements), true)
                 where attributes != null && attributes.Length > 0
                 select new
                 {
                     Type = type,
                     Attribute = attributes.FirstOrDefault() as Implements
                 }).ToDictionary(obj => obj.Attribute.Type, obj => obj.Type);
        }

        public static T Create<T>(params object[] args)
        { 
            Type parentType = typeof(T);
            Type typeOfChildren;
            if (_dictionaryInterfaceImplementations.TryGetValue(parentType, out typeOfChildren))
            {
                return (T) Activator.CreateInstance(typeOfChildren, args);
            }
            else
            {
                throw new NotImplementedException(string.Format("Implementation not found for type {0}", parentType.ToString()));
            }
        }
    }
}

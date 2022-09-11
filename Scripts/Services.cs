using System;
using System.Collections.Generic;

namespace ServiceLocator
{
    public static class Services
    {
        private static readonly Dictionary<Type, object> _services = new Dictionary<Type, object>();

        public static T Get<T>()
        {
            if (!_services.TryGetValue(typeof(T), out var service))
            {
                return default(T);
            }

            return (T)service;
        }

        public static void Set<T>(T service)
        {
            _services[typeof(T)] = service;
        }
    }
}
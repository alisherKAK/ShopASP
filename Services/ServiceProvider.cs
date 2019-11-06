using System;
using System.Collections.Generic;
using System.Linq;

namespace Services
{
    public class ServiceProvider
    {
        private static ServiceProvider _instance;
        private Dictionary<Type, Type> _transients;
        private Dictionary<Type, object> _singletons;
        public static ServiceProvider Instance
        {
            get
            {
                if (_instance == null) _instance = new ServiceProvider();

                return _instance;
            }
        }

        private ServiceProvider()
        {
            _transients = new Dictionary<Type, Type>();
            _singletons = new Dictionary<Type, object>();
        }


        public object GetService(Type key)
        {
            if (!IsContainsType(key)) return null;

            if (_singletons.ContainsKey(key))
                return _singletons[key];

            Type imp = _transients[key];
            return CreateInstance(imp);
        }
        public void AddTransient(Type type, Type imp)
        {
            if (IsContainsType(type)) return;

            _transients.Add(type, imp);
        }
        public void AddSingleton(Type type, Type imp)
        {
            if (IsContainsType(type)) return;

            var obj = CreateInstance(imp);

            _singletons.Add(type, obj);
        }
        public void AddTransient<TType, TImp>() => AddTransient(typeof(TType), typeof(TImp));
        public void AddSingleton<TType, TImp>() => AddSingleton(typeof(TType), typeof(TImp));
        public void AddSingleton<TType>() => AddSingleton(typeof(TType), typeof(TType));
        public object GetService<TType>() => GetService(typeof(TType));


        private bool IsContainsType(Type type)
        {
            return _transients.ContainsKey(type) || _singletons.ContainsKey(type);
        }
        private object CreateInstance(Type instType)
        {
            IEnumerable<object> arrgs = instType.GetConstructors()
                .FirstOrDefault()
                .GetParameters()
                .Select(p => GetService(p.ParameterType));

            return Activator.CreateInstance(instType, arrgs.ToArray());
        }
    }
}

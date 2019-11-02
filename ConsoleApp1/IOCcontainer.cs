using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public static class IOCContainer
    {
        private static readonly Dictionary<Type, Func<object>> _instances
            = new Dictionary<Type, Func<object>>();

        private static readonly Dictionary<Type, object> _singletonInstance
                = new Dictionary<Type, object>();

        public static void Add<Type>(Func<object> func)
        {
            _instances[typeof(Type)] = func;
        }

        public static void AddAsSingleton<Type>(Func<object> func)
        {
            _singletonInstance[typeof(Type)] = func?.Invoke();
        }

        public static T Get<T>()
        {
            try
            {
                var isNull = _instances.ContainsKey(typeof(T));
                return isNull ? (T)_instances[typeof(T)].Invoke() :
                    (T)_singletonInstance[typeof(T)];
            }
            catch (Exception ex)
            {
                return default(T);
            }
        }
    }
}

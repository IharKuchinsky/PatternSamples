using System;

namespace Singleton.Implementation
{
    public sealed class DubleCheckSingleton<T> where T : new()
    {
        private static volatile object _instance;
        private static readonly object Locker = new object();

        private DubleCheckSingleton()
        { }

        public static T Instance
        {
            get
            {
                if (_instance == null)
                {
	                lock (Locker)
	                {
		                if (_instance == null)
		                {
			                _instance = new T();
		                }
	                }
                }

                return (T) _instance;
            }
        }
    }
}

namespace DesignPatternsPractice.Creational.Singleton.Exercitii._2
{
    public class SingletonCache
    {
        private static SingletonCache _instance;
        private static readonly object _lock = new object();

        private SingletonCache() { }

        public static SingletonCache GetInstance()
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = new SingletonCache();
                }

                return _instance;
            }
        }
    }
}

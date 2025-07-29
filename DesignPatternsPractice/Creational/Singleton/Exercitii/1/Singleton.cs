namespace DesignPatternsPractice.Structural.Singleton.Exercitii._1
{
    public class Singleton
    {
        private static Singleton _instance;
        private static readonly object _lock = new object();

        private Singleton() {}

        public static Singleton Instance
        {
            get
            {
                lock (_lock) 
                {
                    if (_instance == null) 
                    {
                        _instance = new Singleton();
                    }
                    return _instance;
                }
            }
        }

        public void DoSomething()
        {
            Console.WriteLine("Instance 1");
        }
    }
}

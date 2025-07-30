namespace DesignPatternsPractice.Creational.Singleton.Exercitii._3;

public class DbSingleton
{
    private static DbSingleton _instance;
    private static readonly object _lock = new object();

    private DbSingleton() { }

    public static DbSingleton GetInstance()
    {
        lock (_lock)
        {
            if(_instance == null)
            {
                _instance = new DbSingleton();
            }

            return _instance;
        }
    }
}

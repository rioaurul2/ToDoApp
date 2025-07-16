namespace DesignPatternsPractice.Structural.Singleton;

public class Logger
{
    private static Logger _instance;
    private static readonly object _lock = new object();

    private Logger() { }

    public static Logger Instance
    {
        get
        {
            lock (_lock) // thread safty
            {
                if (_instance == null)
                {
                    _instance = new Logger();
                }

                return _instance;
            }
        }
    }

    public void Log(string message)
    {
        Console.WriteLine($"[{DateTime.Now}] {message}");
    }
}
/*
 *  1. private static Logger _instance;
        Ține instanța unică a clasei.

        Static = aparține clasei, nu unui obiect.

        E folosită pentru a reține o singură instanță pe tot parcursul aplicației.

✅ 2. private static readonly object _lock = new object();
        E folosit pentru synchronizare între thread-uri.

        Împiedică două thread-uri să creeze simultan câte o instanță.

        Fără lock, în aplicații multi-threaded pot apărea mai multe instanțe — ceea ce încalcă principiul Singleton.

✅ 3. private Logger() {}
        Constructorul privat blochează instanțierea din exterior.

        Nimeni nu poate folosi new Logger().

✅ 4. public static Logger Instance
    Verifică dacă există deja o instanță.

    Dacă nu, creează-o.

    Se asigură că se creează o singură dată, chiar dacă mai multe thread-uri încearcă simultan.
 */
public class HomeTheaterFacade
{
    private readonly Amplifier _amp;
    private readonly DvdPlayer _dvd;
    private readonly Projector _projector;
    private readonly Lights _lights;

    public HomeTheaterFacade(Amplifier amp, DvdPlayer dvd, Projector projector, Lights lights)
    {
        _amp = amp;
        _dvd = dvd;
        _projector = projector;
        _lights = lights;
    }

    public void WatchMovie(string movie)
    {
        Console.WriteLine("Get ready to watch a movie...");
        _lights.Dim();
        _projector.On();
        _amp.On();
        _dvd.On();
        _dvd.Play(movie);
    }

    public void EndMovie()
    {
        Console.WriteLine("Shutting movie theater down...");
        _lights.On();
        _projector.Off();
        _amp.Off();
        _dvd.Off();
    }
}

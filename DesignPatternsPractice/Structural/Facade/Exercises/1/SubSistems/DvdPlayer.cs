public class DvdPlayer
{
    public void On() => Console.WriteLine("DVD Player ON");
    public void Off() => Console.WriteLine("DVD Player OFF");
    public void Play(string movie) => Console.WriteLine($"Playing movie: {movie}");
}
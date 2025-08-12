public class RealImage : IImage
{
    private string _fileName;

    public RealImage(string fileName)
    {
        _fileName = fileName;
        LoadFromDisk();
    }

    private void LoadFromDisk()
    {
        Console.WriteLine($"Loading image: {_fileName}");
    }

    public void Display()
    {
        Console.WriteLine($"Displaying image: {_fileName}");
    }
}

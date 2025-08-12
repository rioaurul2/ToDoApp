public class ProxyImage : IImage
{
    private string _fileName;
    private RealImage _realImage;

    public ProxyImage(string fileName)
    {
        _fileName = fileName;
    }

    public void Display()
    {
        // Lazy loading - încărcăm doar la prima afișare
        if (_realImage == null)
        {
            _realImage = new RealImage(_fileName);
        }
        _realImage.Display();
    }
}

namespace DesignPatternsPractice.Structural.Proxy
{
    public class RealDocument : IDocument
    {
        private readonly string _filename;

        public RealDocument(string filename)
        {
            _filename = filename;
            Console.WriteLine($"[RealDocument] Loading document: {_filename}");
        }

        public void Display()
        {
            Console.WriteLine($"[RealDocument] Displaying: {_filename}");
        }
    }
}

namespace DesignPatternsPractice.Structural.Proxy
{
    public class DocumentProxy : IDocument
    {
        private readonly string _filename;
        private readonly string _userRole;
        private RealDocument? _realDocument;

        public DocumentProxy(string filename, string userRole)
        {
            _filename = filename;
            _userRole = userRole;
        }

        public void Display()
        {
            if (_userRole != "Admin")
            {
                Console.WriteLine("[Proxy] Access denied. Only admins can view documents.");
                return;
            }

            _realDocument ??= new RealDocument(_filename);
            _realDocument.Display();
        }
    }
}

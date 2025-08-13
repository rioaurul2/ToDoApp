public abstract class FileProcessor
{
    public void ProcessFile(string path)
    {
        Open(path);
        var data = Parse();
        if (Validate(data))
        {
            Process(data);
        }
        else
        {
            OnValidationFailed(data); // hook
        }
        Close();
    }

    // pași comuni
    protected virtual void Open(string path) => Console.WriteLine($"Open: {path}");
    protected virtual void Close() => Console.WriteLine("Close");

    // pași variabili
    protected abstract object Parse();
    protected abstract void Process(object data);

    // hook (opțional)
    protected virtual bool Validate(object data) => true;
    protected virtual void OnValidationFailed(object data)
        => Console.WriteLine("Validation failed.");
}

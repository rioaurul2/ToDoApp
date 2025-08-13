public class JsonProcessor : FileProcessor
{
    protected override object Parse()
    {
        Console.WriteLine("Parsing JSON...");
        return new { Items = 42 };
    }

    protected override void Process(object data)
    {
        Console.WriteLine("Processing JSON items...");
    }

    // suprascrie hook-ul pentru un warning
    protected override void OnValidationFailed(object data)
    {
        Console.WriteLine("JSON validation failed — skipping.");
    }
}
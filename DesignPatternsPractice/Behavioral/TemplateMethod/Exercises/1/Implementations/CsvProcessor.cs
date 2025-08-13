public class CsvProcessor : FileProcessor
{
    protected override object Parse()
    {
        Console.WriteLine("Parsing CSV...");
        return new { Rows = 100 };
    }

    protected override void Process(object data)
    {
        Console.WriteLine("Processing CSV rows...");
    }

    protected override bool Validate(object data)
    {
        Console.WriteLine("Validating CSV...");
        return true;
    }
}
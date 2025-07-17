namespace DesignPatternsPractice.Structural.Decorator;

internal class SimpleMessage : IMessage
{
    public string GetContent()
    {
        return "Hello";
    }
}

namespace DesignPatternsPractice.Structural.Decorator;

public class EncryptedMessage : MessageDecorator
{
    public EncryptedMessage(IMessage message) : base(message) { }

    public override string GetContent()
    {
        return $"Encrypted({_message.GetContent()})";
    }
}

namespace DesignPatternsPractice.Structural.Decorator
{
    public abstract class MessageDecorator
    {
        protected IMessage _message;

        public MessageDecorator(IMessage message)
        {
            _message = message;
        }

        public abstract string GetContent();
    }
}

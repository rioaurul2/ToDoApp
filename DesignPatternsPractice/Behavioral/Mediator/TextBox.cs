namespace DesignPatternsPractice.Behavioral.Mediator
{
    public class TextBox
    {
        public void Clear()
        {
            Console.WriteLine("📄 TextBox cleared");
        }

        public void ShowMessage(string message)
        {
            Console.WriteLine($"📝 TextBox: {message}");
        }
    }
}

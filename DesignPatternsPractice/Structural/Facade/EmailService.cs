namespace DesignPatternsPractice.Structural.Facade
{
    public class EmailService
    {
        public void SendConfirmation(string user)
        {
            Console.WriteLine($"[Email] Trimitere email de confirmare către {user}");
        }
    }
}

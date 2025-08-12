public class UserServiceLoggingProxy : IUserService
{
    private readonly IUserService _realService;

    public UserServiceLoggingProxy(IUserService realService)
    {
        _realService = realService;
    }

    public void CreateUser(string username)
    {
        Console.WriteLine($"[LOG] Creating user: {username}");
        _realService.CreateUser(username);
        Console.WriteLine($"[LOG] User '{username}' creation finished.");
    }

    public void DeleteUser(string username)
    {
        Console.WriteLine($"[LOG] Deleting user: {username}");
        _realService.DeleteUser(username);
        Console.WriteLine($"[LOG] User '{username}' deletion finished.");
    }
}

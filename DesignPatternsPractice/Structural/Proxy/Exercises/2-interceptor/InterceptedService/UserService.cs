public class UserService : IUserService
{
    public void CreateUser(string username)
    {
        Console.WriteLine($"[UserService] User '{username}' created.");
    }

    public void DeleteUser(string username)
    {
        Console.WriteLine($"[UserService] User '{username}' deleted.");
    }
}

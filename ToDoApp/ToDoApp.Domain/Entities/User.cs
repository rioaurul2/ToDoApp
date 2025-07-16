namespace ToDoApp.Domain.Entities;

public class User
{
    public Guid Id { get; set; } = default!;
    public string Name { get; set; } = default!;
    public string Email { get; set; } = default!;
    public string PasswordHash { get; set; } = default!;
    public string PasswordSalt { get; set; } = default!;
    public string UserName { get; set; } = default!;
    public List<TaskItem> UserTasks { get; set; } = [];
}

namespace ToDoApp.Application.DTOs;

public class TaskItemDto
{
    public string Name { get; set; } = default!;
    public string? Description { get; set; }
    public DateTime DataOraPlanificare { get; set; }
    public Guid UserId { get; set; }
}

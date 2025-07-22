namespace ToDoApp.Application.DTOs;

public class CreateTaskItemDto
{
    public string Name { get; set; } = default!;
    public string? Description { get; set; }
    public DateTime DataOraPlanificare { get; set; }
}

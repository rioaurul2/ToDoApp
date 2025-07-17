namespace ToDoApp.API.DTOs
{
    public class CreateTaskItemDto
    {
        public string Name { get; set; } = default!;
        public string? Description { get; set; }
        public DateTime DataOraPlanificare { get; set; }
    }
}

namespace ToDoApp.API.DTOs
{
    public class CreateTaskDto
    {
        public string Name { get; set; } = default!;
        public string? Description { get; set; }
        public DateTime DataOraPlanificare { get; set; }
        public Guid UserId { get; set; }
    }
}

using FluentValidation;
using ToDoApp.Application.DTOs;

namespace ToDoApp.Application.Validators
{
    public class CreateTaskItemDtoValidator : AbstractValidator<CreateTaskItemDto>
    {
        public CreateTaskItemDtoValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Title is required.")
                .MaximumLength(100).WithMessage("Title cannot exceed 100 characters.");

            RuleFor(x => x.Description)
                .MaximumLength(500).WithMessage("Description cannot exceed 500 characters.");
        }
    }
}

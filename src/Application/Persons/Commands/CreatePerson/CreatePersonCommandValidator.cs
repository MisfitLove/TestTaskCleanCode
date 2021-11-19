using FluentValidation;

namespace CleanArchitecture.Application.Persons.Commands.CreatePerson
{
    public class CreatePersonCommandValidator : AbstractValidator<CreatePersonCommand>
    {
        public CreatePersonCommandValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty();
            RuleFor(x => x.LastName)
                .NotEmpty()
                .When(x => x.LastName is not null, ApplyConditionTo.CurrentValidator);
            RuleFor(x => x.Email)
                .NotEmpty()
                .When(x => x.Email is not null, ApplyConditionTo.CurrentValidator);
        }
    }
}
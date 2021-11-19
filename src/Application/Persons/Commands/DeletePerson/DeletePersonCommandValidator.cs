using FluentValidation;

namespace CleanArchitecture.Application.Persons.Commands.DeletePerson
{
    public class DeletePersonCommandValidator : AbstractValidator<DeletePersonCommand>
    {
        public DeletePersonCommandValidator()
        {
            RuleFor(x => x.PersonId).NotEmpty();
        }
    }
}
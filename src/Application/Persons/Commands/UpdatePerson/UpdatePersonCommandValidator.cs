using FluentValidation;

namespace CleanArchitecture.Application.Persons.Commands.UpdatePerson
{
    public class UpdatePersonCommandValidator : AbstractValidator<UpdatePersonCommand>
    {
        public UpdatePersonCommandValidator()
        {
        }
    }
}
using System;
using MediatR;

namespace CleanArchitecture.Application.Persons.Commands.CreatePerson
{
    public class CreatePersonCommand  : IRequest<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}
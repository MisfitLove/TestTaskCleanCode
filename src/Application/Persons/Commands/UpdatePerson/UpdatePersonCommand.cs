using System.Collections.Generic;
using Domain.Entities;
using MediatR;

namespace CleanArchitecture.Application.Persons.Commands.UpdatePerson
{
    public class UpdatePersonCommand : IRequest
    {
        public string? FirstName { get; }
        public string? LastName { get; }
        public string? Email { get; }
        public List<Address>? Addresses { get; }

        public UpdatePersonCommand(string firstName, string lastName, string email, List<Address> addresses)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Addresses = addresses;
        }
    }
}
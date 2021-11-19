using System;
using MediatR;

namespace CleanArchitecture.Application.Persons.Commands.DeletePerson
{
    public class DeletePersonCommand : IRequest
    {
        public Guid PersonId { get; }

        public DeletePersonCommand(Guid personId)
        {
            PersonId = personId;
        }
    }
}
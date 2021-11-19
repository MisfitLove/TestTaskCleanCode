using System.Threading;
using System.Threading.Tasks;
using CleanArchitecture.Application.Common.Exceptions;
using CleanArchitecture.Application.Common.Interfaces;
using CleanArchitecture.Domain.Events.Persons;
using Domain.Entities;
using MediatR;

namespace CleanArchitecture.Application.Persons.Commands.DeletePerson
{
    public class DeletePersonCommandHandler : IRequestHandler<DeletePersonCommand>
    {
        private readonly IApplicationDbContext _context;

        public DeletePersonCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(DeletePersonCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.Persons.FindAsync(request.PersonId, cancellationToken);

            if (entity == null)
            {
                throw new NotFoundException(nameof(Person), request.PersonId);
            }

            _context.Persons.Remove(entity);

            entity.DomainEvents.Add(new PersonDeletedEvent(entity));

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;        }
    }
}
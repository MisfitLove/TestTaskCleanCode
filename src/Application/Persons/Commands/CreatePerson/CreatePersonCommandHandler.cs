using System;
using System.Threading;
using System.Threading.Tasks;
using CleanArchitecture.Application.Common.Interfaces;
using Domain.Entities;
using MediatR;

namespace CleanArchitecture.Application.Persons.Commands.CreatePerson
{
    public class CreatePersonCommandHandler : IRequestHandler<CreatePersonCommand, Guid>
    {
        private readonly IApplicationDbContext _applicationDbContext;

        public CreatePersonCommandHandler(IApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<Guid> Handle(CreatePersonCommand request, CancellationToken cancellationToken)
        {
            var entity = new Person()
            {
                PersonId = Guid.NewGuid(),
                FirstName = request.FirstName,
                LastName = request.LastName,
                Email = request.Email
            };

            _applicationDbContext.Persons.Add(entity);
            await _applicationDbContext.SaveChangesAsync(cancellationToken);

            return entity.PersonId;
        }
    }
}
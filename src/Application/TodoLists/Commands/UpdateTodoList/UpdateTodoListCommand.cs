using System;
using System.Collections.Generic;
using System.Linq;
using CleanArchitecture.Application.Common.Exceptions;
using CleanArchitecture.Application.Common.Interfaces;
using CleanArchitecture.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Application.TodoLists.Commands.UpdateTodoList
{
    public class UpdateTodoListCommand : IRequest
    {
        public int Id { get; set; }

        public string Title { get; set; }
        
        public IReadOnlyCollection<Guid> PersonIds { get; set; }
    }

    public class UpdateTodoListCommandHandler : IRequestHandler<UpdateTodoListCommand>
    {
        private readonly IApplicationDbContext _context;

        public UpdateTodoListCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(UpdateTodoListCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.TodoLists.FindAsync(request.Id);

            if (entity == null)
            {
                throw new NotFoundException(nameof(TodoList), request.Id);
            }

            var persons = await _context.Persons
                .Where(x => request.PersonIds.Contains(x.PersonId))
                .ToArrayAsync(cancellationToken);

            entity.Persons = persons;
            entity.Title = request.Title;
            

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}

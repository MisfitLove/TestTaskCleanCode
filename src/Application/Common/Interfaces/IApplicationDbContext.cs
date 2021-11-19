using CleanArchitecture.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;
using Domain.Entities;

namespace CleanArchitecture.Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<TodoList> TodoLists { get; set; }

        DbSet<TodoItem> TodoItems { get; set; }
        
        // Persons is archaic, and it is safe to avoid using it, except in legal writing, which has its own traditional language.
        DbSet<Person> Persons { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}

using System;
using System.Collections.Generic;
using CleanArchitecture.Domain.Common;
using CleanArchitecture.Domain.Entities;

namespace Domain.Entities
{
    public class Person : AuditableEntity, IHasDomainEvent
    {
        public Guid PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public List<Address> Addresses { get; set; }
        public IReadOnlyCollection<TodoList> TodoLists { get; set; }
        public List<DomainEvent> DomainEvents { get; set; } = new List<DomainEvent>();
    }
}
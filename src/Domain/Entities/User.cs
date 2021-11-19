using System;
using System.Collections.Generic;
using CleanArchitecture.Domain.Common;

namespace Domain.Entities
{
    public class User : AuditableEntity, IHasDomainEvent
    {
        public Guid UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public List<Address> Addresses { get; set; }
        public List<DomainEvent> DomainEvents { get; set; } = new List<DomainEvent>();
    }
}
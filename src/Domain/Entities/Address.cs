using System;
using System.Collections.Generic;
using CleanArchitecture.Domain.Common;

namespace Domain.Entities
{
    public class Address : AuditableEntity, IHasDomainEvent
    {
        public Guid AddressId { get; set; }
        public Guid UserId { get; set; }
        public string Country { get; set;}
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string StreetName { get; set; }
        public ushort StreetNumber { get; set; } 
        public ushort HouseNumber { get; set;}
        public bool IsPrimary { get; set; }
        public List<DomainEvent> DomainEvents { get; set; } = new List<DomainEvent>();
    }
}
using CleanArchitecture.Domain.Common;
using Domain.Entities;

namespace CleanArchitecture.Domain.Events.Persons
{
    public class PersonCreatedEvent : DomainItemEvent<Person>
    {
        public PersonCreatedEvent(Person item) : base(item)
        {
        }
    }
}
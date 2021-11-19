using CleanArchitecture.Domain.Common;
using Domain.Entities;

namespace CleanArchitecture.Domain.Events.Persons
{
    public class PersonDeletedEvent : DomainItemEvent<Person>
    {
        public PersonDeletedEvent(Person item) : base(item)
        {
        }
    }
}
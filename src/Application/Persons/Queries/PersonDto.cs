using System;
using CleanArchitecture.Application.Common.Mappings;
using Domain.Entities;

namespace CleanArchitecture.Application.Persons.Queries
{
    public class PersonDto : IMapFrom<Person>
    {
        public Guid PersonId { get; set; }
        
        public string FirstName { get; set; }
        
        public string LastName { get; set; }
        
        public string Email { get; set; }
    }
}
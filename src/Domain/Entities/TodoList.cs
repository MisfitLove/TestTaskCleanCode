using System;
using CleanArchitecture.Domain.Common;
using CleanArchitecture.Domain.ValueObjects;
using System.Collections.Generic;
using Domain.Entities;

namespace CleanArchitecture.Domain.Entities
{
    public class TodoList : AuditableEntity
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public Colour Colour { get; set; } = Colour.White;
        
        public IReadOnlyCollection<Person> Persons { get; set; }

        public IList<TodoItem> Items { get; private set; } = new List<TodoItem>();
    }
}

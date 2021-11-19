using CleanArchitecture.Domain.Common;
using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Domain.Events.ToDoItems
{
    public class TodoItemCreatedEvent : DomainItemEvent<TodoItem>
    {
        public TodoItemCreatedEvent(TodoItem item) : base(item)
        {
        }
    }
}

using CleanArchitecture.Domain.Common;
using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Domain.Events.ToDoItems
{
    public class TodoItemDeletedEvent : DomainItemEvent<TodoItem>
    {
        public TodoItemDeletedEvent(TodoItem item) : base(item)
        {
        }
    }
}

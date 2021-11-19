using CleanArchitecture.Domain.Common;
using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Domain.Events.ToDoItems
{
    public class TodoItemCompletedEvent : DomainItemEvent<TodoItem>
    {
        public TodoItemCompletedEvent(TodoItem item) : base(item)
        {
        }
    }
}

using System.Threading;
using System.Threading.Tasks;
using CleanArchitecture.Application.Common.Models;
using CleanArchitecture.Domain.Events.Persons;
using MediatR;
using Microsoft.Extensions.Logging;

namespace CleanArchitecture.Application.TodoItems.EventHandlers
{
    public class PersonCreatedEventHandler : INotificationHandler<DomainEventNotification<PersonCreatedEvent>>
    {
        private readonly ILogger<PersonCreatedEventHandler> _logger;

        public PersonCreatedEventHandler(ILogger<PersonCreatedEventHandler> logger)
        {
            _logger = logger;
        }

        public Task Handle(DomainEventNotification<PersonCreatedEvent> notification,
            CancellationToken cancellationToken)
        {
            var domainEvent = notification.DomainEvent;

            _logger.LogInformation("CleanArchitecture Domain Event: {DomainEvent}", domainEvent.GetType().Name);

            return Task.CompletedTask;
        }
    }
}
using System.Collections.Generic;

namespace CleanArchitecture.Domain.Common
{
    public abstract class DomainItemEvent<TItem> : DomainEvent
        where TItem : IHasDomainEvent
    {
        public TItem Item;

        protected DomainItemEvent(TItem item)
        {
            Item = item;
        }
    }
}
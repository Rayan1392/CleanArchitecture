using MarketScreener.Domain.Common;

namespace MarketScreener.Application.Common.Interfaces;

public interface IDomainEventService
{
    Task Publish(DomainEvent domainEvent);
}


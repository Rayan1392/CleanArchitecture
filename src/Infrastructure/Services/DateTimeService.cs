using MarketScreener.Application.Common.Interfaces;

namespace MarketScreener.Infrastructure.Services;

public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}


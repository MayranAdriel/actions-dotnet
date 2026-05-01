using EventScheduler.Domain.Entities;

namespace EventScheduler.Application.Contracts.Events
{
    public interface IEventsService
    {
        IEnumerable<Event> GetEvents();    
    }
}

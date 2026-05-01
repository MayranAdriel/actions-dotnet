using EventScheduler.Application.Contracts.Events;
using EventScheduler.Domain.Entities;

namespace EventScheduler.Application.Services.Events
{
    public class EventsService : IEventsService
    {
        public IEnumerable<Event> GetEvents()
        {
            return 
            [
                new Event { Name = "Event 1", Date = DateTime.Now, Address = "Address 1" },
                new Event { Name = "Event 2", Date = DateTime.Now.AddDays(1), Address = "Address 2" }
            ];
        }
    }
}

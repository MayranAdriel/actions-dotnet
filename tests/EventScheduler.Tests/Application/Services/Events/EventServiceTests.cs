using EventScheduler.Application.Contracts.Events;
using EventScheduler.Application.Services.Events;
using EventScheduler.Domain.Entities;
using NSubstitute;

namespace EventScheduler.Tests.Application.Services.Events
{
    public class EventServiceTests
    {
        private readonly IEventsService _service;
        public EventServiceTests()
        {
            _service = Substitute.For<IEventsService>();
        }

        [Fact]
        public void WhenServiceIsCalled_ThenReturnEventsCorrectly()
        {
            var expectedEvents = new List<Event>
            {
                new Event { Name = "Event 1", Date = DateTime.Now, Address = "Address 1" },
                new Event { Name = "Event 2", Date = DateTime.Now.AddDays(1), Address = "Address 2" }
            };
            _service.GetEvents().Returns(expectedEvents);

            var events = _service.GetEvents();

            Assert.NotNull(events);
            Assert.Equal(expectedEvents.Count, events.Count());
            Assert.Equal(expectedEvents[0].Name, events.First().Name);
            Assert.Equal(expectedEvents[0].Date, events.First().Date);
            Assert.Equal(expectedEvents[0].Address, events.First().Address);

            Assert.Equal(expectedEvents[1].Name, events.Last().Name);
            Assert.Equal(expectedEvents[1].Date, events.Last().Date);
            Assert.Equal(expectedEvents[1].Address, events.Last().Address);
        }
    }
}

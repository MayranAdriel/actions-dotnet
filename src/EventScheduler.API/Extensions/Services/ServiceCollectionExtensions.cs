using EventScheduler.Application.Contracts.Events;
using EventScheduler.Application.Services.Events;

namespace EventScheduler.API.Extensions.Services
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IEventsService, EventsService>();
            return services;
        }
    }
}

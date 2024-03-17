using NameApp.Application.User.EventHandlers;
using NameApp.Domain.User.Events;
using NameApp.Domain.User.Services;
using NameApp.Infrastructure.EventDispatcher;

namespace NameApp.Domain
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDomainServices(this IServiceCollection services)
        {
            services.AddScoped<IEventSubscriber<UserCreated>, UserCreatedSubsciber>();

            services.AddScoped<PasswordService, PasswordService>();
            services.AddScoped<UserEntityService, UserEntityService>();

            return services; 
        }
    }
}

﻿using NameApp.Application.Common.IoC;
using NameApp.Infrastructure.EventDispatcher;
using System.Reflection;

namespace NameApp.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            var eventDispatcher = new EventDispatcher();

            eventDispatcher.RegisterEventSubscribers(Assembly.GetExecutingAssembly()); 

            services.AddScoped<IIoContainer, IoContainer>();
            services.AddSingleton<IEventDispatcher, EventDispatcher>(x => { return eventDispatcher; });


            return services; 
        }
    }
}

﻿using NameApp.Application.Common.IoC;

namespace NameApp.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IIoContainer, IoContainer>();

            return services; 
        }
    }
}
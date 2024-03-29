﻿using NameApp.Domain.AccessService.Services;
using NameApp.Domain.User.Services;

namespace NameApp.Domain
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDomainServices(this IServiceCollection services)
        {
            services.AddScoped<PasswordService, PasswordService>(
                x => {
                    return new PasswordService(passwordHasher: new PasswordHasher<UserEntity>());
                }
            );
            services.AddScoped<UserEntityService, UserEntityService>();
            services.AddScoped<PermissionEntityService, PermissionEntityService>();

            return services; 
        }
    }
}

using NameApp.Application.Common.Interfaces;
using NameApp.Application.Common.IoC;
using NameApp.Application.User;
using NameApp.Application.User.Interfaces;
using NameApp.Domain.AccessService.Services;
using NameApp.Domain.User.Services;

namespace NameApp.Application
{
    public class IoContainer : IIoContainer
    {
        private IApplicationDbContext context { get; set; }
        private UserEntityService userService { get; set; }
        private PermissionEntityService permService { get; set; }

        public IoContainer(IApplicationDbContext dbContext, UserEntityService service, PermissionEntityService permissionService) {
            context = dbContext;
            userService = service;
            permService = permissionService;
        }

        public IUserService User()
        {
            return new UserService(
                dbContext: context, 
                userEntityService: userService, 
                permissionService: permService
            );
        }
    }
}

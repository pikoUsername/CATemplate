using NameApp.Application.Common.Interfaces;
using NameApp.Application.User.Interactors;
using NameApp.Application.User.Interfaces;
using NameApp.Domain.AccessService.Services;
using NameApp.Domain.User.Services;

namespace NameApp.Application.User
{
    public class UserService : IUserService
    {
        private readonly IApplicationDbContext _context;
        private readonly UserEntityService _serviceEntity;
        private readonly PermissionEntityService _permissionService; 

        public UserService(
            IApplicationDbContext dbContext,
            UserEntityService userEntityService,
            PermissionEntityService permissionService
        ) {
            _permissionService = permissionService; 
            _serviceEntity = userEntityService;
            _context = dbContext;
        }

        public RegisterInteractor RegisterInteractor()
        {
            return new RegisterInteractor(
                dbContext: _context,
                userEntityService: _serviceEntity, 
                permissionService: _permissionService
            ); 
        }
    }
}

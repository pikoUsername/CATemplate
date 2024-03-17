using NameApp.Application.Common.Interfaces;
using NameApp.Application.User.Interactors;
using NameApp.Application.User.Interfaces;
using NameApp.Domain.User.Services;

namespace NameApp.Application.User
{
    public class UserService : IUserService
    {
        private readonly IApplicationDbContext _context;
        private readonly UserEntityService _serviceEntity;

        public UserService(
            IApplicationDbContext dbContext,
            UserEntityService userEntityService
        ) { 
            _serviceEntity = userEntityService;
            _context = dbContext;
        }

        public RegisterInteractor RegisterInteractor()
        {
            return new RegisterInteractor(
                dbContext: _context,
                userEntityService: _serviceEntity
            ); 
        }
    }
}

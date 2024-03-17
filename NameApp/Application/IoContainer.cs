using Microsoft.EntityFrameworkCore;
using NameApp.Application.Common.Interfaces;
using NameApp.Application.Common.IoC;
using NameApp.Application.User;
using NameApp.Application.User.Interfaces;
using NameApp.Domain.User.Services;

namespace NameApp.Application
{
    public class IoContainer : IIoContainer
    {
        private IApplicationDbContext _context { get; set; }
        private UserEntityService _userService { get; set; }

        public IoContainer(IApplicationDbContext dbContext, UserEntityService service) {
            _context = dbContext;
            _userService = service; 
        }

        public IUserService User()
        {
            return new UserService(
                dbContext: _context, 
                userEntityService: _userService
            );
        }
    }
}

using Microsoft.EntityFrameworkCore;
using NameApp.Application.Common.Interactors;
using NameApp.Application.Common.Interfaces;
using NameApp.Application.User.Dto;
using NameApp.Application.User.Exceptions;
using NameApp.Application.User.Interfaces;
using NameApp.Domain.User.Entities;
using NameApp.Domain.User.Services;

namespace NameApp.Application.User.Interactors
{
    public class RegisterInteractor : BaseInteractor<RegisterDto, UserEntity>
    {
        private readonly IApplicationDbContext _context;
        private readonly UserEntityService _userService; 

        public RegisterInteractor(
            IApplicationDbContext dbContext, 
            UserEntityService userEntityService)
        {
            _context = dbContext;
            _userService = userEntityService; 
        }

        public async Task<UserEntity> Execute(RegisterDto dto)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.EmailAddress == dto.EmailAddress); 
            if (user != null)
            {
                throw new UserAlreadyExists(dto.EmailAddress, "EmailAddress"); 
            }
            var newUser = _userService.Create(
                UserName: dto.UserName, 
                email: dto.EmailAddress, 
                password: dto.Password); 

            await _context.Users.AddAsync(newUser);
            await _context.SaveChangesAsync();

            return newUser; 
        }
    }
}

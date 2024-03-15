using NameApp.Application.Common.Interactors;
using NameApp.Application.User.Dto;

namespace NameApp.Application.User.Interactors
{
    public class RegisterInteractor : BaseInteractor<RegisterDto, UserDto>
    {
        public RegisterInteractor()
        {
            
        }

        public async Task<UserDto> Execute(RegisterDto dto)
        {
            return new UserDto(); 
        }
    }
}

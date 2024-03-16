using Microsoft.AspNetCore.Mvc;
using NameApp.Application.User.Dto;
using NameApp.Presentation.Web.Schemas;
using Swashbuckle.AspNetCore.Annotations;

namespace NameApp.Presentation.Web.Controllers
{
    [SwaggerTag("auth")]
    [Route("api/user/")]
    [ApiController]
    public class UserControllers
    {
        public IIoContainer _ioContainer;

        public UserControllers(IIoContainer container)
        {
            _ioContainer = container; 
        }

        [HttpPost("register")]
        public async Task<UserScheme> Register()
        {
            RegisterDto dto = new RegisterDto();
            var result = await _ioContainer
                .UserService()
                .RegisterInteractor()
                .Execute(dto);
            return UserScheme.FromUserDTO(result); 
        }
    }
}

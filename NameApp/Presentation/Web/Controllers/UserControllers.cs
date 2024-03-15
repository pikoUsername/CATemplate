using Microsoft.AspNetCore.Mvc;
using NameApp.Presentation.Web.Schemas;
using Swashbuckle.AspNetCore.Annotations;
using System.ComponentModel;

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
            var result = await _ioContainer
                .UserService()
                .Register()
                .Execute();
            return UserScheme.FromDTO(result); 
        }
    }
}

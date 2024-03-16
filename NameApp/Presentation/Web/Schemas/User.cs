using NameApp.Application.User.Dto;
using System.ComponentModel.DataAnnotations;

namespace NameApp.Presentation.Web.Schemas
{
    public class UserScheme
    {
        [Required]
        Guid Id { get; set; }
        [Required]
        public string Name { get; set; } = null!;
        [Required]
        public string EmailAddress { get; set; } = null!;

        public static UserScheme FromUserDTO(UserDto dto)
        {
            return new UserScheme {
                Id = dto.Id,
                Name = dto.Name, 
                EmailAddress = dto.EmailAddress 
            };
        }
    }

    public class CreateUserScheme {
        [Required]
        public string Name { get; set; } = null!;
        [Required]
        public string Password { get; set; } = null!;
        [Required]
        public string EmailAddress { get; set; } = null!;
    }
}

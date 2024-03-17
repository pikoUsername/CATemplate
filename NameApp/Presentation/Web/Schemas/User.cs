using NameApp.Application.User.Dto;
using NameApp.Domain.User.Entities;
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

        public static UserScheme FromEntity(UserEntity entity)
        {
            return new UserScheme {
                Id = entity.Id,
                Name = entity.UserName, 
                EmailAddress = entity.EmailAddress 
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

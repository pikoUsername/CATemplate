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
        public string HashedPassword { get; set; } = null!;
        [Required]
        public string EmailAddress { get; set; } = null!;
        //public UserRoles Role { get; set; } = null!;

        public static UserScheme FromDTO()
        {

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

using System.ComponentModel.DataAnnotations;

namespace NameApp.Application.User.Dto
{
    public class RegisterDto
    {
        [Required]
        public string Name { get; set; } = null!;
        [Required]
        public string Password { get; set; } = null!;
        [Required]
        public string EmailAddress { get; set; } = null!;
        public string? Permission { get; set; } = null!;
    }
}

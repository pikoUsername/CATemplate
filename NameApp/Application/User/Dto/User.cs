using NameApp.Application.AccessService.Dto;
using System.ComponentModel.DataAnnotations;

namespace NameApp.Application.User.Dto
{

    public class UserDto {
        [Required]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; } = null!;
        [Required]
        public string EmailAddress { get; set; } = null!;
        public PermissionDto? Permission { get; set; } = null!;
    }
}

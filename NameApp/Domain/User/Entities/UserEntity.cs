using NameApp.Domain.Common;
using System.ComponentModel.DataAnnotations;

namespace NameApp.Domain.User.Entities
{
    public class UserEntity : BaseAuditableEntity
    {
        [Required]
        public string UserName { get; set; } = null!;
        [Required]
        public string HashedPassword { get; set;} = null!;
        [Required] 
        [EmailAddress(ErrorMessage = "Email address is not correct")]
        public string EmailAddress { get; set; } = null!;
        public PermissionEntity? Permission { get; set; } = null!; 
    }
}

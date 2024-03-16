using NameApp.Domain.Common;

namespace NameApp.Domain.User.Entities
{
    public class UserEntity : BaseAuditableEntity
    {
        public string UserName { get; set; } = null!; 
        public string HashedPassword { get; set;} = null!;
    }
}

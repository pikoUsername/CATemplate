using System.ComponentModel.DataAnnotations;

namespace NameApp.Application.AccessService.Dto
{
    public class PermissionDto
    {
        [Required]
        public string Name { get; set; } = null!;
        [Required]
        public Guid Id { get; set; }
        [Required]
        public string Code { get; set; } = null!; 
    }
}

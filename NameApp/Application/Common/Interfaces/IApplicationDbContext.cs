using Microsoft.EntityFrameworkCore;
using NameApp.Domain.User.Entities;

namespace NameApp.Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<UserEntity> Users { get; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}

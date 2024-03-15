using Microsoft.EntityFrameworkCore;

namespace NameApp.Infrastructure.Data
{
    public class ApplicationContext : DbContext 
    {
        public ApplicationContext(DbContextOptions options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
        }
    }
}

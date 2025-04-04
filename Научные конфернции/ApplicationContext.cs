using Microsoft.EntityFrameworkCore;

namespace Научные_конфернции
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Conference> Conferences { get; set; } = null!;
        public ApplicationContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Database=conferences;Username=postgres;Password=lazycat08");
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Science_Conferences;

namespace ScienceConferences.Data
{
    public class AppDbContext : DbContext
    {
        public virtual DbSet<Conference> Conferences { get; set; } = null!;
        public AppDbContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Database=conferences;Username=postgres;Password=postgres");
        }
    }
}

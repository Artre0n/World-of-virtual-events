using Microsoft.EntityFrameworkCore;

namespace Science_Conferences
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Conference> Conferences { get; set; } = null!;
        public ApplicationContext()
        {
            try
            {
                Database.EnsureCreated();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при подключении к базе данных: {ex.Message}", "Ошибка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Database=conferences;Username=postgres;Password=lazycat08");
        }
    }
}

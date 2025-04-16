using Microsoft.EntityFrameworkCore;

namespace Science_Conferences
{
    /// <summary>
    /// Доступ к базе данных (контекст приложения)
    /// </summary>
    public class ApplicationContext : DbContext
    {
        /// <summary>
        /// Инициализация таблицы в базе данных
        /// </summary>
        public DbSet<Conference> Conferences { get; set; } = null!;
        /// <summary>
        /// Конструктор, проверка существования базы данных и подключения к ней
        /// </summary>
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
        /// <summary>
        /// Осуществляет подключение к базе данных
        /// </summary>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Database=conferences;Username=postgres;Password=lazycat08");
        }
    }
}

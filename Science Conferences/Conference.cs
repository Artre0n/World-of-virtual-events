namespace Science_Conferences
{
    /// <summary>
    /// Модель таблицы базы данных
    /// </summary>
    public class Conference 
    {
        /// <summary>
        /// Первичный ключ
        /// </summary>
        public int ConferenceId { get; set; }
        /// <summary>
        /// Название конференции
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Описание
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Дата проведения
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// Время проведения
        /// </summary>
        public TimeSpan Time { get; set; }
        /// <summary>
        /// Категория 
        /// </summary>
        public string Category { get; set; }
        /// <summary>
        /// Участники
        /// </summary>
        public string Participants { get; set; }

    }
}

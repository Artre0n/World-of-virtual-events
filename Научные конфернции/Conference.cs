using System.ComponentModel.DataAnnotations;


namespace Научные_конфернции
{
    public class Conference 
    {
        public int ConferenceId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public string Category { get; set; }
        public string Participants { get; set; }
    }
}

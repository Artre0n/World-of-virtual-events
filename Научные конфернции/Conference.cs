using System.ComponentModel.DataAnnotations;


namespace Научные_конфернции
{
    public class Conference 
    {
        public int ConferenceId { get; set; }
        [Required]
        public string? Title { get; set; }
        public string? Description { get; set; }
        [Required]
        public DateTimeOffset Date { get; set; }
        [Required]
        public TimeSpan Time { get; set; }
        [Required]
        public string? Category { get; set; }
        public string? Participants { get; set; }
    }
}

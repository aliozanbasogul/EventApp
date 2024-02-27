using System.ComponentModel.DataAnnotations;

namespace EventApp.ViewModels
{
    public class EventViewModel
    {
        [Required]
        public string EventName { get; set; } = string.Empty;
        public string EventLocation { get; set; } = string.Empty;

        public string EventPrice { get; set; } = string.Empty;
        public string? Image { get; set; }

    } 
}
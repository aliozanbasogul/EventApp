using EventApp.Entity;

namespace EventApp.Models
{
    public class EventViewModel
    {
        public List<Event> Events { get; set; } = new();
    }
}
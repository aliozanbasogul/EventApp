namespace EventApp.Entity
{
    public class Event{
        public int EventId { get; set; }    
        public string? EventName { get; set; }   
        public string? EventLocation { get; set; }
        public float EventPrice { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<User>? EventAttendees { get; set; } = new List<User>();
        public string? Image { get; set; }
        
    }
}
namespace EventApp.Entity
{
    public class User{
        public int UserId { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Email { get; set; }  
        public string? Password { get; set; }
        public int Age { get; set; }    
        public string? Image { get; set; }
        public List<Event> RegisteredEvents { get; set; } = new List<Event>();
    }
}
namespace EventApp.Entity
{
    public class Comment{
        public int CommentId { get; set; }
        public string? Text { get; set; }
        public DateTime PublishedOn { get; set; }

        public int EventId { get; set; }
        public Event Events { get; set; } = null!;

        public int UserId { get; set; }
        public User User { get; set; } = null!;
    }
}
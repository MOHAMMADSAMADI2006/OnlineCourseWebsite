namespace OnlineCourseWebsite.Models
{
    public class messages
    {
        public Guid SenderId { get; set; }
        public string Message { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}

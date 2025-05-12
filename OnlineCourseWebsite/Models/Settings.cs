namespace OnlineCourseWebsite.Models
{
    public class Settings
    {
        public Guid Id { get; set; }
        public string About { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}

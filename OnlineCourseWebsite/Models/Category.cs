namespace OnlineCourseWebsite.Models
{
    public class Category
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string icon { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UodatedAt { get; set; }
    }
}

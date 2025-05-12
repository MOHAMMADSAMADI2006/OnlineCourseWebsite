namespace OnlineCourseWebsite.Models
{
    public class Season
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public string Title { get; set; }
        public int Order { get; set; }
    }
}

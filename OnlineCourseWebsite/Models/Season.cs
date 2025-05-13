namespace OnlineCourseWebsite.Models
{
    public class Season
    {
        public Guid Id { get; set; }
        public Guid CourseId { get; set; }
        public string Title { get; set; }
        public List<Lesson> lessons { get; set; }

    }
}

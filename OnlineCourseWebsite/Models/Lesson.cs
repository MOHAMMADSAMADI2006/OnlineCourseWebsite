namespace OnlineCourseWebsite.Models
{
    public class Lesson
    {
        public Guid Id { get; set; }
        public Guid SeasonId { get; set; }
        public string Title { get; set; }
        public string VideoUrl { get; set; }
        public string Status { get; set; }//enum
        public bool Lock { get; set; }
    }
}

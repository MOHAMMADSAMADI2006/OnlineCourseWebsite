namespace OnlineCourseWebsite.Models
{
    public class Lesson
    {
        public int Id { get; set; }
        public int SeasonId { get; set; }
        public string Title { get; set; }
        public string VideoUrl { get; set; }
        public TimeSpan Duration { get; set; }
        public int Order { get; set; }
        public bool IsFree { get; set; }
    }
}

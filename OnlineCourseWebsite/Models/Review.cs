namespace OnlineCourseWebsite.Models
{
    public class Review
    {
        public Guid Id { get; set; }
        public Guid CourseId { get; set; }//nav to course 
        public int UserId { get; set; }//nav to User
        public int Rating { get; set; }// use integer ,,1 to 5 
        public string Comment { get; set; }
        public string status { get; set; }//enum
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}

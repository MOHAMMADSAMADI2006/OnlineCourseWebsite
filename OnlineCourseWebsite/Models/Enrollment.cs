namespace OnlineCourseWebsite.Models
{
    public class Enrollment
    {

        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid CourseId { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime CreatedAt { get; set; }
        public Enrollment(Guid courseId, decimal totalAmount, DateTime createdAt)
        {
            Id = Guid.NewGuid();
            CourseId = courseId;
            TotalAmount = totalAmount;
            CreatedAt = createdAt;
        }

    }
}

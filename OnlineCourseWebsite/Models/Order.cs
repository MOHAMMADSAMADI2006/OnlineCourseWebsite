namespace OnlineCourseWebsite.Models
{
    public class Order
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }//nav to user 
        public Guid CourseId { get; set; }//nav to course
        public decimal TotalPrice { get; set; }
        public string PaymentId { get; set; }
        public string TrackingCode { get; set; }
        public string Status { get; set; }//compelet, pendig and etc
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

    }
}

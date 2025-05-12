namespace OnlineCourseWebsite.Models
{
    public class Payment
    {
        public Guid Id { get; set; }
        public Guid OrderId { get; set; }
        public decimal Amount { get; set; }
        public string Authority { get; set; } // کد درگاه
        public PaymentStatus Status { get; set; }
        public DateTime CreatedAt { get; set; }
    }
    public enum PaymentStatus { Pending, Paid, Failed }

}

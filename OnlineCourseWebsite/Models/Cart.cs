namespace OnlineCourseWebsite.Models
{
    public class Cart
    {
        public Guid Id { get; private set; }
        public Guid UserId { get; private set; }
        public Guid CourseId { get; private set; }
        public decimal TotalPrice { get; private set; }
        public decimal Discount { get; private set; }
        public decimal FinalPrice { get; private set; }

        // Public constructor for application logic
        public Cart(Guid userId, Guid courseId, decimal totalPrice, decimal discount)
        {
            Id = Guid.NewGuid();
            UserId = userId;
            CourseId = courseId;
            TotalPrice = totalPrice;
            Discount = discount;
            FinalPrice = totalPrice - discount;
        }

        // Private constructor for EF Core
        private Cart() { }
    }
}

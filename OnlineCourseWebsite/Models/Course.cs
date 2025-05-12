namespace OnlineCourseWebsite.Models
{
    public class Course
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Descripiton { get; set; }
        public decimal Price { get; set; }
        public Guid MentorId { get; set; }// navigation to userr 
        public Guid CategoryId { get; set; }// navigation to Category
        public string Image { get; set; }
        public string Teaser { get; set; }
        public decimal Discount { get; set; }
        public string Status { get; set; }//pub and etc...
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }
    }
}

using System.Collections.Generic;

namespace OnlineCourseWebsite.Models
{
    public class Course
    {
        public Guid Id { get; set; }
        public string Duration { get; set; }
        public string Title { get; set; }
        public string Descripiton { get; set; }
        public decimal Price { get; set; }
        public Guid MentorId { get; set; }// navigation to userr 
        public Guid CategoryId { get; set; }// navigation to Category
        public string Image { get; set; }
        public string Teaser { get; set; }
        public decimal Discount { get; set; }
        public bool IsActive { get; set; }
        public List<string> Seasons { get; set; }//create class season
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }


        public Course(string Duration, string Title, string Descripiton, decimal Price, Guid MentorId, Guid CategoryId, string Image, string Teaser, decimal Discount, bool IsActive, List<string> Seasons, DateTime CreateAt, DateTime UpdateAt, string duration, string title, string descripiton, decimal price, Guid mentorId, Guid categoryId, string image, string teaser, decimal discount, bool isActive, List<string> seasons, DateTime createAt, DateTime updateAt)
        {
            Id= Guid.NewGuid();
            this.Duration = duration;
            this.Title = title;
            this.Descripiton = descripiton;
            this.Price = price;
            this.MentorId = mentorId;
            this.CategoryId = categoryId;
            this.Image = image;
            this.Teaser = teaser;
            this.Discount = discount;
            this.IsActive = isActive;
            this.Seasons = seasons;
            this.CreateAt = createAt;
            this.UpdateAt = updateAt;
        }

    }
}

namespace OnlineCourseWebsite.Models
{
    public class Category
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string CountofCourseCategory { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UodatedAt { get; set; }

        public Category(string Title, string CountofCourseCategory, bool IsActive, DateTime CreatedAt, DateTime UodatedAt)
        {
            Id = Guid.NewGuid();
            this.Title = Title;
            this.CountofCourseCategory = CountofCourseCategory;
            this.IsActive = IsActive;
            this.CreatedAt = CreatedAt;
            this.UodatedAt = UodatedAt;
        }

        private Category() { }

    }

}

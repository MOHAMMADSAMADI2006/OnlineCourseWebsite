namespace OnlineCourseWebsite.Models
{
    public class Captcha
    {
        public Guid Id { get; set; }
        public string CaptchaText { get; set; }
        public bool IsVallid { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}

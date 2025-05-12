namespace OnlineCourseWebsite.Models
{
    public class Captcha
    {
        public Guid Id { get; private set; }
        public string CaptchaText { get; private set; }
        public bool IsVallid { get; private set; }
        public DateTime CreatedAt { get; private set; }

        // Public constructor to use in application code
        public Captcha(string captchaText, bool isVallid)
        {
            Id = Guid.NewGuid();
            CaptchaText = captchaText;
            IsVallid = isVallid;
            CreatedAt = DateTime.UtcNow;
        }

        // Private parameterless constructor for EF Core
        private Captcha() { }
    }
}

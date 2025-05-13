using Microsoft.AspNetCore.Identity;
using OnlineCourseWebsite.Enums;


namespace OnlineCourseWebsite.Models
{
    public class User :IdentityUser<int>
    {
        public  Guid Id { get; set; }
        public string PhoneNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }    
        public string Gender { get; set; }
        public string Password { get; set; }// should be hashed//identity
        public DateTime CreatedAt { get; set; }
        public DateTime UpdateAt { get; set; }


    }
}

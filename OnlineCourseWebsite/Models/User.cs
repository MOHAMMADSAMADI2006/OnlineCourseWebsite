using OnlineCourseWebsite.Enums;

namespace OnlineCourseWebsite.Models
{
    public class User
    {
        public  Guid Id { get; set; }
        public string PhoneNumber { get; set; }
        public string GoogleId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }    
        public string Gender { get; set; }
        public string Password { get; set; }// should be hashed
        public Role Roles { get; set; }//enum 
        public DateTime CreatedAt { get; set; }
        public DateTime UpdateAt { get; set; }


    }
}

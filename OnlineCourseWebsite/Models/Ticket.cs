﻿namespace OnlineCourseWebsite.Models
{
    public class Ticket
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; } //nav to user
        public string Subject { get; set; }
        public string Status { get; set; }// open , close and etc
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using OurSchedule.Models;

namespace OurSchedule.Models
{
    public class Users
    {
        public int Id { get; set; }

        public string? First_Name { get; set; }

        public string? Last_Name { get; set; }

        public string? Email { get; set; }

        public string? Role { get; set; }

        public string? Position { get; set; }

        public string? Department { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using OurSchedule.Models;

namespace OurSchedule.Models
{
    public class Availability
    {
        public int Id { get; set; }

        public string? User_Role { get; set; }

        public string? Shift_Id { get; set; }

        public string? Department { get; set; }

        public string? Location { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using OurSchedule.Models;

namespace OurSchedule.Models
{
    public class Location
    {
        public int Id { get; set; }

        public string? City_Name { get; set; }

        public string? State_Name { get; set; }
    }
}

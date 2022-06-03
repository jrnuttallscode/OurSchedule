using Microsoft.EntityFrameworkCore;
using OurSchedule.Models;

namespace OurSchedule.Models
{
    public class Shifts
    {
        public int Id { get; set; }

        public string? Title { get; set; }
    }
}

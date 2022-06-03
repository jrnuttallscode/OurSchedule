using Microsoft.EntityFrameworkCore;
using OurSchedule.Models;

namespace OurSchedule.Models
{
    public class Reports
    {
        public int Id { get; set; }

        public string? Title { get; set; }

        public string? Summary { get; set; }

        public string? Introduction { get; set; }

        public string? Body { get; set; }

        public string? Department_ID { get; set; }

        public int? User_ID { get; set; }
    }
}

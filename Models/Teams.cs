using Microsoft.EntityFrameworkCore;
using OurSchedule.Models;

namespace OurSchedule.Models
{
    public class Teams
    {
        public int Id { get; set; }

        public string? Dept_Name { get; set; }

        public int? Dept_Id { get; set; }

        public int? Location_Id { get; set; }
    }
}

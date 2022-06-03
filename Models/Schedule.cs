

using Microsoft.EntityFrameworkCore;
using OurSchedule.Models;

namespace OurSchedule.Models
{
    public class Schedule
    {
        public int Id { get; set; }

        public int? First_Name { get; set; }

        public int? Last_Name { get; set; }

        public int? Sunday { get; set; }

        public int? Monday { get; set; }

        public int? Tuesday { get; set; }

        public int? Wednesday { get; set; }

        public int? Thursday { get; set; }

        public int? Friday { get; set; }

        public int? Saturday { get; set; }

        public string? Reason { get; set; }
    }

    public class ScheduleContext : DbContext
    {
        public ScheduleContext(DbContextOptions<ScheduleContext> options) : base(options)
        {

        }
        public DbSet<Schedule> Schedule { get; set; }

        public DbSet<Availability> Availability { get; set; }

        public DbSet<Users> Users { get; set; }

        public DbSet<Location> Location { get; set; }

        public DbSet<Shifts> Shifts { get; set; }

        public DbSet<Teams> Teams { get; set; }

        public DbSet<Reports> Reports { get; set; }


    }
}


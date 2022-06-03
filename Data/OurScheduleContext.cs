using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OurSchedule.Models;

namespace OurSchedule.Data
{
    public class OurScheduleContext : DbContext
    {
        public OurScheduleContext (DbContextOptions<OurScheduleContext> options)
            : base(options)
        {
        }

        public DbSet<OurSchedule.Models.Schedule>? Schedule { get; set; }

        public DbSet<OurSchedule.Models.Users>? Users { get; set; }

        public DbSet<OurSchedule.Models.Reports>? Reports { get; set; }

        public DbSet<OurSchedule.Models.Availability>? Availability { get; set; }

        public DbSet<OurSchedule.Models.Shifts>? Shifts { get; set; }

        public DbSet<OurSchedule.Models.Location>? Location { get; set; }

        public DbSet<OurSchedule.Models.Teams>? Teams { get; set; }
    }
}

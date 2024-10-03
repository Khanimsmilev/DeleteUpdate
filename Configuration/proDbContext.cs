using delete_update.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delete_update.Configuration
{
    public class proDbContext:DbContext
    {
        public class SchoolContext : DbContext
        {
            public DbSet<Student> Students { get; set; }
            public DbSet<Group> Groups { get; set; }
            public DbSet<Teachers> Teachers { get; set; }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<Student>()
                    .HasOne(s => s.Group)
                    .WithOne(g => g.Student)
                    .HasForeignKey<Student>(s => s.GroupId);

                modelBuilder.Entity<Group>()
                    .HasOne(g => g.Teacher)
                    .WithMany(t => t.Groups)
                    .HasForeignKey(g => g.TeacherId);
            }
        }

    }
}

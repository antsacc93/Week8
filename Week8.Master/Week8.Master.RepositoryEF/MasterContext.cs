using Microsoft.EntityFrameworkCore;
using System;
using Week8.Master.Core.Entities;
using Week8.Master.RepositoryEF.Configuration;

namespace Week8.Master.RepositoryEF
{
    public class MasterContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optBuilder)
        {
            optBuilder.UseSqlServer(@"Persist Security Info = False; Integrated Security = true; 
                                    Initial Catalog = MasterMG; Server = .\SQLEXPRESS");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.ApplyConfiguration<Course>(new CourseConfiguration());
            modelBuilder.ApplyConfiguration<Student>(new StudentConfiguration());
            modelBuilder.ApplyConfiguration<Teacher>(new TeacherConfiguration());
            modelBuilder.ApplyConfiguration<Lesson>(new LessonConfiguration());

        }

    }
}

using Microsoft.EntityFrameworkCore;
using System;
using Week8.Master.Core.Entities;

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
            optBuilder.UseSqlServer("connectionString");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //MODELLO
        }

    }
}

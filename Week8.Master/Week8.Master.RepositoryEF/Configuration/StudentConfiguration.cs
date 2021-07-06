using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week8.Master.Core.Entities;

namespace Week8.Master.RepositoryEF.Configuration
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> modelBuilder)
        {
            modelBuilder.ToTable("Student");
            modelBuilder.HasKey(k => k.Id);
            modelBuilder.Property("Name").IsRequired();
            modelBuilder.Property("Surname").IsRequired();
            modelBuilder.Property("Email").IsRequired();
            modelBuilder.HasOne(x => x.Course).WithMany(s => s.Students)
                        .HasForeignKey(x => x.CourseCode);
        }
    }
}

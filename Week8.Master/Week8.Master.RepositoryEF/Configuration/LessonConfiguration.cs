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
    public class LessonConfiguration : IEntityTypeConfiguration<Lesson>
    {
        public void Configure(EntityTypeBuilder<Lesson> modelBuilder)
        {
            modelBuilder.ToTable("Lesson");
            modelBuilder.HasKey(k => k.Id);
            modelBuilder.Property("Room").IsRequired();
            modelBuilder.Property("Days").IsRequired();
            modelBuilder.Property("Resource").IsRequired();
            modelBuilder.Property("DateHour").IsRequired();
            modelBuilder.HasOne(x => x.Teacher)
                        .WithMany(l => l.Lessons)
                        .HasForeignKey(t => t.TeacherId);
            modelBuilder.HasOne(x => x.Course)
                        .WithMany(l => l.Lessons)
                        .HasForeignKey(t => t.CourseCode);
        }
    }
}

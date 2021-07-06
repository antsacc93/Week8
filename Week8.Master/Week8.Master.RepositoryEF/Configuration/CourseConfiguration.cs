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
    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> modelBuilder)
        {
            modelBuilder.ToTable("Course");
            modelBuilder.HasKey(k => k.Code);
            modelBuilder.Property("Name").IsRequired();
            modelBuilder.Property("Code").IsRequired();
            modelBuilder.Property("Description").IsRequired();
            
        }
    }
}

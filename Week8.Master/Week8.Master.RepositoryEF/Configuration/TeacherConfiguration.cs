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
    public class TeacherConfiguration : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> modelBuilder)
        {
            modelBuilder.ToTable("Teacher");
            modelBuilder.HasKey(k => k.Id);
            modelBuilder.Property("Name").IsRequired();
            modelBuilder.Property("Surname").IsRequired();
            modelBuilder.Property("Email").IsRequired();
            modelBuilder.Property("PhoneNumber").IsRequired();
            modelBuilder.HasDiscriminator<int>("teacher_type")
                        .HasValue<ExternalTeacher>(1)
                        .HasValue<InternalTeacher>(2);
            
        }
    }
}

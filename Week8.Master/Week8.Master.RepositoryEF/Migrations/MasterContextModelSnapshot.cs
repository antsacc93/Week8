﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Week8.Master.RepositoryEF;

namespace Week8.Master.RepositoryEF.Migrations
{
    [DbContext(typeof(MasterContext))]
    partial class MasterContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Week8.Master.Core.Entities.Course", b =>
                {
                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Code");

                    b.ToTable("Course");
                });

            modelBuilder.Entity("Week8.Master.Core.Entities.Lesson", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CourseCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("DateHour")
                        .HasColumnType("datetime2");

                    b.Property<int>("Days")
                        .HasColumnType("int");

                    b.Property<int>("Resource")
                        .HasColumnType("int");

                    b.Property<string>("Room")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TeacherId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CourseCode");

                    b.HasIndex("TeacherId");

                    b.ToTable("Lesson");
                });

            modelBuilder.Entity("Week8.Master.Core.Entities.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CourseCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CourseCode");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("Week8.Master.Core.Entities.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("teacher_type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Teacher");

                    b.HasDiscriminator<int>("teacher_type");
                });

            modelBuilder.Entity("Week8.Master.Core.Entities.ExternalTeacher", b =>
                {
                    b.HasBaseType("Week8.Master.Core.Entities.Teacher");

                    b.Property<string>("Company")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue(1);
                });

            modelBuilder.Entity("Week8.Master.Core.Entities.InternalTeacher", b =>
                {
                    b.HasBaseType("Week8.Master.Core.Entities.Teacher");

                    b.Property<int>("ActivityYears")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue(2);
                });

            modelBuilder.Entity("Week8.Master.Core.Entities.Lesson", b =>
                {
                    b.HasOne("Week8.Master.Core.Entities.Course", "Course")
                        .WithMany("Lessons")
                        .HasForeignKey("CourseCode");

                    b.HasOne("Week8.Master.Core.Entities.Teacher", "Teacher")
                        .WithMany("Lessons")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("Week8.Master.Core.Entities.Student", b =>
                {
                    b.HasOne("Week8.Master.Core.Entities.Course", "Course")
                        .WithMany("Students")
                        .HasForeignKey("CourseCode");

                    b.Navigation("Course");
                });

            modelBuilder.Entity("Week8.Master.Core.Entities.Course", b =>
                {
                    b.Navigation("Lessons");

                    b.Navigation("Students");
                });

            modelBuilder.Entity("Week8.Master.Core.Entities.Teacher", b =>
                {
                    b.Navigation("Lessons");
                });
#pragma warning restore 612, 618
        }
    }
}

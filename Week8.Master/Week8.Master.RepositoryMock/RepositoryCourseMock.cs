using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week8.Master.Core.Entities;
using Week8.Master.Core.Repositories;

namespace Week8.Master.RepositoryMock
{
    public class RepositoryCourseMock : IRepositoryCourse
    {
        private ICollection<Course> Courses = new List<Course>
        {
            new Course {
                Code = "C-01",
                Name = "Pre-Academy",
                Description = "C# COURSE",
                Students = new List<Student>{
                                    new Student {
                                        Id = 1,
                                        Name = "Mario",
                                        Surname = "Rossi",
                                        Email = "mrossi@email.it",
                                        LastTitle = "Degree in ICT"
                                    },
                                    new Student {
                                        Id = 2,
                                        Name = "Luca",
                                        Surname = "Bianchi",
                                        Email = "lbianchi@email.it",
                                        LastTitle = "Degree in ICT"
                                    },
                                    new Student {
                                        Id = 3,
                                        Name = "Giuseppe",
                                        Surname = "Verdi",
                                        Email = "gverdi@email.it",
                                        LastTitle = "Degree in ICT"
                                    }
                            }
            },
            new Course { Code = "C-02", Name = "Academy", Description = "C# Advanced COURSE"},
            new Course { Code = "C-03", Name = "Web-Application", Description = "HTML CSS JAVASCRIPT COURSE"},
        };



        public ICollection<Course> GetAll()
        {
            return Courses;
        }
    }
}

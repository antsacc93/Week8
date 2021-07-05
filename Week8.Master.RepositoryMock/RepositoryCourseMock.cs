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
            new Course { Code = "C-01", Name = "Pre-Academy", Description = "C# COURSE"},
            new Course { Code = "C-02", Name = "Academy", Description = "C# Advanced COURSE"},
            new Course { Code = "C-03", Name = "Web-Application", Description = "HTML CSS JAVASCRIPT COURSE"},
        };

        

        public ICollection<Course> GetAll()
        {
            return Courses;
        }
    }
}

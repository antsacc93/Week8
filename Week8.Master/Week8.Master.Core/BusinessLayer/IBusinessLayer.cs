using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week8.Master.Core.Entities;

namespace Week8.Master.Core.BusinessLayer
{
    public interface IBusinessLayer
    {
        public ICollection<Course> GetCourseWithStudents();
        public bool AssignTeacher(int id, Teacher teacher);
        public ICollection<Student> GetAllStudents();
    }
}

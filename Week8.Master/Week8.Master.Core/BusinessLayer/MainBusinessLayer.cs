using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week8.Master.Core.Entities;
using Week8.Master.Core.Repositories;

namespace Week8.Master.Core.BusinessLayer
{
    public class MainBusinessLayer : IBusinessLayer
    {
        private readonly IRepositoryCourse courseRepo;
        private readonly IRepositoryLesson lessonRepo;
        private readonly IRepositoryStudent studentRepo;
        private readonly IRepositoryTeacher teacherRepo;

        public MainBusinessLayer(IRepositoryCourse course,
            IRepositoryLesson lesson, IRepositoryStudent student, IRepositoryTeacher teacher)
        {
            courseRepo = course;
            lessonRepo = lesson;
            studentRepo = student;
            teacherRepo = teacher;
        }

        public bool AssignTeacher(int id, Teacher teacher)
        {
            if (id < 0 || teacher == null)
            {
                return false;
            }
            else
            {
                return lessonRepo.AssignTeacher(id, teacher);
            }
        }

        public ICollection<Student> GetAllStudents()
        {
            return studentRepo.GetAll();
        }

        public ICollection<Course> GetCourseWithStudents()
        {
            return courseRepo.GetAll();
        }
    }
}

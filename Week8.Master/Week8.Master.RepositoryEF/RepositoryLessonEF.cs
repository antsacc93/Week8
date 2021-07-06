using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week8.Master.Core.Entities;
using Week8.Master.Core.Repositories;

namespace Week8.Master.RepositoryEF
{
    public class RepositoryLessonEF : IRepositoryLesson
    {
        public bool Add(Lesson lesson)
        {
            using (var ctx = new MasterContext())
            {
                ctx.Lessons.Add(lesson);
                ctx.SaveChanges();
            }
            return true;
        }

        public bool AssignTeacher(int id, Teacher teacher)
        {
            using (var ctx = new MasterContext())
            {
                var lesson = ctx.Lessons.Find(id);
                lesson.Teacher = teacher;
                ctx.SaveChanges();
            }
            return true;
        }

        public bool Delete(Lesson lesson)
        {
            using (var ctx = new MasterContext())
            {
                ctx.Lessons.Remove(lesson);
                ctx.SaveChanges();
            }
            return true;
        }

        public ICollection<Lesson> GetAll()
        {
            ICollection<Lesson> result;
            using (var ctx = new MasterContext())
            {
                result = ctx.Lessons.ToList();
            }
            return result;

            
        }
    }
}

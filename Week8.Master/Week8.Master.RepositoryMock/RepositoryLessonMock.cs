using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week8.Master.Core.Entities;
using Week8.Master.Core.Repositories;

namespace Week8.Master.RepositoryMock
{
    public class RepositoryLessonMock : IRepositoryLesson
    {
        private ICollection<Lesson> Lessons = new List<Lesson>()
        {
            new Lesson {Id = 1, DateHour = new DateTime(2021, 7, 5), Days = 2, Room = "Virtual Room", Resource = Resource.PC},
            new Lesson {Id = 2, DateHour = new DateTime(2021, 7, 20), Days = 1, Room = "Aula 1", Resource = Resource.PC},
            new Lesson {Id = 3, DateHour = new DateTime(2021, 7, 12), Days = 3, Room = "Aula 2", Resource = Resource.PROJECTOR},
            new Lesson {Id = 4, DateHour = new DateTime(2021, 7, 10), Days = 4, Room = "Aula 3", Resource = Resource.PC},
            new Lesson {Id = 5, DateHour = new DateTime(2021, 7, 9), Days = 5, Room = "Virtual Room", Resource = Resource.TABLET},
        };
        public bool Add(Lesson lesson)
        {
            if(lesson != null)
            {
                Lessons.Add(lesson);
                return true;
            } else
            {
                return false;
            }           
        }
        
        public bool AssignTeacher(int id, Teacher teacher)
        {
            bool esito;
            if(teacher != null)
            {
                var lesson = Lessons.FirstOrDefault(x => x.Id == id);
                lesson.Teacher = teacher;
                esito = true;
            }
            else
            {
                esito = false;
            }
            return esito;
        }

        public bool Delete(Lesson lesson)
        {
            var lessonToDelete = Lessons.FirstOrDefault(x => x.Id == lesson.Id);            
            return Lessons.Remove(lessonToDelete);           
        }

        public ICollection<Lesson> GetAll()
        {
            return Lessons;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week8.Master.Core.Entities;
using Week8.Master.Core.Repositories;

namespace Week8.Master.RepositoryMock
{
    public static class RepositoryManager
    {
        public static Course CreateMasterCourse(string codeCourse)
        {
            IRepositoryCourse repoCourse = new RepositoryCourseMock();
            var master = repoCourse.GetAll().FirstOrDefault(x => x.Code.Equals(codeCourse));
            IRepositoryLesson repoLesson = new RepositoryLessonMock();
            master.Lessons.Add(repoLesson.GetAll().FirstOrDefault(x => x.Id == 1));
            master.Lessons.Add(repoLesson.GetAll().FirstOrDefault(x => x.Id == 2));
            IRepositoryStudent repoStudent = new RepositoryStudentMock();
            master.Students.Add(repoStudent.GetAll().FirstOrDefault(x => x.Id == 1));
            master.Students.Add(repoStudent.GetAll().FirstOrDefault(x => x.Id == 2));
            master.Students.Add(repoStudent.GetAll().FirstOrDefault(x => x.Id == 3));
            return master;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week8.Master.Core.Entities;

namespace Week8.Master.Core.Repositories
{
    public interface IRepositoryLesson : IRepository<Lesson>
    {
        public bool Add(Lesson lesson);
        public bool Delete(Lesson lesson);

        public bool AssignTeacher(int id, Teacher teacher);
    }
}

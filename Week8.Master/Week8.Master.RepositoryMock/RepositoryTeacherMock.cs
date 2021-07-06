using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week8.Master.Core.Entities;
using Week8.Master.Core.Repositories;

namespace Week8.Master.RepositoryMock
{
    public class RepositoryTeacherMock : IRepositoryTeacher
    {
        public bool Add(Teacher teacher)
        {
            throw new NotImplementedException();
        }

        public ICollection<Teacher> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}

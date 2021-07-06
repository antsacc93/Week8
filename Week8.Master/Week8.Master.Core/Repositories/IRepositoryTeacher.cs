using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week8.Master.Core.Entities;

namespace Week8.Master.Core.Repositories
{
    public interface IRepositoryTeacher : IRepository<Teacher>
    {
        public bool Add(Teacher teacher);
    }
}

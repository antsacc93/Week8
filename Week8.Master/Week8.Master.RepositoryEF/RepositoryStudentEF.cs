using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week8.Master.Core.Entities;
using Week8.Master.Core.Repositories;

namespace Week8.Master.RepositoryEF
{
    public class RepositoryStudentEF : IRepositoryStudent
    {
        public ICollection<Student> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}

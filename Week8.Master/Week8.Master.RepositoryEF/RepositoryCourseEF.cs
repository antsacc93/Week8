using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week8.Master.Core.Entities;
using Week8.Master.Core.Repositories;

namespace Week8.Master.RepositoryEF
{
    public class RepositoryCourseEF : IRepositoryCourse
    {
        public ICollection<Course> GetAll()
        {
            using (var ctx = new MasterContext())
            {
                return ctx.Courses.Include(x => x.Students).ToList();
            }
            
        }
    }
}

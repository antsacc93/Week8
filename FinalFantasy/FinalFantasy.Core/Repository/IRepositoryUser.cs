using FinalFantasy.Core.Entities;
using FinalFantasy.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy.Core.Repository
{
    public interface IRepositoryUser
    {
        public IList<User> GetAll();
        public User GetByNickname(string nickname);
        public void Add(User user);
    }
}

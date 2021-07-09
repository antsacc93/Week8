using FinalFantasy.Core.Entities;
using FinalFantasy.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy.Core.Repository
{
    public interface IRepositoryHero
    {
        public IList<Hero> GetHeroesByUser(User user);
        public Hero GetById(int id);
        public void Add(Hero hero);
        public void Remove(int id);
    }
}

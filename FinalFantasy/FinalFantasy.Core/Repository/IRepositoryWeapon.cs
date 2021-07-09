using FinalFantasy.Core.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy.Core.Repository
{
    public interface IRepositoryWeapon
    {
        public IList<Weapon> GetWeaponsByClass(string tipology);
        public Weapon GetById(int id);
    }
}

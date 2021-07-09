using FinalFantasy.Core.Entities;
using System.Collections.Generic;

namespace FinalFantasy.Core.Repository
{
    public interface IRepositoryMonster
    {
        public IList<Monster> GetMonsterByLevel(int levelNumber);
    }
}

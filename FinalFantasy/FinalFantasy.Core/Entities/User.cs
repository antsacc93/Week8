using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy.Core.Entities
{
    public class User
    {
        public int ID { get; set; }
        public string NickName { get; set; }
        public ICollection<Hero> Heroes = new List<Hero>();

        public override string ToString()
        {
            return $"ID: {ID} - Nickname: {NickName}";
        }
    }
}

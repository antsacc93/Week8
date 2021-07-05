using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8.Master.Core.Entities
{
    public class Student : Person
    {
        public string LastTitle { get; set; }
        public Course Course { get; set; }
    }
}

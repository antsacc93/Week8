using System.Collections.Generic;

namespace Week8.Master.Core.Entities
{
    public abstract class Teacher : Person
    {
        
        public string PhoneNumber { get; set; }
        public ICollection<Lesson> Lessons { get; set; } = new List<Lesson>();
    }
}
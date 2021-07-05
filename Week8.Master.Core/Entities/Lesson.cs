using System;

namespace Week8.Master.Core.Entities
{
    public enum Resource
    {
        PC,
        TABLET,
        PROJECTOR
    }
    public class Lesson
    {
        public int Id { get; set; }
        public DateTime DateHour { get; set; }
        public string Room { get; set; }
        public int Days { get; set; }
        public Resource Resource { get; set; }
        public Teacher Teacher { get; set; }

    }
}
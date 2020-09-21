using System;

namespace StudentService.Data
{
    [Serializable]
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Teacher Lecturer { get; set; }
    }
}

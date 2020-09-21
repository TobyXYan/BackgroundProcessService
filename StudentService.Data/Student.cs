using System;
using System.Collections.Generic;
using System.Text;

namespace StudentService.Data
{
     [Serializable]
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}

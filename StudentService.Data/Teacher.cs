using System;
using System.Collections.Generic;
using System.Text;

namespace StudentService.Data
{
     [Serializable]
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public bool Gender { get; set; }
    }
}

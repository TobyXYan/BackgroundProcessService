using System;
using System.Windows;
using StudentService.Data;
using StudentService.Proxy;

namespace NetService.Services
{
    //MarshalByRefObject -  Enable access to objects across application domain boundaries in applications that support remoting
    public class CourseService : MarshalByRefObject, ICourseService
    {
        public Course Get(int id)
        {
            var teacher = new Teacher() { Name = "JianZhang", Gender = true, Age = 54 };
            return new Course() { Name = "Math", Lecturer = teacher };
        }
    }
}

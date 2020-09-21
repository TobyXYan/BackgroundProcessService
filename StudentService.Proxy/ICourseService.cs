using StudentService.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentService.Proxy
{
    public interface ICourseService
    {
        Course Get(int id);
    }
}

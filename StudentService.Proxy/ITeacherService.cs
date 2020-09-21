using System;
using System.Collections.Generic;
using System.Text;
using StudentService.Data;


namespace StudentService.Proxy
{
    public interface ITeacherService
    {
        Teacher Get(int id);
    }
}

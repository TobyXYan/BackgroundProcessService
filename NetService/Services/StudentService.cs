using System;
using StudentService.Proxy;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentService.Data;

namespace NetService.Services
{
    //MarshalByRefObject -  Enable access to objects across application domain boundaries in applications that support remoting
    public class StudentService : MarshalByRefObject, IStudentService
    {
        public Student Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}

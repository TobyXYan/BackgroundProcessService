using StudentService.Data;

namespace StudentService.Proxy
{
    public interface IStudentService
    {
        Student Get(int id);
    }
}

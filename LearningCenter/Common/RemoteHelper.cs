using System;

namespace LearningCenter.Common
{
    public class RemoteHelper
    {
  
        private string CourseServiceUri = null;
        private string StudentServiceUri = null;
        private string TeacherServiceUri = null;
        private readonly int port = 55559;
        private const string Protocol = "tcp";
        public RemoteHelper()
        {
            CourseServiceUri = GetRemotingUrl("localhost", Protocol,port,  "CourseService.rem");
            StudentServiceUri = GetRemotingUrl("localhost", Protocol,port, "StudentService.rem");
            TeacherServiceUri = GetRemotingUrl("localhost", Protocol,port, "TeacherService.rem");
        }

         private string GetRemotingUrl(string host, string protocol, int port, string uri)
        {
            UriBuilder url = new UriBuilder {Scheme = protocol, Port = port, Path = uri, Host = host};
            return url.Uri.ToString();
        }

        public string GetCourseServiceUri()
        {
            return CourseServiceUri;
        }

         public string GetStudentServiceUri()
        {
            return StudentServiceUri;
        }

         public string GetTeacherServiceUri()
        {
            return TeacherServiceUri;
        }
    }
}

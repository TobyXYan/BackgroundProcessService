using System.Reflection;
using System.Diagnostics;
using System.Windows;
using Caliburn.Micro;
using System.Dynamic;

namespace LearningCenter.ViewModels
{
    public class ShellViewModel
    {
        private readonly string _processName = "NetService.exe";

        public Point BtnPosition { get; set; }
        public void OnClickButton()
        {
            Process[] processes = Process.GetProcessesByName(_processName);
            if (processes.Length > 0)
                return;
            var directory = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            Process p = new Process();
            p.StartInfo = new ProcessStartInfo(_processName);
            p.StartInfo.WorkingDirectory = directory;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.CreateNoWindow = true;//Making sure no window for the process
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            p.Start();

            //Process.Start(System.IO.Path.Combine(directory,"StudentService.exe")) ;
        }

        public void GetCourseService()
        {
            var msgView = IoC.Get<MessageViewModel>();
            dynamic settings = new ExpandoObject();
            settings.Top = BtnPosition.Y;
            settings.Left = BtnPosition.X+400;
            var wndManager = IoC.Get<IWindowManager>();

            var courseService = Caliburn.Micro.IoC.Get<StudentService.Proxy.ICourseService>();
            var course = courseService.Get(1);
            msgView.MsgText = $"The course is {course.Name}, which is taught by {course.Lecturer.Name}, who is at the age of {course.Lecturer.Age}";
            msgView.ViewWidth = 200;
            msgView.ViewHeight = 150;
            wndManager.ShowDialog(msgView,null, settings);
        }
    }
}

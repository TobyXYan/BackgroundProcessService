using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace NetService
{
     public static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            int a = 0;
            var serviceHelper = new ServiceHelper();
            var success = serviceHelper.StartService();
            if (success)
                System.Windows.Forms.Application.Run();
        }
    }
}

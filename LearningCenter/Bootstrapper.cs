using System;
using System.Collections.Generic;
using Caliburn.Micro;
using LearningCenter.ViewModels;
using System.Windows;
using StudentService.Proxy;
using LearningCenter.Common;

namespace LearningCenter
{
    class Bootstrapper:BootstrapperBase
    {
        protected readonly SimpleContainer Container = new SimpleContainer();
        public Bootstrapper()
        {
            Initialize();
            //In Source Code
            //      protected virtual void PrepareApplication()
            //{
            //    Application.Startup += OnStartup;
            //    Application.DispatcherUnhandledException += OnUnhandledException;
            //    Application.Exit += OnExit;
            //}
            //Configure();
            //IoC.GetInstance = GetInstance;
            //IoC.GetAllInstances = GetAllInstances;
            //IoC.BuildUp = BuildUp;

        }


        protected override void Configure()
        {
            Container.Singleton<IWindowManager, WindowManager>();
            Container.Singleton<IEventAggregator, EventAggregator>();
            Container.PerRequest<ShellViewModel>();
            Container.PerRequest<RemoteHelper>();
            Container.PerRequest<MessageViewModel>();
            Container.RegisterHandler(typeof(ICourseService), null,  CreateCourseService);
            Container.RegisterHandler(typeof(IStudentService), null, CreateStudentService);
            Container.RegisterHandler(typeof(ITeacherService), null, CreateTeacherService);
        }

        public object CreateCourseService(SimpleContainer container)
        {
            var remoteHelper = IoC.Get<RemoteHelper>();
            return (ICourseService)Activator.GetObject(typeof(ICourseService),remoteHelper.GetCourseServiceUri());
        }
        public object CreateStudentService(SimpleContainer container)
        {
            var remoteHelper = IoC.Get<RemoteHelper>();
            return (IStudentService)Activator.GetObject(typeof(IStudentService),remoteHelper.GetStudentServiceUri());
        }

        public object CreateTeacherService(SimpleContainer container)
        {
            var remoteHelper = IoC.Get<RemoteHelper>();
            return (ITeacherService)Activator.GetObject(typeof(ITeacherService),remoteHelper.GetTeacherServiceUri());
        }

        protected override object GetInstance(Type service, string key)
        {
            var instance = Container.GetInstance(service, key);
            if (instance != null) 
                return instance;
            throw new InvalidOperationException("Could not locate any instance.");
        }

        protected override IEnumerable<object> GetAllInstances(Type service)
        {
            return Container.GetAllInstances(service);
        }

        protected override void BuildUp(object instance)
        {
            Container.BuildUp(instance);
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<ShellViewModel>();
        }
    }
}

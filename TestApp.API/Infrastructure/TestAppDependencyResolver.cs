using Ninject;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestApp.BLL.Interfaces;
using TestApp.BLL.Services;
using TestApp.DAL.Interfaces;
using TestApp.DAL.Repository;

namespace TestApp.API.Infrastructure
{
    public class TestAppDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;
        public TestAppDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }

        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }

        private void AddBindings()
        {
            kernel.Bind<IUnitOfWork>().To<EFUnitOfWork>();
            kernel.Bind<IEmployeesService>().To<EmployeesService>();
            kernel.Bind<IProjectsService>().To<ProjectsService>();
            kernel.Bind<ITasksService>().To<TasksService>();
        }
    }
}
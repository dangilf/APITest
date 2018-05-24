using System;
using System.Collections;
using TestApp.DAL.EF;
using TestApp.DAL.Interfaces;
using TestApp.Domain.Core.Models;

namespace TestApp.DAL.Repository
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private TestAppDBContext db;
        private Hashtable repositories;

        //private Repository<Employee> employeesRepository;
        //private Repository<Project> projectsRepository;
        //private Repository<Task> tasksRepository;

        public EFUnitOfWork()
        {
            db = new TestAppDBContext();
        }

        //public IRepository<Employee> Employees
        //{
        //    get
        //    {
        //        if(employeesRepository==null)
        //        {
        //            employeesRepository = new Repository<Employee>(db);
        //        }
        //        return employeesRepository;
        //    }
        //}

        //public IRepository<Project> Projects
        //{
        //    get
        //    {
        //        if (projectsRepository == null)
        //        {
        //            projectsRepository = new Repository<Project>(db);
        //        }
        //        return projectsRepository;
        //    }
        //}

        //public IRepository<Task> Tasks
        //{
        //    get
        //    {
        //        if (tasksRepository == null)
        //        {
        //            tasksRepository = new Repository<Task>(db);
        //        }
        //        return tasksRepository;
        //    }
        //}
        public IRepository<TEntity> Repository<TEntity>() where TEntity : BaseEntity
        {
            if (repositories == null)
                repositories = new Hashtable();

            var type = typeof(TEntity).Name;

            if (repositories.ContainsKey(type)) return (IRepository<TEntity>)repositories[type];

            var repositoryType = typeof(Repository<>);

            var repositoryInstance =
                Activator.CreateInstance(repositoryType
                    .MakeGenericType(typeof(TEntity)), db);

            repositories.Add(type, repositoryInstance);

            return (IRepository<TEntity>)repositories[type];
        }



        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }


    }
}
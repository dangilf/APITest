using System;
using System.Collections;
using TestApp.DAL.EF;
using TestApp.DAL.Interfaces;
using TestApp.DAL.Models;

namespace TestApp.DAL.Repository
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private TestAppDBContext db;
        private Hashtable repositories;

        public EFUnitOfWork()
        {
            db = new TestAppDBContext();
        }

       
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
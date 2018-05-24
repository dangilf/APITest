using System;
using TestApp.Domain.Core.Models;

namespace TestApp.DAL.Interfaces
{
    public interface IUnitOfWork: IDisposable
    {
        //IRepository<Employee> Employees { get; }
        //IRepository<Project> Projects { get; }
        //IRepository<Task> Tasks { get; }
        IRepository<TEntity> Repository<TEntity>() where TEntity:BaseEntity;
        void Save();
    }
}

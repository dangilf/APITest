using System;
using TestApp.DAL.Models;

namespace TestApp.DAL.Interfaces
{
    public interface IUnitOfWork: IDisposable
    {
        IRepository<TEntity> Repository<TEntity>() where TEntity:BaseEntity;
        void Save();
    }
}

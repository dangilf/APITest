using System;
using System.Collections.Generic;
using TestApp.Domain.Core.Models;

namespace TestApp.DAL.Interfaces
{
    public interface IRepository<TEntity> where TEntity : BaseEntity
    {
        void Create(TEntity item);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> Get(Func<TEntity, bool> predicate);
        void Remove(TEntity item);
        void Remove(int id);
        void Update(TEntity item);
    }
}

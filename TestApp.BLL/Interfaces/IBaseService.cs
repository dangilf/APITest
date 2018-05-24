using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApp.Domain.Core.Models;

namespace TestApp.BLL.Interfaces
{
    public interface IBaseService<TEntity> where TEntity: BaseEntity
    {
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> Get(Func<TEntity, bool> predicate);
        TEntity GetById(int id);
        void Create(TEntity entity);
        void Delete(TEntity entity);
        void Delete(int id);
        void Update(TEntity entity);
    }
}

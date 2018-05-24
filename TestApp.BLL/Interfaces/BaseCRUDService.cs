using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApp.DAL.Interfaces;
using TestApp.Domain.Core.Models;

namespace TestApp.BLL.Interfaces
{
    public abstract class BaseCRUDService<TEntity> where TEntity:BaseEntity
    {
        internal IUnitOfWork uof { get; set; }
        public BaseCRUDService(IUnitOfWork unitOfWork)
        {
            uof = unitOfWork;
        }

        public IEnumerable<TEntity> GetAll()
        {
            return uof.Repository<TEntity>().GetAll();
        }

        public IEnumerable<TEntity> Get(Func<TEntity, bool> predicate)
        {
            return uof.Repository<TEntity>().Get(predicate);
        }

        public TEntity GetById(int id)
        {
            return uof.Repository<TEntity>().FindById(id);
        }

        public void Create(TEntity entity)
        {
            uof.Repository<TEntity>().Create(entity);
        }

        public void Delete(TEntity entity)
        {
            uof.Repository<TEntity>().Remove(entity);
        }

        public void Delete(int id)
        {
            uof.Repository<TEntity>().Remove(id);
        }
        public void Update(TEntity entity)
        {
            uof.Repository<TEntity>().Update(entity);
        }
    }
}

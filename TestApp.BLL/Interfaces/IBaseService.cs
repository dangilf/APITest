using System;
using System.Collections.Generic;
using TestApp.BLL.Models;
using TestApp.DAL.Models;

namespace TestApp.BLL.Services
{
    public interface IBaseService<TEntity, TDTO> where TEntity : BaseEntity where TDTO : BaseDTO
    {
        IEnumerable<TDTO> GetAll();
        TDTO GetById(int id);
        void Create(TDTO entity);
        void Delete(TDTO entity);
        void Delete(int id);
        void Update(TDTO entity);
    }
}

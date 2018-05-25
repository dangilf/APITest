
using System.Collections.Generic;
using System.Web.Http;
using TestApp.BLL.Services;
using TestApp.BLL.Models;
using TestApp.DAL.Models;

namespace TestApp.API.Controllers
{
    public abstract class BaseApiController<TEntity, TDTO> : ApiController where TEntity : BaseEntity where TDTO : BaseDTO
    {
        internal IBaseService<TEntity, TDTO> baseService;


        public BaseApiController(IBaseService<TEntity, TDTO> svc)
        {
            baseService = svc;
        }

        [HttpGet]
        [Route("")]
        public IEnumerable<TDTO> GetAll()
        {
            return baseService.GetAll();
        }

        [HttpGet]
        [Route("{id}")]
        public TDTO Get(int id)
        {
            return baseService.GetById(id);
        }

        [HttpPost]
        [Route("")]
        public void Create([FromBody]TDTO model)
        {
            baseService.Create(model);
        }

        [HttpPut]
        [Route("")]
        public void Update([FromBody]TDTO model)
        {
            baseService.Update(model);
        }

        [HttpDelete]
        [Route("{id}")]
        public void Delete(int id)
        {
            baseService.Delete(id);
        }
    }
}

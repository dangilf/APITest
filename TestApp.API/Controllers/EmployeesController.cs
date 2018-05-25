using System;
using System.Collections.Generic;
using System.Web.Http;
using TestApp.BLL.Services;
using TestApp.BLL.Models;
using TestApp.DAL.Models;

namespace TestApp.API.Controllers
{
    [RoutePrefix("employees")]
    public class EmployeesController : BaseApiController<Employee,EmployeeDTO>
    {
        IEmployeesService employeesService;

        public EmployeesController(IEmployeesService empService):base(empService)
        {
            employeesService = empService;
        }

        [HttpGet]
        [Route("{employeeId}/tasks")]
        public IEnumerable<TaskDTO> GetAllTasks(int employeeId)
        {
            return employeesService.GetAllTasks(employeeId); 
        }

        [HttpGet]
        [Route("{employeeId}/{projectId}/tasks")]
        public IEnumerable<TaskDTO> GetTasksByProject(int employeeId, int projectId)
        {
            return employeesService.GetAllTasksByProject(employeeId, projectId);
        }

        [HttpGet]
        [Route("{employeeId}/tasks/{status}")]
        public IEnumerable<TaskDTO> GetTasksByStatus(int employeeId,string status)
        {
            return employeesService.GetAllTasksByStatus(employeeId, status);
        }


    }
}

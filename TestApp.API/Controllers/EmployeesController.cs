using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TestApp.BLL.Interfaces;
using TestApp.Domain.Core.Models;

namespace TestApp.API.Controllers
{
    public class EmployeesController : ApiController
    {
        IEmployeesService employeesService;

        public EmployeesController(IEmployeesService empService)
        {
            employeesService = empService;
        }

        [Route("employees/{employeeId}/tasks")]
        public IEnumerable<Task> Get(int employeeId)
        {
            var tasks = employeesService.GetAllTasks(employeeId);
            return tasks;
        }

        [Route("employees/{employeeId}/{projectId}/tasks")]
        public IEnumerable<Task> Get(int employeeId, int projectId)
        {
            return employeesService.GetAllTasksByProject(employeeId, projectId);
        }

        [Route("employees/{employeeId}/tasks/{status}")]
        public IEnumerable<Task> Get(int employeeId,string status)
        {
            return employeesService.GetAllTasksByStatus(employeeId, status);
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TestApp.BLL.Services;
using TestApp.BLL.Models;
using TestApp.DAL.Models;

namespace TestApp.API.Controllers
{
    [RoutePrefix("tasks")]
    public class TasksController : BaseApiController<Task, TaskDTO>
    {
        ITasksService tasksService;

        public TasksController(ITasksService tskService):base(tskService)
        {
            tasksService = tskService;
        }

        [HttpPut]
        [Route("{taskId}/assignToEmployee/{employeeId}")]
        public void AssignTaskToEmployee(int taskId,int employeeId)
        {
            tasksService.AssignTaskToEmployee(taskId, employeeId);
        }

        [HttpPut]
        [Route("{taskId}/assignToProject/{projectId}")]
        public void AssignTaskToProject(int taskId, int projectId)
        {
            tasksService.AssignTaskToProject(taskId, projectId);
        }

        [HttpPut]
        [Route("{taskId}/{status}")]
        public void Post(int taskId, string status)
        {
            tasksService.SetTaskStatus(taskId, status);
        }
    }
}

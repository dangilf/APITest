using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TestApp.BLL.Interfaces;

namespace TestApp.API.Controllers
{
    public class TasksController : ApiController
    {
        ITasksService tasksService;

        public TasksController(ITasksService tskService)
        {
            tasksService = tskService;
        }

        [Route("tasks/{taskId}/assign/{employeeId}")]
        public void Post(int taskId,int employeeId)
        {
            tasksService.AssignTask(taskId, employeeId);
        }

        [Route("tasks/{taskId}/done")]
        public void Post(int taskId, string status)
        {
            tasksService.SetTaskStatus(taskId, status);
        }
    }
}

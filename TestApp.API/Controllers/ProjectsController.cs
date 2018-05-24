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
    public class ProjectsController : ApiController
    {
        IProjectsService projectsService;

        public ProjectsController(IProjectsService prjService)
        {
            projectsService = prjService;
        }

        [Route("projects/{projectId}/tasks")]
        public IEnumerable<Task> Get(int projectId)
        {
            return projectsService.GetAllTasks(projectId);
        }
        
        [Route("projects/{projectId}/tasks/{status}")]
        public IEnumerable<Task> Get(int projectId, string status)
        {
            return projectsService.GetTasksByStatus(projectId, status);
        }
    }
}

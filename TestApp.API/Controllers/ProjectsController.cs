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
    [RoutePrefix("projects")]
    public class ProjectsController : BaseApiController<Project, ProjectDTO>
    {
        IProjectsService projectsService;

        public ProjectsController(IProjectsService prjService):base(prjService)
        {
            projectsService = prjService;
        }

        [HttpGet]
        [Route("{projectId}/tasks")]
        public IEnumerable<TaskDTO> GetAllTasks(int projectId)
        {
            return projectsService.GetAllTasks(projectId);
        }
        
        [HttpGet]
        [Route("{projectId}/tasks/{status}")]
        public IEnumerable<TaskDTO> GetTasksByStatus(int projectId, string status)
        {
            return projectsService.GetTasksByStatus(projectId, status);
        }
    }
}

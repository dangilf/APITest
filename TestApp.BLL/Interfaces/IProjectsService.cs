using System;
using System.Collections.Generic;
using TestApp.BLL.Models;
using TestApp.DAL.Models;

namespace TestApp.BLL.Services
{
    public interface IProjectsService:IBaseService<Project, ProjectDTO>
    {
        IEnumerable<TaskDTO> GetAllTasks(int projectId);
        IEnumerable<TaskDTO> GetTasksByStatus(int projectId, string status);
        
    }
}

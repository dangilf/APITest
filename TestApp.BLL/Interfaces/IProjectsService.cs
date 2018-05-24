using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestApp.Domain.Core.Models;

namespace TestApp.BLL.Interfaces
{
    public interface IProjectsService:IBaseService<Project>
    {
        IEnumerable<Task> GetAllTasks(int projectId);
        IEnumerable<Task> GetTasksByStatus(int projectId, string status);
        
    }
}

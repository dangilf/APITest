using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestApp.BLL.Models;
using TestApp.DAL.Models;

namespace TestApp.BLL.Services
{
    public interface ITasksService: IBaseService<Task, TaskDTO>
    {
        void AssignTaskToEmployee(int taskId, int employeeId);
        void AssignTaskToProject(int taskId, int projectId);
        void SetTaskStatus(int taskId, string status);        
    }
}

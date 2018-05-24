using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestApp.Domain.Core.Models;

namespace TestApp.BLL.Interfaces
{
    public interface ITasksService: IBaseService<Task>
    {
        void AssignTask(int taskId, int employeeId);
        void SetTaskStatus(int taskId, string status);        
    }
}

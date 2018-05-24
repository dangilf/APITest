using System;
using System.Collections.Generic;
using TestApp.Domain.Core.Models;

namespace TestApp.BLL.Interfaces
{
    public interface IEmployeesService: IBaseService<Employee>
    {
        IEnumerable<Task> GetAllTasks(int employeeId);
        IEnumerable<Task> GetAllTasksByProject(int employeeId, int projectId);
        IEnumerable<Task> GetAllTasksByStatus(int employeeId, string status);
        

    }
}

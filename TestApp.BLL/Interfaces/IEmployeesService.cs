using System;
using System.Collections.Generic;
using TestApp.BLL.Models;
using TestApp.DAL.Models;

namespace TestApp.BLL.Services
{
    public interface IEmployeesService: IBaseService<Employee,EmployeeDTO>
    {
        IEnumerable<TaskDTO> GetAllTasks(int employeeId);
        IEnumerable<TaskDTO> GetAllTasksByProject(int employeeId, int projectId);
        IEnumerable<TaskDTO> GetAllTasksByStatus(int employeeId, string status);
    }
}

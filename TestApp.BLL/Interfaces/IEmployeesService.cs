using System;
using System.Collections.Generic;
using TestApp.Domain.Core.Models;

namespace TestApp.BLL.Interfaces
{
    public interface IEmployeesService
    {
        IEnumerable<Task> GetAllTasks(int employeeId);
        IEnumerable<Task> GetAllTasksByProject(int employeeId, int projectId);
        IEnumerable<Task> GetAllTasksByStatus(int employeeId, string status);
        IEnumerable<Employee> GetAll();
        IEnumerable<Employee> Get(Func<Employee, bool> predicate);
        Employee GetById(int id);
        void Create(Employee entity);
        void Delete(Employee entity);
        void Delete(int id);
        void Update(Employee entity);

    }
}

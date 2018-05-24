using System.Collections.Generic;
using TestApp.BLL.Interfaces;
using TestApp.DAL.Interfaces;
using TestApp.Domain.Core.Models;

namespace TestApp.BLL.Services
{
    public class EmployeesService : BaseCRUDService<Employee>, IEmployeesService
    {
        public EmployeesService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public IEnumerable<Task> GetAllTasks(int employeeId)
        {
            return uof.Repository<Task>().Get(t => t.Employee.ID == employeeId);
        }

        public IEnumerable<Task> GetAllTasksByProject(int employeeId, int projectId)
        {
            return uof.Repository<Task>().Get(t => t.Employee.ID == employeeId && t.Project.ID == projectId);
        }

        public IEnumerable<Task> GetAllTasksByStatus(int employeeId, string status)
        {
            return uof.Repository<Task>().Get(t => t.Employee.ID == employeeId && t.Status.Equals(status));
        }
    }
}

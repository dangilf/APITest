using TestApp.BLL.Services;
using TestApp.BLL.Models;
using TestApp.DAL.Interfaces;
using TestApp.DAL.Models;

namespace TestApp.BLL.Services
{
    public class TasksService : BaseCRUDService<Task, TaskDTO>, ITasksService
    {
        public TasksService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public void AssignTaskToEmployee(int taskId, int employeeId)
        {
            var employee = uof.Repository<Employee>().GetById(employeeId);
            var task = uof.Repository<Task>().GetById(taskId);
            if (task != null)
            {
                task.Employee = employee;
                uof.Repository<Task>().Update(task);
                uof.Save();
            }
        }

        public void AssignTaskToProject(int taskId, int projectId)
        {
            var project = uof.Repository<Project>().GetById(projectId);
            var task = uof.Repository<Task>().GetById(taskId);
            if (task != null)
            {
                task.Project = project;
                uof.Repository<Task>().Update(task);
                uof.Save();
            }
        }

        public void SetTaskStatus(int taskId, string status)
        {
            var task = uof.Repository<Task>().GetById(taskId);
            if (task != null)
            {
                task.Status = status;
                uof.Repository<Task>().Update(task);
                uof.Save();
            }
        }
    }
}

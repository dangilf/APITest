using System;
using System.Collections.Generic;
using TestApp.BLL.Interfaces;
using TestApp.DAL.Interfaces;
using TestApp.Domain.Core.Models;

namespace TestApp.BLL.Services
{
    public class TasksService : BaseCRUDService<Task>, ITasksService
    {
        public TasksService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public void AssignTask(int taskId, int employeeId)
        {
            var employee = uof.Repository<Employee>().GetById(employeeId);
            var task = uof.Repository<Task>().GetById(taskId);
            task.Employee = employee;
            uof.Repository<Task>().Update(task);
            uof.Save();
        }

        public void SetTaskStatus(int taskId, string status)
        {
            var task = uof.Repository<Task>().GetById(taskId);
            task.Status = status;
            uof.Repository<Task>().Update(task);
            uof.Save();
        }
    }
}

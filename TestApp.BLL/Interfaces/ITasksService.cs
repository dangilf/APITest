using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestApp.Domain.Core.Models;

namespace TestApp.BLL.Interfaces
{
    public interface ITasksService
    {
        void AssignTask(int taskId, int employeeId);
        void SetTaskStatus(int taskId, string status);
        IEnumerable<Task> GetAll();
        IEnumerable<Task> Get(Func<Task, bool> predicate);
        Task GetById(int id);
        void Create(Task entity);
        void Delete(Task entity);
        void Delete(int id);
        void Update(Task entity);
    }
}
